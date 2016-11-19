using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace appForce.Framework.Connection
{
    class ManagerConn
    {
        SQLiteConnection conn = new SQLiteConnection("db");

        public SQLiteConnection getConn()
        {
            return conn;
        }
    }
}
