using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Salaries
{
    public partial class WMControl : Form
    {
        Core Core = new Core();
        public WMControl()
        {
            InitializeComponent();
        }

        private void WMControl_Load(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load(Core.fileWorkmans());
            try
            {
                foreach (XElement el in doc.Element("Workers").Elements("Worker"))
                {
                    int n = WorkersTabl.Rows.Add();
                    WorkersTabl.Rows[n].Cells[0].Value = el.Element("Name").Value;
                    WorkersTabl.Rows[n].Cells[1].Value = el.Element("Post").Value;
                }
            }
            catch
            {
                return;
            }
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(NemeTextBox.Text == "")
            {
                Core.MessageError("Поле имени пустое");
                return;
            }
            string Name = NemeTextBox.Text;
            string Post = PostTextBox.Text;
            int UniqueID = Core.GetUniqueID();
            Core.SetUniqueID(UniqueID);
            MessageBox.Show(Convert.ToString(UniqueID));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }


    }
}
