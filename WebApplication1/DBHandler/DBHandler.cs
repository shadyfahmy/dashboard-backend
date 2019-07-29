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
            string query = "SELECT Responses.Type,COUNT(Responses.OID) as 'Number' FROM dbo.Responses group by Responses.Type ";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetCairo(string mStart, string mEnd)
        {
            string query = "SELECT Responses.Type,COUNT(Responses.OID) as 'Number'  FROM dbo.Responses where    CONVERT (nvarchar(10),dbo.Responses.CreationTime ,120)  >= '" + mStart +
                "'AND CONVERT(nvarchar(10),dbo.Responses.CreationTime  ,120)  < = '" + mEnd +
                "'  AND   (Responses.DispatchGroup LIKE '%CA%'OR Responses.DispatchGroup LIKE '%شمال القاهرة%' ) group by Responses.Type ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetGiza()
        {
            string query = "SELECT Responses.Type,COUNT(Responses.OID) as 'Number'  FROM dbo.Responses where Responses.DispatchGroup LIKE '%GIZA%'  or Responses.DispatchGroup LIKE '%GZ%' group by Responses.Type ";

            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAlex()
        {
            string query = "SELECT Responses.Type,COUNT(Responses.OID) as 'Number'  FROM dbo.Responses where Responses.DispatchGroup LIKE '%ALX%' group by Responses.Type ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetMatrouh()
        {
            string query = "SELECT Responses.Type,COUNT(Responses.OID) as 'Number'  FROM dbo.Responses where Responses.DispatchGroup LIKE '%MAT%' group by Responses.Type ";

            return dbMan.ExecuteReader(query);
        }

    }
}



