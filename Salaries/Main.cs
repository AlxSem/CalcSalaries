using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salaries
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void WMControlButton_Click(object sender, EventArgs e) //Открытие окна Управление рабочими
        {
            WMControl f = new WMControl();
            f.SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
            f.Show();
        }

        private void WControlButton_Click(object sender, EventArgs e)
        {
            WMControl f = new WMControl();
            f.SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
            f.Show();
        }
    }
}
