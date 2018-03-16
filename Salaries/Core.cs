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
    internal class Core
    {
        public void MessageInfo(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string fileWorkmans() //путь
        {
            return Environment.CurrentDirectory + "\\Workmans\\workmans.xml"; ;
        }
        public string fileTasks() //путь
        {
            return Environment.CurrentDirectory + "\\Tasks\\tasks.xml";
        }
        public string fileReport()
        {
            return Environment.CurrentDirectory + "\\Reports\\" + DateTime.Now.ToShortDateString() + ".xml";
        }
        public string filePropites() //путь
        {
            return Environment.CurrentDirectory + "\\Propites\\Settings.xml";
        }
        public void WorkmensFunc()
        {
            XDocument errorworkman;
            errorworkman = new XDocument(new XElement("Workers"));
            errorworkman.Save(fileWorkmans());
            MessageInfo("Файл рабочих создан! Заполните его");
        }
        public void TasksFunc()
        {
            XDocument errortasks;
            errortasks = new XDocument(new XElement("Tasks"));
            errortasks.Save(fileTasks());
            MessageInfo("Файл работ создан! Заполните его");
        }
        public void ReportsFunc()
        {
            XDocument errortables;
            errortables = new XDocument(new XElement("Reports"));
            errortables.Save(fileReport());
            MessageInfo("Зафиксированно начало нового дня!");
        }
        public void SettingFunc()
        {
            XDocument errorsetting;
            errorsetting = new XDocument(new XElement("Propites"));
            errorsetting.Save(filePropites());
            MessageInfo("Файл с настройками создан");
        }
        







    }
}
