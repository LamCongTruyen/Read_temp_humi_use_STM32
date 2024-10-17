namespace STM32Serial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.bntOpen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialBaurate = new System.Windows.Forms.ComboBox();
            this.serialDataBits = new System.Windows.Forms.ComboBox();
            this.serialStopBits = new System.Windows.Forms.ComboBox();
            this.serialParityBits = new System.Windows.Forms.ComboBox();
            this.serialPortNum = new System.Windows.Forms.ComboBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBoxWrite = new System.Windows.Forms.CheckBox();
            this.cBoxWriteLine = new System.Windows.Forms.CheckBox();
            this.chkBoxUseEnterForSend = new System.Windows.Forms.CheckBox();
            this.cBoxButtonForSend = new System.Windows.Forms.CheckBox();
            this.btnClearDataSend = new System.Windows.Forms.Button();
            this.lbLengthDataReceived = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.chkBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.btnClearDataReceived = new System.Windows.Forms.Button();
            this.tBoxDataReceived = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.prgBarStatusRelay1 = new System.Windows.Forms.ProgressBar();
            this.btnControlOffRelay1 = new System.Windows.Forms.Button();
            this.btnControlOnRelay1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.bntOpen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.serialBaurate);
            this.groupBox1.Controls.Add(this.serialDataBits);
            this.groupBox1.Controls.Add(this.serialStopBits);
            this.groupBox1.Controls.Add(this.serialParityBits);
            this.groupBox1.Controls.Add(this.serialPortNum);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(254, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UART_LAMCONGTRUYEN_N21DCDT096";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(190, 93);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(56, 16);
            this.progressBar1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(190, 69);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 19);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bntOpen
            // 
            this.bntOpen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntOpen.Location = new System.Drawing.Point(190, 45);
            this.bntOpen.Margin = new System.Windows.Forms.Padding(2);
            this.bntOpen.Name = "bntOpen";
            this.bntOpen.Size = new System.Drawing.Size(56, 19);
            this.bntOpen.TabIndex = 0;
            this.bntOpen.Text = "OPEN";
            this.bntOpen.UseVisualStyleBackColor = false;
            this.bntOpen.Click += new System.EventHandler(this.bntOpen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAURATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serialBaurate
            // 
            this.serialBaurate.FormattingEnabled = true;
            this.serialBaurate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "115200"});
            this.serialBaurate.Location = new System.Drawing.Point(95, 69);
            this.serialBaurate.Margin = new System.Windows.Forms.Padding(2);
            this.serialBaurate.Name = "serialBaurate";
            this.serialBaurate.Size = new System.Drawing.Size(92, 21);
            this.serialBaurate.TabIndex = 4;
            this.serialBaurate.Text = "9600";
            this.serialBaurate.SelectedIndexChanged += new System.EventHandler(this.serialBaurate_SelectedIndexChanged);
            // 
            // serialDataBits
            // 
            this.serialDataBits.FormattingEnabled = true;
            this.serialDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.serialDataBits.Location = new System.Drawing.Point(95, 93);
            this.serialDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.serialDataBits.Name = "serialDataBits";
            this.serialDataBits.Size = new System.Drawing.Size(92, 21);
            this.serialDataBits.TabIndex = 3;
            this.serialDataBits.Text = "8";
            // 
            // serialStopBits
            // 
            this.serialStopBits.FormattingEnabled = true;
            this.serialStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.serialStopBits.Location = new System.Drawing.Point(95, 118);
            this.serialStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.serialStopBits.Name = "serialStopBits";
            this.serialStopBits.Size = new System.Drawing.Size(92, 21);
            this.serialStopBits.TabIndex = 2;
            this.serialStopBits.Text = "One";
            // 
            // serialParityBits
            // 
            this.serialParityBits.FormattingEnabled = true;
            this.serialParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.serialParityBits.Location = new System.Drawing.Point(95, 142);
            this.serialParityBits.Margin = new System.Windows.Forms.Padding(2);
            this.serialParityBits.Name = "serialParityBits";
            this.serialParityBits.Size = new System.Drawing.Size(92, 21);
            this.serialParityBits.TabIndex = 1;
            this.serialParityBits.Text = "None";
            // 
            // serialPortNum
            // 
            this.serialPortNum.FormattingEnabled = true;
            this.serialPortNum.Location = new System.Drawing.Point(95, 44);
            this.serialPortNum.Margin = new System.Windows.Forms.Padding(2);
            this.serialPortNum.Name = "serialPortNum";
            this.serialPortNum.Size = new System.Drawing.Size(92, 21);
            this.serialPortNum.TabIndex = 0;
            this.serialPortNum.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSendData.Location = new System.Drawing.Point(4, 17);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(77, 29);
            this.btnSendData.TabIndex = 3;
            this.btnSendData.Text = "SEND DATA";
            this.btnSendData.UseVisualStyleBackColor = false;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chartTemp
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemp.Legends.Add(legend1);
            this.chartTemp.Location = new System.Drawing.Point(22, 248);
            this.chartTemp.Margin = new System.Windows.Forms.Padding(2);
            this.chartTemp.Name = "chartTemp";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Size = new System.Drawing.Size(814, 232);
            this.chartTemp.TabIndex = 11;
            this.chartTemp.Text = "Temp";
            this.chartTemp.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataOutput
            // 
            this.dataOutput.Location = new System.Drawing.Point(4, 54);
            this.dataOutput.Margin = new System.Windows.Forms.Padding(2);
            this.dataOutput.Multiline = true;
            this.dataOutput.Name = "dataOutput";
            this.dataOutput.Size = new System.Drawing.Size(198, 35);
            this.dataOutput.TabIndex = 10;
            this.dataOutput.TextChanged += new System.EventHandler(this.boxDataSend);
            this.dataOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataOutput_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBoxWrite);
            this.groupBox2.Controls.Add(this.cBoxWriteLine);
            this.groupBox2.Controls.Add(this.chkBoxUseEnterForSend);
            this.groupBox2.Controls.Add(this.cBoxButtonForSend);
            this.groupBox2.Controls.Add(this.btnClearDataSend);
            this.groupBox2.Controls.Add(this.btnSendData);
            this.groupBox2.Controls.Add(this.dataOutput);
            this.groupBox2.Location = new System.Drawing.Point(280, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(266, 197);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transmiter";
            // 
            // cBoxWrite
            // 
            this.cBoxWrite.AutoSize = true;
            this.cBoxWrite.Location = new System.Drawing.Point(86, 124);
            this.cBoxWrite.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxWrite.Name = "cBoxWrite";
            this.cBoxWrite.Size = new System.Drawing.Size(51, 17);
            this.cBoxWrite.TabIndex = 17;
            this.cBoxWrite.Text = "Write";
            this.cBoxWrite.UseVisualStyleBackColor = true;
            this.cBoxWrite.CheckedChanged += new System.EventHandler(this.cBoxWrite_CheckedChanged);
            // 
            // cBoxWriteLine
            // 
            this.cBoxWriteLine.AutoSize = true;
            this.cBoxWriteLine.Location = new System.Drawing.Point(86, 102);
            this.cBoxWriteLine.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxWriteLine.Name = "cBoxWriteLine";
            this.cBoxWriteLine.Size = new System.Drawing.Size(71, 17);
            this.cBoxWriteLine.TabIndex = 16;
            this.cBoxWriteLine.Text = "WriteLine";
            this.cBoxWriteLine.UseVisualStyleBackColor = true;
            this.cBoxWriteLine.CheckedChanged += new System.EventHandler(this.cBoxWriteLine_CheckedChanged);
            // 
            // chkBoxUseEnterForSend
            // 
            this.chkBoxUseEnterForSend.AutoSize = true;
            this.chkBoxUseEnterForSend.Location = new System.Drawing.Point(4, 124);
            this.chkBoxUseEnterForSend.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxUseEnterForSend.Name = "chkBoxUseEnterForSend";
            this.chkBoxUseEnterForSend.Size = new System.Drawing.Size(81, 17);
            this.chkBoxUseEnterForSend.TabIndex = 15;
            this.chkBoxUseEnterForSend.Text = "Using Enter";
            this.chkBoxUseEnterForSend.UseVisualStyleBackColor = true;
            // 
            // cBoxButtonForSend
            // 
            this.cBoxButtonForSend.AutoSize = true;
            this.cBoxButtonForSend.Location = new System.Drawing.Point(4, 102);
            this.cBoxButtonForSend.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxButtonForSend.Name = "cBoxButtonForSend";
            this.cBoxButtonForSend.Size = new System.Drawing.Size(87, 17);
            this.cBoxButtonForSend.TabIndex = 14;
            this.cBoxButtonForSend.Text = "Using Button";
            this.cBoxButtonForSend.UseVisualStyleBackColor = true;
            this.cBoxButtonForSend.CheckedChanged += new System.EventHandler(this.cBoxCheckButtonForSend);
            // 
            // btnClearDataSend
            // 
            this.btnClearDataSend.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearDataSend.Location = new System.Drawing.Point(86, 17);
            this.btnClearDataSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearDataSend.Name = "btnClearDataSend";
            this.btnClearDataSend.Size = new System.Drawing.Size(64, 29);
            this.btnClearDataSend.TabIndex = 13;
            this.btnClearDataSend.Text = "CLEAR";
            this.btnClearDataSend.UseVisualStyleBackColor = false;
            this.btnClearDataSend.Click += new System.EventHandler(this.btnClearDataSend_Click);
            // 
            // lbLengthDataReceived
            // 
            this.lbLengthDataReceived.AutoSize = true;
            this.lbLengthDataReceived.Location = new System.Drawing.Point(206, 73);
            this.lbLengthDataReceived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLengthDataReceived.Name = "lbLengthDataReceived";
            this.lbLengthDataReceived.Size = new System.Drawing.Size(19, 13);
            this.lbLengthDataReceived.TabIndex = 20;
            this.lbLengthDataReceived.Text = "00";
            this.lbLengthDataReceived.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "LENGTH";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbLengthDataReceived);
            this.groupBox3.Controls.Add(this.chkBoxAddToOldData);
            this.groupBox3.Controls.Add(this.chkBoxAlwaysUpdate);
            this.groupBox3.Controls.Add(this.btnClearDataReceived);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tBoxDataReceived);
            this.groupBox3.Location = new System.Drawing.Point(551, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(266, 197);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receiver";
            // 
            // chkBoxAddToOldData
            // 
            this.chkBoxAddToOldData.AutoSize = true;
            this.chkBoxAddToOldData.Location = new System.Drawing.Point(4, 176);
            this.chkBoxAddToOldData.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxAddToOldData.Name = "chkBoxAddToOldData";
            this.chkBoxAddToOldData.Size = new System.Drawing.Size(106, 17);
            this.chkBoxAddToOldData.TabIndex = 15;
            this.chkBoxAddToOldData.Text = "Add To Old Data";
            this.chkBoxAddToOldData.UseVisualStyleBackColor = true;
            this.chkBoxAddToOldData.CheckedChanged += new System.EventHandler(this.chkBoxAddToOldData_CheckedChanged);
            // 
            // chkBoxAlwaysUpdate
            // 
            this.chkBoxAlwaysUpdate.AutoSize = true;
            this.chkBoxAlwaysUpdate.Location = new System.Drawing.Point(4, 155);
            this.chkBoxAlwaysUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.chkBoxAlwaysUpdate.Name = "chkBoxAlwaysUpdate";
            this.chkBoxAlwaysUpdate.Size = new System.Drawing.Size(97, 17);
            this.chkBoxAlwaysUpdate.TabIndex = 14;
            this.chkBoxAlwaysUpdate.Text = "Always Update";
            this.chkBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chkBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chkBoxAlwaysUpdate_CheckedChanged);
            // 
            // btnClearDataReceived
            // 
            this.btnClearDataReceived.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearDataReceived.Location = new System.Drawing.Point(4, 17);
            this.btnClearDataReceived.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearDataReceived.Name = "btnClearDataReceived";
            this.btnClearDataReceived.Size = new System.Drawing.Size(64, 29);
            this.btnClearDataReceived.TabIndex = 13;
            this.btnClearDataReceived.Text = "CLEAR";
            this.btnClearDataReceived.UseVisualStyleBackColor = false;
            this.btnClearDataReceived.Click += new System.EventHandler(this.btnClearDataReceived_Click);
            // 
            // tBoxDataReceived
            // 
            this.tBoxDataReceived.Location = new System.Drawing.Point(4, 54);
            this.tBoxDataReceived.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxDataReceived.MaxLength = 108;
            this.tBoxDataReceived.Multiline = true;
            this.tBoxDataReceived.Name = "tBoxDataReceived";
            this.tBoxDataReceived.Size = new System.Drawing.Size(198, 97);
            this.tBoxDataReceived.TabIndex = 10;
            this.tBoxDataReceived.TextChanged += new System.EventHandler(this.tBoxDataReceived_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.statusStrip1);
            this.groupBox4.Controls.Add(this.progressBar10);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button12);
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Controls.Add(this.button9);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.progressBar9);
            this.groupBox4.Controls.Add(this.progressBar8);
            this.groupBox4.Controls.Add(this.progressBar7);
            this.groupBox4.Controls.Add(this.progressBar6);
            this.groupBox4.Controls.Add(this.progressBar5);
            this.groupBox4.Controls.Add(this.progressBar4);
            this.groupBox4.Controls.Add(this.progressBar3);
            this.groupBox4.Controls.Add(this.prgBarStatusRelay1);
            this.groupBox4.Controls.Add(this.btnControlOffRelay1);
            this.groupBox4.Controls.Add(this.btnControlOnRelay1);
            this.groupBox4.Location = new System.Drawing.Point(832, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 456);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relay Control";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(3, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.TabIndex = 52;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar10
            // 
            this.progressBar10.BackColor = System.Drawing.Color.Red;
            this.progressBar10.Location = new System.Drawing.Point(148, 284);
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(23, 23);
            this.progressBar10.TabIndex = 51;
            this.progressBar10.Click += new System.EventHandler(this.progressBar10_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 217);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "LED 7";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 246);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "LED 8";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "LED 2";
            this.label15.Click += new System.EventHandler(this.label15_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 46;
            this.label14.Text = "LED 3";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 131);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "LED4";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "LED 5";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "LED6";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "LED 1";
            this.label6.Click += new System.EventHandler(this.label6_Click_2);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button13.Location = new System.Drawing.Point(177, 97);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 41;
            this.button13.Text = "Close";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(177, 129);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 40;
            this.button12.Text = "Close";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(177, 156);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 39;
            this.button11.Text = "Close";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button10.Location = new System.Drawing.Point(177, 185);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 38;
            this.button10.Text = "Close";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(177, 241);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 37;
            this.button9.Text = "Close";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(177, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(177, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20.Location = new System.Drawing.Point(67, 68);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 23);
            this.button20.TabIndex = 34;
            this.button20.Text = "Open";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button19.Location = new System.Drawing.Point(67, 97);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 33;
            this.button19.Text = "Open";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(67, 126);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 32;
            this.button8.Text = "Open";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(67, 154);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 31;
            this.button7.Text = "Open";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(67, 183);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 30;
            this.button6.Text = "Open";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(67, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 29;
            this.button5.Text = "Open";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(67, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Open";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button18.Location = new System.Drawing.Point(177, 270);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 53);
            this.button18.TabIndex = 25;
            this.button18.Text = "Close All";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button17.Location = new System.Drawing.Point(67, 270);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 53);
            this.button17.TabIndex = 24;
            this.button17.Text = "Open All";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // progressBar9
            // 
            this.progressBar9.BackColor = System.Drawing.Color.Red;
            this.progressBar9.Location = new System.Drawing.Point(148, 242);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(23, 23);
            this.progressBar9.TabIndex = 23;
            this.progressBar9.Click += new System.EventHandler(this.progressBar9_Click);
            // 
            // progressBar8
            // 
            this.progressBar8.BackColor = System.Drawing.Color.Red;
            this.progressBar8.Location = new System.Drawing.Point(148, 212);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(23, 23);
            this.progressBar8.TabIndex = 22;
            this.progressBar8.Click += new System.EventHandler(this.progressBar8_Click);
            // 
            // progressBar7
            // 
            this.progressBar7.BackColor = System.Drawing.Color.Red;
            this.progressBar7.Location = new System.Drawing.Point(148, 183);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(23, 23);
            this.progressBar7.TabIndex = 21;
            this.progressBar7.Click += new System.EventHandler(this.progressBar7_Click);
            // 
            // progressBar6
            // 
            this.progressBar6.BackColor = System.Drawing.Color.Red;
            this.progressBar6.Location = new System.Drawing.Point(148, 154);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(23, 23);
            this.progressBar6.TabIndex = 20;
            this.progressBar6.Click += new System.EventHandler(this.progressBar6_Click);
            // 
            // progressBar5
            // 
            this.progressBar5.BackColor = System.Drawing.Color.Red;
            this.progressBar5.Location = new System.Drawing.Point(148, 125);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(23, 23);
            this.progressBar5.TabIndex = 19;
            this.progressBar5.Click += new System.EventHandler(this.progressBar5_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.Color.Red;
            this.progressBar4.Location = new System.Drawing.Point(148, 96);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(23, 23);
            this.progressBar4.TabIndex = 18;
            this.progressBar4.Click += new System.EventHandler(this.progressBar4_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.Color.Red;
            this.progressBar3.Location = new System.Drawing.Point(148, 67);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(23, 23);
            this.progressBar3.TabIndex = 17;
            this.progressBar3.Click += new System.EventHandler(this.progressBar3_Click);
            // 
            // prgBarStatusRelay1
            // 
            this.prgBarStatusRelay1.BackColor = System.Drawing.Color.Red;
            this.prgBarStatusRelay1.Location = new System.Drawing.Point(148, 39);
            this.prgBarStatusRelay1.Name = "prgBarStatusRelay1";
            this.prgBarStatusRelay1.Size = new System.Drawing.Size(23, 23);
            this.prgBarStatusRelay1.TabIndex = 16;
            this.prgBarStatusRelay1.Click += new System.EventHandler(this.prgBarStatusRelay1_Click);
            // 
            // btnControlOffRelay1
            // 
            this.btnControlOffRelay1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnControlOffRelay1.Location = new System.Drawing.Point(177, 39);
            this.btnControlOffRelay1.Name = "btnControlOffRelay1";
            this.btnControlOffRelay1.Size = new System.Drawing.Size(75, 23);
            this.btnControlOffRelay1.TabIndex = 8;
            this.btnControlOffRelay1.Text = "Close";
            this.btnControlOffRelay1.UseVisualStyleBackColor = false;
            this.btnControlOffRelay1.Click += new System.EventHandler(this.btnControlOffRelay1_Click);
            // 
            // btnControlOnRelay1
            // 
            this.btnControlOnRelay1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnControlOnRelay1.Location = new System.Drawing.Point(67, 39);
            this.btnControlOnRelay1.Name = "btnControlOnRelay1";
            this.btnControlOnRelay1.Size = new System.Drawing.Size(75, 23);
            this.btnControlOnRelay1.TabIndex = 0;
            this.btnControlOnRelay1.Text = "Open";
            this.btnControlOnRelay1.UseVisualStyleBackColor = false;
            this.btnControlOnRelay1.Click += new System.EventHandler(this.btnControlOnRelay1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 555);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "SERIAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox serialPortNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox serialBaurate;
        private System.Windows.Forms.ComboBox serialDataBits;
        private System.Windows.Forms.ComboBox serialStopBits;
        private System.Windows.Forms.ComboBox serialParityBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button bntOpen;
        private System.Windows.Forms.Button btnSendData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox dataOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClearDataSend;
        private System.Windows.Forms.CheckBox cBoxWrite;
        private System.Windows.Forms.CheckBox cBoxWriteLine;
        private System.Windows.Forms.CheckBox chkBoxUseEnterForSend;
        private System.Windows.Forms.CheckBox cBoxButtonForSend;
        private System.Windows.Forms.Label lbLengthDataReceived;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkBoxAddToOldData;
        private System.Windows.Forms.CheckBox chkBoxAlwaysUpdate;
        private System.Windows.Forms.Button btnClearDataReceived;
        private System.Windows.Forms.TextBox tBoxDataReceived;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnControlOffRelay1;
        private System.Windows.Forms.Button btnControlOnRelay1;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar prgBarStatusRelay1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

