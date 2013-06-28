using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Directory_Scanner
{
    public class RadioButtonManager
    {
        public RadioButton CurrentButton
        {
            get;
            set;
        }

        private List<RadioButton> Buttons;

        public RadioButtonManager() 
        {
            CurrentButton = null;
            Buttons = new List<RadioButton>();
        }

        public void AddButton(RadioButton button)
        {
            Buttons.Add(button);
            button.CheckedChanged += button_CheckedChanged;
            if (CurrentButton == null)
            {
                button.Checked = true;
                CurrentButton = button;
            }

        }

        void button_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (button != null)
            {
                if (button.Checked)
                {
                    CurrentButton = button;
                    /*
                    foreach (RadioButton b in Buttons)
                        if (!b.Equals(button))
                            b.Checked = false;
                    */
                }
            }

            Console.WriteLine("CurrentButton: {0}", CurrentButton.Name);
        }
    }
}
