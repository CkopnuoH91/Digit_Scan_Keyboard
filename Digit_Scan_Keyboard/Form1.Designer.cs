namespace Digit_Scan_Keyboard
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxTx = new System.Windows.Forms.TextBox();
            this.textBoxRx = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClearTx = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearRx = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(27, 33);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(87, 23);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключить";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(27, 85);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(87, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Отключить";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoCheck = false;
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(27, 62);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(15, 14);
            this.checkBoxStatus.TabIndex = 2;
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxTx
            // 
            this.textBoxTx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTx.Location = new System.Drawing.Point(3, 33);
            this.textBoxTx.Multiline = true;
            this.textBoxTx.Name = "textBoxTx";
            this.textBoxTx.ReadOnly = true;
            this.textBoxTx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTx.Size = new System.Drawing.Size(415, 456);
            this.textBoxTx.TabIndex = 3;
            this.textBoxTx.TabStop = false;
            // 
            // textBoxRx
            // 
            this.textBoxRx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRx.Location = new System.Drawing.Point(3, 33);
            this.textBoxRx.Multiline = true;
            this.textBoxRx.Name = "textBoxRx";
            this.textBoxRx.ReadOnly = true;
            this.textBoxRx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRx.Size = new System.Drawing.Size(422, 456);
            this.textBoxRx.TabIndex = 4;
            this.textBoxRx.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.Controls.Add(this.buttonDisconnect);
            this.groupBox1.Controls.Add(this.checkBoxStatus);
            this.groupBox1.Location = new System.Drawing.Point(871, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClearTx);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTx);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnClearRx);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxRx);
            this.splitContainer1.Size = new System.Drawing.Size(853, 540);
            this.splitContainer1.SplitterDistance = 421;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnClearTx
            // 
            this.btnClearTx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTx.Location = new System.Drawing.Point(6, 495);
            this.btnClearTx.Name = "btnClearTx";
            this.btnClearTx.Size = new System.Drawing.Size(412, 42);
            this.btnClearTx.TabIndex = 5;
            this.btnClearTx.Text = "Очистить";
            this.btnClearTx.UseVisualStyleBackColor = true;
            this.btnClearTx.Click += new System.EventHandler(this.btnClearTx_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Передано:";
            // 
            // btnClearRx
            // 
            this.btnClearRx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearRx.Location = new System.Drawing.Point(7, 495);
            this.btnClearRx.Name = "btnClearRx";
            this.btnClearRx.Size = new System.Drawing.Size(418, 42);
            this.btnClearRx.TabIndex = 6;
            this.btnClearRx.Text = "Очистить";
            this.btnClearRx.UseVisualStyleBackColor = true;
            this.btnClearRx.Click += new System.EventHandler(this.btnClearRx_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Принято:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 564);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Digit_Scan_Keyboard";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.Button buttonConnect;
        public System.Windows.Forms.Button buttonDisconnect;
        public System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.TextBox textBoxTx;
        private System.Windows.Forms.TextBox textBoxRx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnClearTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearRx;
        private System.Windows.Forms.Label label2;
    }
}

