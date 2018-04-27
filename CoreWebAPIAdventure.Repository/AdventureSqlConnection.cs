using CoreWebAPIAdventure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CoreWebAPIAdventure.Repository
{
    public class AdventureSqlConnection: IAdventureSqlConnection {
        public SqlConnection GetSqlConnection() {
            return new SqlConnection("Server=localhost;Database=AdventureWorks2014;Trusted_Connection=True;");
        }
    }
}
