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
using aejw.Network;
using Microsoft.VisualBasic;
using System.IO;

namespace Logistics
{
    public partial class MainPanel : Form
    {
        // Initialize _global_ variables
        string defaultLogDir = @"C:\Logistics"; 

        public MainPanel()
        {
            InitializeComponent();        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Logistics 0.1 Alpha. Please expect bugs.");

            // Initialize log directory
            localLogDirTBox.Text = defaultLogDir;
        }        

        #region Buttons
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectLocalLogFolderBT_Click(object sender, EventArgs e)
        {
            // Pop the folder selector and
            // make sure we select the path that the user selected and clicked OK
            if (localLogBrowser.ShowDialog() == DialogResult.OK)
                localLogDirTBox.Text = localLogBrowser.SelectedPath.ToString();

            // Set the new default
            defaultLogDir = localLogDirTBox.ToString();
        }
        #endregion Buttons

        #region Begin
        private void logPull_Click(object sender, EventArgs e)
        {
            // Initialize variables for network mapping
            string customerServer = customerServerCBox.SelectedItem.ToString();
            string logsDate = logsDatePicker.Value.ToString("yyyy-MM-dd");
            string destDir = defaultLogDir.ToString() + @"\" + logsDate;
            MessageBox.Show(destDir);
            
            // Execute network drive mapping
            mapDrive(customerServer, logsDate);

            // DEBUG 
            MessageBox.Show("Map complete?");

            // Initialize Copier
            xDirectory Copier = new xDirectory();
            Copier.ItemCopied += new ItemCopiedEventHandler(Copier_ItemCopied);
            Copier.CopyComplete += new CopyCompleteEventHandler(Copier_CopyComplete);
            Copier.CopyError += new CopyErrorEventHandler(Copier_CopyError);

            // Execute file transfer
            Copier.Source = new DirectoryInfo("Z:\\");
            Copier.Destination = new DirectoryInfo(destDir);
            Copier.Overwrite = false;
            Copier.FolderFilter = "*";
            Copier.FileFilters.Add("tsserver*");
            Copier.FileFilters.Add("sipengine.*");
            Copier.FileFilters.Add("sipengine_*");
            Copier.FileFilters.Add("notifier.*");
            Copier.FileFilters.Add("notifier_*");
            Copier.FileFilters.Add("ip.*");
            Copier.FileFilters.Add("ip_*");
            Copier.StartCopy();

            // DEBUG
            MessageBox.Show("Copying.....");

            // Initialize variables for upload to FTP

            
            // Execute FTP upload

            
            // Unmap all the drives
            unmapDrive();
        }       

        private void localLogDirTBox_TextChanged(object sender, EventArgs e)
        {
            defaultLogDir = localLogDirTBox.Text;
        }
        #endregion

        #region Methods
        public void mapDrive(string serverName, string date)
        {
            NetworkDrive logDrive = new aejw.Network.NetworkDrive();

            try
            {
                logDrive.LocalDrive = "Z:";
                logDrive.ShareName = "\\\\" + serverName + "\\Logs\\" + date;
                logDrive.PromptForCredentials = true;
                logDrive.MapDrive();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, "Something didn't go well: " + err.Message);
            }
            logDrive = null;
        }

        public void unmapDrive()
        {
            NetworkDrive logDrive = new aejw.Network.NetworkDrive();

            try{
                logDrive.LocalDrive = "Z:";
                logDrive.UnMapDrive();
            }catch (Exception err){
                MessageBox.Show(this, "Something didn't go well: " + err.Message);
            }
        }

        private void Copier_ItemCopied(object sender, ItemCopiedEventArgs e)
        {
            MessageBox.Show(e.Source + " was copied successfully to " + e.Destination);
        }

        private void Copier_CopyComplete(object sender, CopyCompleteEventArgs e)
        {
            MessageBox.Show("Copying complete!");
        }

        private void Copier_CopyError(object sender, CopyErrorEventArgs e)
        {
            MessageBox.Show("There was an error with copying " + sender.ToString() + " with the error: " + e.ToString());
        }
        #endregion
    }
}

