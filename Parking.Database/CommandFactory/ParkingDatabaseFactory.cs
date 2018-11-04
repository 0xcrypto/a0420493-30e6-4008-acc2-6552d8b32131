﻿using Parking.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using Parking.Common;
using Parking.Common.Model;
using System.Data.SqlClient;

namespace Parking.Database.CommandFactory
{
    public class ParkingDatabaseFactory : IParkingDatabaseFactory
    {
        private readonly ISqlDataAccess sqlDataAccess;
        private readonly Dictionary<string, string> queries = new Dictionary<string, string>();
        private const string MasterId = "4D587294-4DC1-421A-8FB5-D5DE9FB0ED4A";

        public ParkingDatabaseFactory()
        {
            sqlDataAccess = new SqlDataAccess();
            queries.Add("SelectMasterSettings", @"SELECT  [CompanyName],
                                                          [ParkingPlaceCode],
                                                          [ParkingPlaceName],
                                                          [TwoWheelerParkingRatePerHour],
                                                          [FourWheelerParkingRatePerHour],
                                                          [LostTicketPenality]
                                                FROM [tbl_master] 
                                                WHERE [Id] = '{0}'");

            queries.Add("UpdateMasterSettings", @"  UPDATE [tbl_master]
                                                    SET [CompanyName] = '{0}', 
                                                        [ParkingPlaceCode] = '{1}', 
                                                        [ParkingPlaceName] = '{2}', 
                                                        [TwoWheelerParkingRatePerHour] = '{3}', 
                                                        [FourWheelerParkingRatePerHour] = '{4}', 
                                                        [LostTicketPenality] = '{5}', 
                                                    WHERE [Id] = '{6}'");

            queries.Add("InsertVehicleEntry", @"INSERT INTO [tbl_parking]
                                                            ([TDClientDeviceId],
                                                             [TicketNumber],
                                                             [ValidationNumber],
                                                             [QRCode],
                                                             [VehicleNumber],
                                                             [VehicleType],
                                                             [EntryTime],
                                                             [DriverImage],
                                                             [VehicleImage],
                                                             [IsParkingEntryDetailsUploadedToServer],
                                                             [IsParkingExitDetailsUploadedToServer])
                                                            
                                                              
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}' as Image,'{8}','{9}','{10}')");

            queries.Add("GetVehicleEntry", @"Select * from [tbl_parking] where [VehicleNumber] = '{0}'");



            queries.Add("GetUniqueCode", @"select cast((Abs(Checksum(NewId()))%10) as varchar(1)) +  char(ascii('a') + (Abs(Checksum(NewId()))%25)) + 
                                                char(ascii('A')+(Abs(Checksum(NewId()))%25)) + left(newid(),5) as UniqueCode");

            //MPS QUERIES
            queries.Add("InsertLostTicket", @"INSERT INTO [tbl_lost_ticket]                                                             
                                                             ([ParkingId],
                                                             [Name],
                                                             [VehicleNumber],
                                                             [DocumentType],
                                                             [DocumentNumber],
                                                             [DocumentImage])
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')");

            queries.Add("InsertMPSDeviceShift", @"INSERT INTO [tbl_MPSDeviceShift]
                                                             ([DeviceId],
                                                             [UserId],
                                                             [InDateTime]) output INSERTED.Id
                                                VALUES ('{0}','{1}','{2}')");
            queries.Add("GetShiftData", @"select count(*) as RecordCount, (sum([ParkingCharge]) + sum(PenalityCharge)) as TotalCollection from [tbl_parking]
                                                where ExitTime is not null and  ParkingCharge is not null  and ExitTime > '{0}'");

            queries.Add("UpdateMPSDeviceShift", @"UPDATE [tbl_MPSDeviceShift] SET [OutDateTime] = '{0}' 
                                               WHERE [Id] = CAST('{1}' AS UNIQUEIDENTIFIER)");

        }

        public void UpdateMasterSettings(string companyName,
            string parkingPlaceCode,
            string parkingPlaceName,
            string twoWheelerParkingRatePerHour,
            string fourWheelerParkingRatePerHour,
            string lostTicketPenality)
        {
            try
            {
                var query = string.Format(queries["UpdateMasterSettings"], companyName, parkingPlaceCode, parkingPlaceName,
                                          twoWheelerParkingRatePerHour, fourWheelerParkingRatePerHour, lostTicketPenality, MasterId);
                sqlDataAccess.ExecuteNonQuery(query);

            }
            catch (Exception exception)
            {
                FileLogger.Log($"TDClient Master settings could not be updated successfully to database as : {exception.Message}");
                throw;
            }
        }

        public DataRow GetMasterSettings()
        {
            try
            {
                var query = string.Format(queries["SelectMasterSettings"], MasterId);

                var sqlCommand = sqlDataAccess.GetCommand(query);

                var result = sqlDataAccess.Execute(sqlCommand);

                return result.Rows[0];
            }
            catch (Exception exception)
            {
                FileLogger.Log($"TDClient Master settings could not be loaded successfully from database as : {exception.Message}");
                throw;
            }

        }

        public void SaveVehicleEntry(string deviceId, Ticket ticket)
        {
            try
            {
                var insertQuery = string.Format(queries["InsertVehicleEntry"], deviceId,
                    ticket.TicketNumber, ticket.ValidationNumber, ticket.QRCode, ticket.VehicleNumber, (int)ticket.VehicleType, ticket.EntryTime, ticket.DriverImage, ticket.VehicleImage, 0, 0);
                sqlDataAccess.ExecuteNonQuery(insertQuery);
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Ticket Information Could not be saved in database as : {exception.Message}");
                throw;
            }
        }

        public string GetUniqueCode()
        {
            var sqlCommand = sqlDataAccess.GetCommand(queries["GetUniqueCode"]);
            var dataRow = sqlDataAccess.Execute(sqlCommand).Rows[0];
            return dataRow[0].ToString();
        }

        public DataTable GetVehicleEntry(string vehicleNumber)
        {
            try
            {
                var getQuery = string.Format(queries["GetVehicleEntry"], vehicleNumber);
                var sqlCommand = sqlDataAccess.GetCommand(getQuery);

                var result = sqlDataAccess.Execute(sqlCommand);
                return result;
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Vehicle's parking information could not be find in database as : {exception.Message}");
                throw;
            }
        }

        public void SaveLostTicketInfo(string parkingId, string name, string vehicleNumber, byte documentType, string documentNumber)
        {
            try
            {
                var insertQuery = string.Format(queries["InsertLostTicket"], parkingId, name,
                    vehicleNumber, documentType, documentNumber, null);
                sqlDataAccess.ExecuteNonQuery(insertQuery);
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Lost Ticket Information Could not be saved in database as : {exception.Message}");
                throw;
            }
        }

        public DataTable GetPendingVehicles()
        {
            try
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "spGetPendingVehicles";
                var result = sqlDataAccess.ExecuteDataReturningStoredProcedure(cmd);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Tuple<int, int> GetShiftCollection(string entryTime)
        {
            try
            {
                var getQuery = string.Format(queries["GetShiftData"], entryTime);
                var result = sqlDataAccess.Execute(getQuery);
                int count = 0;
                int collection = 0;
                if (result.Rows.Count > 0)
                {

                    count = (int)result.Rows[0]["RecordCount"];
                    collection = (object)result.Rows[0]["TotalCollection"] == DBNull.Value ? 0 : Convert.ToInt32(result.Rows[0]["TotalCollection"]);

                }
                return Tuple.Create(count, collection);
            }
            catch (Exception exception)
            {
                FileLogger.Log($"Shift collection could not be retrieved from database as : {exception.Message}");
                throw;
            }
        }

    }
}