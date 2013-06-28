using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Directory_Scanner
{
    public class ScanHandler
    {

        public static event EventHandler<EventArgs> Started;
        public static event EventHandler<EventArgs> Completed;

        public static void StartedScan(object sender, EventArgs e)
        {
            EventHandler<EventArgs> handler = Started;
            if (handler != null)
                handler(sender, e);

        }

        public static void CompletedScan(object sender, EventArgs e)
        {
            EventHandler<EventArgs> handler = Completed;
            if (handler != null)
                handler(sender, e);

        }

    }
}
