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


    }
}
