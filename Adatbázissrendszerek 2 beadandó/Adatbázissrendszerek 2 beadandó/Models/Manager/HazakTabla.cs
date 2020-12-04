using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adatbázissrendszerek_2_beadandó.Models.Records;
using Oracle.ManagedDataAccess.Client;

namespace Adatbázissrendszerek_2_beadandó.Models.Manager
{
    class HazakTabla
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oracleconnection = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;
                                        User Id=qlidyo;
                                        Password=EKE2020;";
            oracleconnection.ConnectionString = connectionString;
            return oracleconnection;
        }

        public List<Haz> Select()
        {
            List<Haz> records = new List<Haz>();

            OracleConnection oracleconnection = new OracleConnection();
            oracleconnection.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT epitese, szobakszama, emelet, futes, varos, iszam, tipus, hszam FROM hazak"
            };

            command.Connection = oracleconnection;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Haz haz = new Haz
                {
                    Szobakszama = reader["szobakszama"].ToString(),
                    Emelet = reader["emelet"].ToString()
                };
                records.Add(haz);
            }
            oracleconnection.Close();

            return records;
        }

        public bool Checkiszam(string iszam)
        {
            OracleConnection oracleconnection = GetOracleConnection();
            oracleconnection.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_iszam"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };

            OracleParameter iszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_iszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = iszam

            };
            command.Parameters.Add(iszamParameter);

            command.Connection = oracleconnection;

            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
