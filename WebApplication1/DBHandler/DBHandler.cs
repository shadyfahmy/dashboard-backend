using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WebApplication1
{
    public class DBHandler
    {
        DBManager dbMan;

        public DBHandler()
        {
            dbMan = new DBManager();
        }
     
        public DataTable GetTest(long id)
        {
            string query = "select ResponseOID from BoloPersons where OID = " + id;
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetTest1()
        {
            string query = "SELECT Responses.Type,COUNT(Responses.OID) as 'Number' FROM dbo.Responses group by Responses.Type " ;
            return dbMan.ExecuteReader(query);
        }
    }
}