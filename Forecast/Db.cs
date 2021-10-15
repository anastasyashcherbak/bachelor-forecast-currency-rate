using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using System.Data.Common;

namespace Forecast_Shcherbak
{
    class Db
    {
        private DbProviderFactory factory;
        private DbConnection connection;
        private DbCommand command;
        private DbDataAdapter adapter;
        public Db()
        {
            //currentUser = null;
            //isLogedIn = false;
            factory = DbProviderFactories.GetFactory("System.Data.OracleClient");
            connection = factory.CreateConnection();
            command = factory.CreateCommand();
            adapter = factory.CreateDataAdapter();
        }
       
    }
}
