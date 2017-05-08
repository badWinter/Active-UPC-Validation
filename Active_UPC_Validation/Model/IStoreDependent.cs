using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Active_UPC_Validation.Model
{
    interface IStoreDependent
    {
        void UpdateStore(int storeNumber);
    }
}
