using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_SUMMER19_LESSON13_Part3.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex<mainTabControl.TabPages.Count)
            {
                mainTabControl.SelectedIndex++;
            }
                
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mainTabControl.SelectedIndex!=0)
            {
                mainTabControl.SelectedIndex--;
            }
            
        }
    }
}
