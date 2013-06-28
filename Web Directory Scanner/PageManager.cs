using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Directory_Scanner
{
    public class PageManager
    {
        public SplitContainer Container { get; set; }

        public PageManager(SplitContainer container, UserControl primaryPage)
        {
            Container = container;
            //Container.Panel2.Controls.Add(primaryPage);
        }

        public void ChangePage(UserControl newPage)
        {
            Container.Panel2.Controls[0].Visible = false;

            //Remove all but the primaryPage (first page)
            for (int i = Container.Panel2.Controls.Count - 1; i > 1; i--)
                Container.Panel2.Controls.RemoveAt(i);

            newPage.Dock = DockStyle.Fill;
            Container.Panel2.Controls.Add(newPage);
        }

        public void ShowWelcomePage()
        {
            //Remove all but the primaryPage (first page)
            for (int i = Container.Panel2.Controls.Count - 1; i > 1; i--)
                Container.Panel2.Controls.RemoveAt(i);

            Container.Panel2.Controls[0].Visible = true;
        }
    }
}
