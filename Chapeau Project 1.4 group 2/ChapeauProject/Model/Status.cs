using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Status
    {
        placed,
        BeingPrepared,
        ready,
        served,
        running,
        finished

            //So when order is ready, I need to enable button mark as served and then in goes to served. 
            //if order status finished you can free the table, if running order is there you can not free the table
            //paying you can not pay if ther is no running order
    }
}
