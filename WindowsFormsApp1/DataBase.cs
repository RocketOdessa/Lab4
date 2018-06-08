using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorsDB
{
    class DataBase
    {
        List<Investor> db;

        public DataBase()
        {
            db = new List<Investor>();
        }

        internal List<Investor> Db { get => db;}

        public bool AddInvestor(Investor investor)
        {
            bool result = false;
            try
            {
                Db.Add(investor);
                result = true;
            }
            catch (Exception exc)
            {
                
            }

            return result;
        }

        public string toString()
        {
            string result = "";
            
            foreach (Investor item in Db)
            {
                result += item.toString() + '\n';
            }

            return result;
        }
    }
}
