using CoreWebAPIAdventure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace CoreWebAPIAdventure.Repository
{
    public class SqlDBContext : ISqlDBContext {
        public SqlDataReader DataReader(string connString,CommandType commandType, string commandText) {
            return SqlHelper.ExecuteReader(connString, CommandType.Text, commandText);
        }
    }
}
