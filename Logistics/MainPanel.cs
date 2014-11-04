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

namespace Logistics
{
    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Logistics 0.1 Alpha. Please expect bugs.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

#region Begin
        // Initialize _global_ variables
        String defaultLogDir = @"C:\Logistics";        

        private void logPull_Click(object sender, EventArgs e)
        {
            // Initialize variables for network mapping
            String customerServer = customerServerCBox.SelectedItem.ToString();
            String logsDate = logsDateTBox.Text;
            
            // Execute network drive mapping
            mapDrive(customerServer, logsDate);

            // DEBUG 
            MessageBox.Show("Map complete?");

            // Initialize variables for file transfer
            

            // Execute file transfer

            
            // Initialize variables for Filezilla upload to FTP

            
            // Execute Filezilla FTP upload


            // DEBUG
            MessageBox.Show("Copy complete?");

            // Unmap all the drives
            unmapDrive();
        }

        private void localLogDirTBox_TextChanged(object sender, EventArgs e)
        {
            defaultLogDir = localLogDirTBox.ToString();
        }

        private void logsDatePicker_ValueChanged(object sender, EventArgs e)
        {
            logsDateTBox.Text = logsDatePicker.Value.ToString("yyyy-MM-dd");
        }
#endregion

#region Methods
        public void mapDrive(String serverName, String date)
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
#endregion

    }
}

