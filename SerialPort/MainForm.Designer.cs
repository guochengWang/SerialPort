namespace SerialPort
{
    partial class MainForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.sendHEX = new DevExpress.XtraEditors.CheckEdit();
            this.sendASCII = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.clearRec = new DevExpress.XtraEditors.SimpleButton();
            this.autoScroll = new DevExpress.XtraEditors.CheckEdit();
            this.recSaveFile = new DevExpress.XtraEditors.CheckEdit();
            this.recLog = new DevExpress.XtraEditors.CheckEdit();
            this.recHEX = new DevExpress.XtraEditors.CheckEdit();
            this.recASCII = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.serialPortBtn = new DevExpress.XtraEditors.SimpleButton();
            this.stopBits = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dataBit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.parityBit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.baudRate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.port = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dataLog = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sendInfo = new DevExpress.XtraEditors.MemoEdit();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendHEX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendASCII.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoScroll.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recSaveFile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recHEX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recASCII.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBits.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parityBit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLog.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendInfo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl3);
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(177, 565);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.textBox1);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.checkEdit2);
            this.groupControl3.Controls.Add(this.checkEdit1);
            this.groupControl3.Controls.Add(this.sendHEX);
            this.groupControl3.Controls.Add(this.sendASCII);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(2, 408);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(173, 155);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "发送设置";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(152, 101);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(15, 14);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "ms";
            // 
            // checkEdit2
            // 
            this.checkEdit2.Location = new System.Drawing.Point(10, 99);
            this.checkEdit2.Name = "checkEdit2";
            this.checkEdit2.Properties.Caption = "循环周期";
            this.checkEdit2.Size = new System.Drawing.Size(85, 19);
            this.checkEdit2.TabIndex = 4;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(10, 67);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "生成随机数";
            this.checkEdit1.Size = new System.Drawing.Size(112, 19);
            this.checkEdit1.TabIndex = 3;
            // 
            // sendHEX
            // 
            this.sendHEX.Location = new System.Drawing.Point(79, 42);
            this.sendHEX.Name = "sendHEX";
            this.sendHEX.Properties.Caption = "HEX";
            this.sendHEX.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.sendHEX.Properties.RadioGroupIndex = 2;
            this.sendHEX.Size = new System.Drawing.Size(75, 19);
            this.sendHEX.TabIndex = 2;
            this.sendHEX.TabStop = false;
            // 
            // sendASCII
            // 
            this.sendASCII.EditValue = true;
            this.sendASCII.Location = new System.Drawing.Point(10, 40);
            this.sendASCII.Name = "sendASCII";
            this.sendASCII.Properties.Caption = "ASCII";
            this.sendASCII.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.sendASCII.Properties.RadioGroupIndex = 2;
            this.sendASCII.Size = new System.Drawing.Size(75, 19);
            this.sendASCII.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.clearRec);
            this.groupControl2.Controls.Add(this.autoScroll);
            this.groupControl2.Controls.Add(this.recSaveFile);
            this.groupControl2.Controls.Add(this.recLog);
            this.groupControl2.Controls.Add(this.recHEX);
            this.groupControl2.Controls.Add(this.recASCII);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(2, 219);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(173, 189);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "接收设置";
            // 
            // clearRec
            // 
            this.clearRec.Location = new System.Drawing.Point(5, 136);
            this.clearRec.Name = "clearRec";
            this.clearRec.Size = new System.Drawing.Size(149, 30);
            this.clearRec.TabIndex = 5;
            this.clearRec.Text = "清除接收";
            this.clearRec.Click += new System.EventHandler(this.clearRec_Click);
            // 
            // autoScroll
            // 
            this.autoScroll.Location = new System.Drawing.Point(10, 111);
            this.autoScroll.Name = "autoScroll";
            this.autoScroll.Properties.Caption = "自动滚屏";
            this.autoScroll.Size = new System.Drawing.Size(112, 19);
            this.autoScroll.TabIndex = 4;
            // 
            // recSaveFile
            // 
            this.recSaveFile.Location = new System.Drawing.Point(10, 86);
            this.recSaveFile.Name = "recSaveFile";
            this.recSaveFile.Properties.Caption = "接收保存到文件";
            this.recSaveFile.Size = new System.Drawing.Size(112, 19);
            this.recSaveFile.TabIndex = 3;
            // 
            // recLog
            // 
            this.recLog.Location = new System.Drawing.Point(10, 61);
            this.recLog.Name = "recLog";
            this.recLog.Properties.Caption = "按日志模式显示";
            this.recLog.Size = new System.Drawing.Size(112, 19);
            this.recLog.TabIndex = 2;
            // 
            // recHEX
            // 
            this.recHEX.Location = new System.Drawing.Point(93, 36);
            this.recHEX.Name = "recHEX";
            this.recHEX.Properties.Caption = "HEX";
            this.recHEX.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.recHEX.Properties.RadioGroupIndex = 1;
            this.recHEX.Size = new System.Drawing.Size(75, 19);
            this.recHEX.TabIndex = 1;
            this.recHEX.TabStop = false;
            // 
            // recASCII
            // 
            this.recASCII.EditValue = true;
            this.recASCII.Location = new System.Drawing.Point(10, 36);
            this.recASCII.Name = "recASCII";
            this.recASCII.Properties.Caption = "ASCII";
            this.recASCII.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.recASCII.Properties.RadioGroupIndex = 1;
            this.recASCII.Size = new System.Drawing.Size(75, 19);
            this.recASCII.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.serialPortBtn);
            this.groupControl1.Controls.Add(this.stopBits);
            this.groupControl1.Controls.Add(this.dataBit);
            this.groupControl1.Controls.Add(this.parityBit);
            this.groupControl1.Controls.Add(this.baudRate);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.port);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(173, 217);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "串口设置";
            // 
            // serialPortBtn
            // 
            this.serialPortBtn.Location = new System.Drawing.Point(19, 181);
            this.serialPortBtn.Name = "serialPortBtn";
            this.serialPortBtn.Size = new System.Drawing.Size(149, 30);
            this.serialPortBtn.TabIndex = 2;
            this.serialPortBtn.Text = "打开串口";
            this.serialPortBtn.Click += new System.EventHandler(this.serialPort_Click);
            // 
            // stopBits
            // 
            this.stopBits.Location = new System.Drawing.Point(55, 155);
            this.stopBits.Name = "stopBits";
            this.stopBits.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stopBits.Size = new System.Drawing.Size(112, 20);
            this.stopBits.TabIndex = 14;
            // 
            // dataBit
            // 
            this.dataBit.Location = new System.Drawing.Point(56, 125);
            this.dataBit.Name = "dataBit";
            this.dataBit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataBit.Size = new System.Drawing.Size(112, 20);
            this.dataBit.TabIndex = 13;
            // 
            // parityBit
            // 
            this.parityBit.Location = new System.Drawing.Point(56, 94);
            this.parityBit.Name = "parityBit";
            this.parityBit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.parityBit.Size = new System.Drawing.Size(112, 20);
            this.parityBit.TabIndex = 12;
            // 
            // baudRate
            // 
            this.baudRate.Location = new System.Drawing.Point(56, 65);
            this.baudRate.Name = "baudRate";
            this.baudRate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.baudRate.Size = new System.Drawing.Size(112, 20);
            this.baudRate.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 156);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(42, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "停止位";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 125);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "数据位";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 17);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "校验位";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(5, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 17);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "波特率";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(56, 36);
            this.port.Name = "port";
            this.port.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.port.Size = new System.Drawing.Size(112, 20);
            this.port.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(5, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "串口号";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl4);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(177, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(643, 565);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dataLog);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(2, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(639, 467);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "数据日志";
            // 
            // dataLog
            // 
            this.dataLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLog.Location = new System.Drawing.Point(2, 22);
            this.dataLog.Name = "dataLog";
            this.dataLog.Size = new System.Drawing.Size(635, 443);
            this.dataLog.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.simpleButton1);
            this.panelControl4.Controls.Add(this.sendInfo);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(2, 469);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(639, 94);
            this.panelControl4.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(561, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(76, 90);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "发送";
            // 
            // sendInfo
            // 
            this.sendInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.sendInfo.Location = new System.Drawing.Point(2, 2);
            this.sendInfo.Name = "sendInfo";
            this.sendInfo.Size = new System.Drawing.Size(559, 90);
            this.sendInfo.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 565);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.LookAndFeel.SkinName = "Blue";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "串口通信助手";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendHEX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendASCII.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoScroll.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recSaveFile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recHEX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recASCII.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stopBits.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parityBit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baudRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLog.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendInfo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit sendInfo;
        private DevExpress.XtraEditors.MemoEdit dataLog;
        private DevExpress.XtraEditors.ComboBoxEdit port;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit stopBits;
        private DevExpress.XtraEditors.ComboBoxEdit dataBit;
        private DevExpress.XtraEditors.ComboBoxEdit parityBit;
        private DevExpress.XtraEditors.ComboBoxEdit baudRate;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton serialPortBtn;
        private DevExpress.XtraEditors.CheckEdit recHEX;
        private DevExpress.XtraEditors.CheckEdit recASCII;
        private DevExpress.XtraEditors.CheckEdit autoScroll;
        private DevExpress.XtraEditors.CheckEdit recSaveFile;
        private DevExpress.XtraEditors.CheckEdit recLog;
        private DevExpress.XtraEditors.SimpleButton clearRec;
        private DevExpress.XtraEditors.CheckEdit sendHEX;
        private DevExpress.XtraEditors.CheckEdit sendASCII;
        private System.IO.Ports.SerialPort serialPort;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.CheckEdit checkEdit2;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

