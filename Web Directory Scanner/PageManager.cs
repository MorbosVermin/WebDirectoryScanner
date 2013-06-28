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
        public UserControl WelcomePage { get; set; }

        public PageManager(SplitContainer container, UserControl primaryPage)
        {
            Container = container;
            WelcomePage = primaryPage;
        }

        public void ChangePage(UserControl newPage)
        {
            for (int i = 0; i < Container.Panel2.Controls.Count; i++)
                Container.Panel2.Controls.RemoveAt(i);

            newPage.Dock = DockStyle.Fill;
            Container.Panel2.Controls.Add(newPage);
        }

        public void ShowWelcomePage()
        {
            for (int i = 0; i < Container.Panel2.Controls.Count; i++)
                Container.Panel2.Controls.RemoveAt(i);

            Container.Panel2.Controls.Add(WelcomePage);
        }
    }
}
