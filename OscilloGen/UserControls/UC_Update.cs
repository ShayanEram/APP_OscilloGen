using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OscilloGen.Src;

namespace OscilloGen.UserControls;

public partial class UC_Update : UserControl
{
    private FirmwareUpdate firmwareData;

    private struct FirmwareUpdate
    {
        public bool firmwareFileOk;
        public string firmwarePath;

        public FirmwareUpdate(bool fileOk, string path)
        {
            firmwareFileOk = fileOk;
            firmwarePath = path;
        }
    }

    public UC_Update()
    {
        InitializeComponent();
    }

    private void FwFileButton_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Binary & Hex Files (*.bin;*.hex)|*.bin;*.hex|All Files (*.*)|*.*";
        openFileDialog.Title = "Select Firmware File";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            firmwareData = new FirmwareUpdate(true, openFileDialog.FileName);
            FwFileTextBox.Text = firmwareData.firmwarePath;
        }
        else
        {
            firmwareData = new FirmwareUpdate(false, "");
        }
    }

    private void FwVersionButton_Click(object sender, EventArgs e)
    {
        if (firmwareData.firmwareFileOk)
        {
            string password = Microsoft.VisualBasic.Interaction.InputBox("Enter Password:", "Password Required", "", -1, -1);
            if (UpdateFw.CheckPassword(password))
            {
                MessageBox.Show("Access Granted.");

                if (UpdateFw.ReadBinaryFile(firmwareData.firmwarePath))
                {
                    MessageBox.Show("Firmware Upgrade Successful");
                }
                else
                {
                    MessageBox.Show("Firmware Upgrade Failed");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password. Access Denied.");
            }
        }
        else
        {
            MessageBox.Show("Please select a firmware file.");
        }
    }
}