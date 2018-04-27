using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CoreWebAPIAdventure.Repository.Interfaces {
    public interface IAdventureSqlConnection {
          SqlConnection GetSqlConnection();
    }
}
