using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Salaries
{
    public partial class Main : Form
    {
        Core Core = new Core();
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

        private void WControlButton_Click(object sender, EventArgs e)//Открытие окна Управление работами
        {
            WMControl f = new WMControl();
            f.SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
            f.Show();
        }

        private void Main_Load(object sender, EventArgs e)//Проверка на существование файла workmans и tasks
        {
            
            
            
            
            if (Directory.Exists("Workmans"))
            {
                if (!(File.Exists(Core.fileWorkmans())))//Если файл не существует создать его
                {
                    Core.WorkmensFunc();
                }
            }
            else
            {
                Directory.CreateDirectory("Workmans");
                if (!(File.Exists(Core.fileWorkmans())))//Если файл не существует создать его
                {
                    Core.WorkmensFunc();
                }
            }
            if (Directory.Exists("Tasks"))
            {
                if (!(File.Exists(Core.fileTasks())))//Если файл не существует создать его
                {
                    Core.TasksFunc();
                }
            }
            else
            {
                Directory.CreateDirectory("Tasks");
                if (!(File.Exists(Core.fileTasks())))//Если файл не существует создать его
                {
                    Core.TasksFunc();
                }
            }
            if (Directory.Exists("Reports"))
            {
                if (!(File.Exists(Core.fileReport())))//Если файл не существует создать его
                {
                    Core.ReportsFunc();
                }
            }
            else
            {
                Directory.CreateDirectory("Reports");
                if (!(File.Exists(Core.fileReport())))//Если файл не существует создать его
                {
                    Core.ReportsFunc();
                }
            }

            if (Directory.Exists("Propites"))
            {
                if (!(File.Exists(Core.filePropites())))//Если файл не существует создать его
                {
                    Core.SettingFunc();
                }
            }
            else
            {
                Directory.CreateDirectory("Propites");
                if (!(File.Exists(Core.filePropites())))//Если файл не существует создать его
                {
                    Core.SettingFunc();
                }
            }
        }

        
    }
    
}
