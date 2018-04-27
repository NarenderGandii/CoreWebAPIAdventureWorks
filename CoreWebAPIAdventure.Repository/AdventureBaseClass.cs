using CoreWebAPIAdventure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using CoreWebAPIAdventure.DataModel;
using Microsoft.Extensions.Options;

namespace CoreWebAPIAdventure.Repository {
    public abstract class AdventureBaseClass  {
        public SqlConnection GetSqlConnection() {
            return new SqlConnection("Server=localhost;Database=AdventureWorks2014;Trusted_Connection=True;");
        }
    }
}
