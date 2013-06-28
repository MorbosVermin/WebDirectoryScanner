using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Directory_Scanner
{
    public class ClickHandler
    {

        public class ClickEventArgs : EventArgs
        {

            public string Name { get; set; }

            public ClickEventArgs(string Name)  
            {
                this.Name = Name;
            }

        }

        public static event EventHandler<ClickEventArgs> Click;

        public ClickHandler()
        {

        }

        public static void HandleClick(object sender, ClickEventArgs e)  
        {
            EventHandler<ClickEventArgs> handler = Click;
            if (handler != null)
            {
                handler(sender, e);
            }
        }
    }
}
