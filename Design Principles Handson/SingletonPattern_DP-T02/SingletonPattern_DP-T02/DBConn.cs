using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern_DP_T02
{
    public sealed class DBConn
    {
        private static DBConn instance;
        private DBConn()
        {
          
        }
        public static DBConn getInstance()
        {
            if (instance == null)
            {
                instance = new DBConn();
            }
            return instance;
        }
    }
}
