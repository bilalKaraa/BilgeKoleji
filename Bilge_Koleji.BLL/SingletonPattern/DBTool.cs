using Bilge_Koleji.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Bilge_Koleji.BLL.SingletonPattern
{
    public class DBTool
    {
        public DBTool()
        {
        }

        static MyContext _dbinstance;
        public static MyContext DBInstance
        {
            get
            {
                if (_dbinstance==null)
                {
                    _dbinstance = new MyContext();
                }
                return _dbinstance;
            }
        }
    }
}
