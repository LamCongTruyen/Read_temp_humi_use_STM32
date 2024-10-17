using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace STM32Serial
{
    public partial class Form1 : Form
    {
        string bufferDataTransfer;
        string bufferDataReceiver;
        string sendWith;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string [] portNumber = SerialPort.GetPortNames();
            serialPortNum.Items.AddRange(portNumber);

            btnSendData.Enabled = false;
            cBoxWriteLine.Checked = false;
            cBoxWrite.Checked = true;
            sendWith = "Write";

            chkBoxAddToOldData.Checked = true;  
            chkBoxAlwaysUpdate.Checked = false;

            chartTemp.Series.Clear();
            Series series = new Series("Temperature");
            series.ChartType = SeriesChartType.Line;
            chartTemp.Series.Add(series);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void bntOpen_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.PortName = serialPortNum.Text;
                serialPort1.BaudRate = Convert.ToInt32(serialBaurate.Text);
                serialPort1.DataBits = Convert.ToInt32(serialDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), serialStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), serialParityBits.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception ret) {
                MessageBox.Show(ret.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) { 
                bufferDataTransfer = dataOutput.Text;


                if (sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(bufferDataTransfer);
                }
                else if (sendWith == "Write")
                {
                    serialPort1.Write(bufferDataTransfer);
                }
                else { 
                 /* do somethings */
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnClearDataSend_Click(object sender, EventArgs e)
        {
            if (dataOutput.Text != "") {
                dataOutput.Text = "";
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
        }

        private void boxDataSend(object sender, EventArgs e)
        {
            //int lengthDataSend = dataOutput.TextLength;
            //lbLengthDataReceived.Text = string.Format("{0:00}", lengthDataSend);
            if (chkBoxUseEnterForSend.Checked) {
                dataOutput.Text = dataOutput.Text.Replace(Environment.NewLine, "");    
            }
        }

        private void cBoxCheckButtonForSend(object sender, EventArgs e)
        {
            if (cBoxButtonForSend.Checked)
            {
                btnSendData.Enabled = true;
            }
            else { 
                btnSendData.Enabled = false;
            }
        }

        private void dataOutput_KeyDown(object sender, KeyEventArgs e)
        {
            if (chkBoxUseEnterForSend.Checked) {
                if (e.KeyCode == Keys.Enter) {
                    if (serialPort1.IsOpen)
                    {
                        bufferDataTransfer = dataOutput.Text;
                        if (sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(bufferDataTransfer);
                        }
                        else if (sendWith == "Write")
                        {
                            serialPort1.Write(bufferDataTransfer);
                        }
                        else
                        {
                            /* do somethings */
                        }
                    }
                }
            }
        }

        private void cBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxWrite.Checked)
            {
                sendWith = "Write";
                cBoxWrite.Checked = true;
                cBoxWriteLine.Checked = false;
            }
        }

        private void cBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                cBoxWrite.Checked = false;
                cBoxWriteLine.Checked = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            bufferDataReceiver = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
            this.Invoke((MethodInvoker)delegate {
                TimerRandom_Tick(sender, e);
            });
        }

        private void ShowData(object sender, EventArgs e)
        {
            int length = bufferDataReceiver.Length;
            lbLengthDataReceived.Text = string.Format("{0:00}", length);
            if (chkBoxAlwaysUpdate.Checked)
            {
                tBoxDataReceived.Text = bufferDataReceiver;
            }
            else if (chkBoxAddToOldData.Checked)
            {   
                tBoxDataReceived.Text += bufferDataReceiver;
            }
            else { 
                /* do somethings  */
            }
        }

        private void chkBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAlwaysUpdate.Checked)
            {
                chkBoxAlwaysUpdate.Checked = true;
                chkBoxAddToOldData.Checked = false;
            }
            else {
                chkBoxAddToOldData.Checked = true;
            }
        }

        private void chkBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAddToOldData.Checked)
            {
                chkBoxAlwaysUpdate.Checked = false;
                chkBoxAddToOldData.Checked = true;
            }
            else {
                chkBoxAlwaysUpdate.Checked = true;
            }
        }

        private void btnClearDataReceived_Click(object sender, EventArgs e)
        {
            if (btnClearDataReceived.Text != "") {
                tBoxDataReceived.Text = "";
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
        }

        private void TimerRandom_Tick(object sender, EventArgs e)
        {
            int values = -1;
            if (!string.IsNullOrEmpty(bufferDataReceiver))
            {
                string cleanData = new string(bufferDataReceiver.Where(char.IsDigit).ToArray());
                if (cleanData.Length >= 2)
                {
                    string twoDigitString = cleanData.Substring(0, 2);
                    if (int.TryParse(twoDigitString, out values))
                    {
                        Console.WriteLine($"{values}");
                        chartTemp.Series["Temperature"].Points.AddY(values);
                    }
                }
            }
            if (values != -1)
            {
                chartTemp.Series["Temperature"].Points.AddY(values);
            }

        }

        private void btnControlOnRelay1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) {
                serialPort1.WriteLine("q");
                prgBarStatusRelay1.Value = 100;
            }
        }

        private void btnControlOffRelay1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("a");
                prgBarStatusRelay1.Value = 0;
                
            }
        }

        private void prgBarStatusRelay1_Click(object sender, EventArgs e)
        {

        }

        private void serialBaurate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("w");
                progressBar3.Value = 100;             
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("t");
                progressBar4.Value = 100;          
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("b");
                progressBar3.Value = 0;               
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("c");
                progressBar4.Value = 0;              
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("4");
                progressBar5.Value = 100;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("d");
                progressBar5.Value = 0;               
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("5");
                progressBar6.Value = 100;             
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("e");
                progressBar6.Value = 0;               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("6");
                progressBar7.Value = 100;             
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("f");
                progressBar7.Value = 0;             
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("7");
                progressBar8.Value = 100;               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("g");
                progressBar8.Value = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("8");
                progressBar9.Value = 100;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("h");
                progressBar9.Value = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("0");
                prgBarStatusRelay1.Value = 100;
                progressBar3.Value = 100;
                progressBar4.Value = 100;
                progressBar5.Value = 100;
                progressBar6.Value = 100;
                progressBar7.Value = 100;
                progressBar8.Value = 100;
                progressBar9.Value = 100;
                progressBar10.Value = 100;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("9");
                prgBarStatusRelay1.Value = 0;
                progressBar3.Value = 0;
                progressBar4.Value = 0;
                progressBar5.Value = 0;
                progressBar6.Value = 0;
                progressBar7.Value = 0;
                progressBar8.Value = 0;
                progressBar9.Value = 0;
                progressBar10.Value = 0;
            }
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void progressBar7_Click(object sender, EventArgs e)
        {

        }

        private void progressBar8_Click(object sender, EventArgs e)
        {

        }

        private void progressBar9_Click(object sender, EventArgs e)
        {

        }

        private void progressBar10_Click(object sender, EventArgs e)
        {

        }

        private void tBoxDataReceived_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
