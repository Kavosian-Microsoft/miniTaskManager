using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
namespace miniTaskManager
{
    public partial class frmTaskManger : Form
    {
        [DllImport("powrorof.dll")]
        public static extern Int32 SetSuspendState(Int32 HiberNate, Int32 Foce, Int32 Disable);
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEX(int uFlags, int dwReason);
        [DllImport("user32.dll")]
        public static extern void LockWorkStation();

        public frmTaskManger()
        {
            InitializeComponent();
        }//frmTaskManger
        //-----------------------------------------------------------------------------------------
        private void frmTaskManger_Load(object sender, EventArgs e)
        {

        }//frmTaskManger_Load
        //-----------------------------------------------------------------------------------------
        private void turnOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "-s -t 00");
        }//turnOffToolStripMenuItem_Click
        //-----------------------------------------------------------------------------------------
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "-r -t 00");
        }//restartToolStripMenuItem_Click
        //-----------------------------------------------------------------------------------------
        private void standByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }//standByToolStripMenuItem_Click
        //-----------------------------------------------------------------------------------------
        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitWindowsEX(4, 0);
        }//logOffToolStripMenuItem_Click
        //-----------------------------------------------------------------------------------------
        private void hibernateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }//hibernateToolStripMenuItem_Click
        //-----------------------------------------------------------------------------------------
        private void tmrTaskMgr_Tick(object sender, EventArgs e)
        {
            Load_Task_List();
        }//tmrTaskMgr_Tick

        private void Load_Task_List()
        {
            Process[] allp = Process.GetProcesses();
            if (lstTasks.Items.Count != allp.Length)
            {
                lstTasks.Items.Clear();
                foreach (Process p in allp)
                {
                    lstTasks.Items.Add(p.ProcessName);
                }//foreach
                 // lstTasks.SetSelected(0, true);
                label1.Text = "Running processes count=" + lstTasks.Items.Count.ToString();
            }//if
        }//Load_Task_List

        //-----------------------------------------------------------------------------------------
        private void exitTaskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }//exitTaskManagerToolStripMenuItem_Click
        //-----------------------------------------------------------------------------------------
        private void btnEndProcess_Click(object sender, EventArgs e)
        {
            string strMesage = "";
            string strTitle = "Mini Task Manager";
            try
            {
                Process[] allp = Process.GetProcesses();
                foreach (var p in allp)
                {
                    if (lstTasks.SelectedItem.ToString().ToLower() == p.ProcessName.ToLower())
                    {
                        strMesage = string.Format("Do you want to end the {0} application", p.ProcessName);
                        DialogResult res = MessageBox.Show(strMesage, strTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res == DialogResult.Yes)
                        {
                            p.Kill();
                        }//if Yes is clicked
                    }//if
                }//foreach
            }//try
            catch (Exception ex)
            {
                strMesage = string.Format("Exception No 1. has occured , please try again or inform system administrator \n {0}", ex.Message);
                MessageBox.Show(strMesage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//catch
        }//btnEndProcess_Click
        //-----------------------------------------------------------------------------------------
        private void endTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }//endTaskToolStripMenuItem_Click
        //-----------------------------------------------------------------------------------------
        private void lstTasks_Click(object sender, EventArgs e)
        {
            string strTitle = "Mini Task Manager";
            string strMessage = "";
            ToolTip listB = new ToolTip();
            listB.ToolTipTitle = "Information of selected process";
            listB.ToolTipIcon = ToolTipIcon.Info;
            listB.AutomaticDelay = 50;
            listB.AutoPopDelay = 15000;
            listB.UseAnimation = true;
            

            try
            {
                Process[] allp = Process.GetProcesses();
                foreach (Process p in allp)
                {

                    FileInfo a = new FileInfo(p.MainModule.FileName);
                    string len = null;
                    len = a.Length.ToString() + "Bytes";                    
                    strMessage += "Process name:" + p.ProcessName;
                    strMessage += "\n";
                    strMessage += "Machine Name:" + p.MachineName;
                    strMessage += "\n";
                    strMessage += "Memory Usage:" + p.WorkingSet64.ToString() + "KB";
                    strMessage += "\n";
                    strMessage += "Process ID:" + p.Id.ToString();
                    strMessage += "\n";
                    strMessage += "Address:" + p.MainModule.FileName;
                    strMessage += "\n";
                    strMessage += "File Name:" + p.MainModule.FileVersionInfo.OriginalFilename;
                    strMessage += "\n";
                    strMessage += "File Version:" + p.MainModule.FileVersionInfo.FileVersion;
                    strMessage += "\n";
                    strMessage += "File Size:" + p.MainModule.FileName;
                    strMessage += "\n";
                    strMessage += "User Name:" + Environment.UserDomainName.ToString() + "\\" + Environment.UserName;
                    strMessage += "\n";
                    strMessage += "Computer Name:" + Environment.MachineName;                    
                    strMessage += "\n";
                    strMessage += "Creation Time:" + a.CreationTime.ToLongTimeString();
                    listB.SetToolTip(lstTasks, strMessage);
                }//foreeach
            }//try
            catch (Exception ex)
            {
                strMessage = string.Format("Exception No 2. has occured , please try again or inform system administrator \n {0}", ex.Message);
                MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }//catch

        }//lstTasks_Click

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstTasks_Click(this, e);
        }//propertiesToolStripMenuItem_Click

        private void propertiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process[] allp = Process.GetProcesses();
            string strMessage = "";
            string strTitle = "Task manager program";
            foreach (Process p in allp)
            {

                if (p.ProcessName.ToLower() == lstTasks.SelectedItem.ToString().ToLower())
                {
                    try
                    {
                        FileInfo a = new FileInfo(p.MainModule.FileName);
                        string len = null;
                        if (a.Length / 1073741824 > 0)
                        {
                            len = string.Format("{0:n2}", (double)a.Length / 1073741824 + " GB");
                        }//if 
                        else if (a.Length / 1048576 > 0)
                        {
                            len = string.Format("{0:n2}", (double)a.Length / 1048576 + " MB");
                        }//else if
                        else if (a.Length / 1024 > 0)
                        {
                            len = string.Format("{0:n2}", (double)a.Length / 1024 + " KB");
                        }//else if
                        else
                        {
                            len = a.Length + "Byte";
                        }//else

                        strMessage = "Process Name:" + p.ProcessName + "\nMem Usage:" + p.WorkingSet64 / 1024;
                        strMessage += " K" + "\nProcess id:" + p.Id + "\nAddress :" + p.MainModule.FileName + "\nFile Name:";
                        strMessage += p.MainModule.FileVersionInfo.OriginalFilename;
                        strMessage += "\nFile Version:" + p.MainModule.FileVersionInfo.FileVersion;
                        strMessage += "\nFile Size:" + len;
                        strMessage += "\nCreation Time:" + a.CreationTime;
                        strMessage += "\nUser Name:" + Environment.UserName;
                        strMessage += "\nComputer Name:" + Environment.MachineName;

                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }//try
                    catch (Exception ex)
                    {
                        strMessage = string.Format("Exception No 3. has occured , please try again or inform system administrator \n {0}", ex.Message);
                        MessageBox.Show(strMessage, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }//catch
                }//if
            }//foreach
        }//propertiesToolStripMenuItem1_Click

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Task_List();
        }//btnRefresh_Click

        //-----------------------------------------------------------------------------------------
    }//public partial class frmTaskManger : Form
}//miniTaskManager
