using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STBaseSys
{
    class RealTimeDataStore : DataStore
    {

        public RealTimeDataStore() 
            : base(EDataStoreTag.ERealTimeData)
        {

        }
    }
}
