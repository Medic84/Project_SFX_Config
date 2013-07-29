namespace Project_SFX_Config
{
    partial class SelectPrefix
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
            this.Tfmnumber = new System.Windows.Forms.NumericUpDown();
            this.ThidconCheck = new System.Windows.Forms.CheckBox();
            this.TfmCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TWaitAllCheck = new System.Windows.Forms.CheckBox();
            this.TforcenowaitCheck = new System.Windows.Forms.CheckBox();
            this.TnowaitCheck = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TArchPRadio = new System.Windows.Forms.RadioButton();
            this.TArchx64Radio = new System.Windows.Forms.RadioButton();
            this.TArchx86Radio = new System.Windows.Forms.RadioButton();
            this.TArchNoRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tdelnumber = new System.Windows.Forms.NumericUpDown();
            this.TdelCheck = new System.Windows.Forms.CheckBox();
            this.Tshcnumber = new System.Windows.Forms.NumericUpDown();
            this.TshcCheck = new System.Windows.Forms.CheckBox();
            this.TOKBt = new System.Windows.Forms.Button();
            this.ToolTiper = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Tfmnumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tdelnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tshcnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Tfmnumber
            // 
            this.Tfmnumber.Location = new System.Drawing.Point(44, 67);
            this.Tfmnumber.Name = "Tfmnumber";
            this.Tfmnumber.Size = new System.Drawing.Size(74, 22);
            this.Tfmnumber.TabIndex = 18;
            // 
            // ThidconCheck
            // 
            this.ThidconCheck.AutoSize = true;
            this.ThidconCheck.Location = new System.Drawing.Point(6, 44);
            this.ThidconCheck.Name = "ThidconCheck";
            this.ThidconCheck.Size = new System.Drawing.Size(62, 17);
            this.ThidconCheck.TabIndex = 21;
            this.ThidconCheck.Text = "hidcon";
            this.ThidconCheck.UseVisualStyleBackColor = true;
            // 
            // TfmCheck
            // 
            this.TfmCheck.AutoSize = true;
            this.TfmCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TfmCheck.Location = new System.Drawing.Point(5, 68);
            this.TfmCheck.Name = "TfmCheck";
            this.TfmCheck.Size = new System.Drawing.Size(40, 17);
            this.TfmCheck.TabIndex = 19;
            this.TfmCheck.Text = "fm";
            this.TfmCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TWaitAllCheck);
            this.groupBox1.Controls.Add(this.TforcenowaitCheck);
            this.groupBox1.Controls.Add(this.TnowaitCheck);
            this.groupBox1.Controls.Add(this.ThidconCheck);
            this.groupBox1.Controls.Add(this.Tfmnumber);
            this.groupBox1.Controls.Add(this.TfmCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные";
            // 
            // TWaitAllCheck
            // 
            this.TWaitAllCheck.AutoSize = true;
            this.TWaitAllCheck.Location = new System.Drawing.Point(179, 21);
            this.TWaitAllCheck.Name = "TWaitAllCheck";
            this.TWaitAllCheck.Size = new System.Drawing.Size(60, 17);
            this.TWaitAllCheck.TabIndex = 24;
            this.TWaitAllCheck.Text = "waitall";
            this.TWaitAllCheck.UseVisualStyleBackColor = true;
            this.TWaitAllCheck.Click += new System.EventHandler(this.TWaitAllCheck_Click);
            // 
            // TforcenowaitCheck
            // 
            this.TforcenowaitCheck.AutoSize = true;
            this.TforcenowaitCheck.Location = new System.Drawing.Point(85, 21);
            this.TforcenowaitCheck.Name = "TforcenowaitCheck";
            this.TforcenowaitCheck.Size = new System.Drawing.Size(88, 17);
            this.TforcenowaitCheck.TabIndex = 23;
            this.TforcenowaitCheck.Text = "forcenowait";
            this.TforcenowaitCheck.UseVisualStyleBackColor = true;
            this.TforcenowaitCheck.Click += new System.EventHandler(this.TforcenowaitCheck_Click);
            // 
            // TnowaitCheck
            // 
            this.TnowaitCheck.AutoSize = true;
            this.TnowaitCheck.Location = new System.Drawing.Point(6, 21);
            this.TnowaitCheck.Name = "TnowaitCheck";
            this.TnowaitCheck.Size = new System.Drawing.Size(62, 17);
            this.TnowaitCheck.TabIndex = 22;
            this.TnowaitCheck.Text = "nowait";
            this.TnowaitCheck.UseVisualStyleBackColor = true;
            this.TnowaitCheck.Click += new System.EventHandler(this.TnowaitCheck_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.TArchPRadio);
            this.groupBox3.Controls.Add(this.TArchx64Radio);
            this.groupBox3.Controls.Add(this.TArchx86Radio);
            this.groupBox3.Controls.Add(this.TArchNoRadio);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 93);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Архитектура";
            // 
            // TArchPRadio
            // 
            this.TArchPRadio.AutoSize = true;
            this.TArchPRadio.Location = new System.Drawing.Point(5, 68);
            this.TArchPRadio.Name = "TArchPRadio";
            this.TArchPRadio.Size = new System.Drawing.Size(49, 17);
            this.TArchPRadio.TabIndex = 29;
            this.TArchPRadio.TabStop = true;
            this.TArchPRadio.Text = "%%P";
            this.TArchPRadio.UseVisualStyleBackColor = true;
            // 
            // TArchx64Radio
            // 
            this.TArchx64Radio.AutoSize = true;
            this.TArchx64Radio.Location = new System.Drawing.Point(54, 44);
            this.TArchx64Radio.Name = "TArchx64Radio";
            this.TArchx64Radio.Size = new System.Drawing.Size(42, 17);
            this.TArchx64Radio.TabIndex = 26;
            this.TArchx64Radio.Text = "x64";
            this.TArchx64Radio.UseVisualStyleBackColor = true;
            // 
            // TArchx86Radio
            // 
            this.TArchx86Radio.AutoSize = true;
            this.TArchx86Radio.Location = new System.Drawing.Point(6, 45);
            this.TArchx86Radio.Name = "TArchx86Radio";
            this.TArchx86Radio.Size = new System.Drawing.Size(42, 17);
            this.TArchx86Radio.TabIndex = 25;
            this.TArchx86Radio.Text = "x86";
            this.TArchx86Radio.UseVisualStyleBackColor = true;
            // 
            // TArchNoRadio
            // 
            this.TArchNoRadio.AutoSize = true;
            this.TArchNoRadio.Checked = true;
            this.TArchNoRadio.Location = new System.Drawing.Point(6, 21);
            this.TArchNoRadio.Name = "TArchNoRadio";
            this.TArchNoRadio.Size = new System.Drawing.Size(116, 17);
            this.TArchNoRadio.TabIndex = 27;
            this.TArchNoRadio.TabStop = true;
            this.TArchNoRadio.Text = "Без определения";
            this.TArchNoRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Tdelnumber);
            this.groupBox2.Controls.Add(this.TdelCheck);
            this.groupBox2.Controls.Add(this.Tshcnumber);
            this.groupBox2.Controls.Add(this.TshcCheck);
            this.groupBox2.Location = new System.Drawing.Point(148, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 93);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительные";
            // 
            // Tdelnumber
            // 
            this.Tdelnumber.Location = new System.Drawing.Point(55, 48);
            this.Tdelnumber.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tdelnumber.Name = "Tdelnumber";
            this.Tdelnumber.Size = new System.Drawing.Size(46, 22);
            this.Tdelnumber.TabIndex = 3;
            // 
            // TdelCheck
            // 
            this.TdelCheck.AutoSize = true;
            this.TdelCheck.Location = new System.Drawing.Point(6, 50);
            this.TdelCheck.Name = "TdelCheck";
            this.TdelCheck.Size = new System.Drawing.Size(42, 17);
            this.TdelCheck.TabIndex = 2;
            this.TdelCheck.Text = "del";
            this.TdelCheck.UseVisualStyleBackColor = true;
            // 
            // Tshcnumber
            // 
            this.Tshcnumber.Location = new System.Drawing.Point(55, 20);
            this.Tshcnumber.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tshcnumber.Name = "Tshcnumber";
            this.Tshcnumber.Size = new System.Drawing.Size(46, 22);
            this.Tshcnumber.TabIndex = 1;
            // 
            // TshcCheck
            // 
            this.TshcCheck.AutoSize = true;
            this.TshcCheck.Location = new System.Drawing.Point(6, 21);
            this.TshcCheck.Name = "TshcCheck";
            this.TshcCheck.Size = new System.Drawing.Size(43, 17);
            this.TshcCheck.TabIndex = 0;
            this.TshcCheck.Text = "shc";
            this.TshcCheck.UseVisualStyleBackColor = true;
            // 
            // TOKBt
            // 
            this.TOKBt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.TOKBt.Location = new System.Drawing.Point(110, 217);
            this.TOKBt.Name = "TOKBt";
            this.TOKBt.Size = new System.Drawing.Size(75, 23);
            this.TOKBt.TabIndex = 29;
            this.TOKBt.Text = "OK";
            this.TOKBt.UseVisualStyleBackColor = true;
            this.TOKBt.Click += new System.EventHandler(this.TOKBt_Click);
            // 
            // ToolTiper
            // 
            this.ToolTiper.AutoPopDelay = 7000;
            this.ToolTiper.InitialDelay = 500;
            this.ToolTiper.ReshowDelay = 100;
            this.ToolTiper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTiper.ToolTipTitle = "Примечание:";
            // 
            // SelectPrefix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SFX_Config.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(293, 244);
            this.Controls.Add(this.TOKBt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SelectPrefix";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбор префикса";
            this.Load += new System.EventHandler(this.SelectPrefix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tfmnumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tdelnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tshcnumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Tfmnumber;
        private System.Windows.Forms.CheckBox ThidconCheck;
        private System.Windows.Forms.CheckBox TfmCheck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton TArchx64Radio;
        private System.Windows.Forms.RadioButton TArchx86Radio;
        private System.Windows.Forms.RadioButton TArchNoRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown Tdelnumber;
        private System.Windows.Forms.CheckBox TdelCheck;
        private System.Windows.Forms.NumericUpDown Tshcnumber;
        private System.Windows.Forms.CheckBox TshcCheck;
        private System.Windows.Forms.RadioButton TArchPRadio;
        private System.Windows.Forms.CheckBox TforcenowaitCheck;
        private System.Windows.Forms.CheckBox TnowaitCheck;
        private System.Windows.Forms.Button TOKBt;
        private System.Windows.Forms.CheckBox TWaitAllCheck;
        private System.Windows.Forms.ToolTip ToolTiper;
    }
}