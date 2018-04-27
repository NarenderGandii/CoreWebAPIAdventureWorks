using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CoreWebAPIAdventure.Repository.Interfaces {
    public interface ISqlDBContext {
        SqlDataReader DataReader(string connString, CommandType commandType, string commandText);
    }
}
