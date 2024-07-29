using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_management_appication.Class
{
    class valiballecommon
    {
        private static readonly valiballecommon storage = new valiballecommon();


        public static valiballecommon GetStorage()
        {
            return storage;
        }
        public string UserName { get; set; }
        public string UserCode { get; set; }
        public int Permission { get; set; }
        public string DatabaseName { get; set; }

    }
}
