namespace Project_SFX_Config
{
    partial class OptForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TAutoReplace = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TOverwriteMode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TGUIMode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TMiscFlags = new System.Windows.Forms.TextBox();
            this.TGUIFlags = new System.Windows.Forms.TextBox();
            this.TSaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TAutoReplace);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поведение программы при сохранении";
            // 
            // TAutoReplace
            // 
            this.TAutoReplace.AutoSize = true;
            this.TAutoReplace.Enabled = false;
            this.TAutoReplace.Location = new System.Drawing.Point(6, 26);
            this.TAutoReplace.Name = "TAutoReplace";
            this.TAutoReplace.Size = new System.Drawing.Size(385, 17);
            this.TAutoReplace.TabIndex = 0;
            this.TAutoReplace.Text = "Заменять \" и \\ на экранированные варианты \\\" и \\\\  автоматически";
            this.TAutoReplace.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TOverwriteMode);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TGUIMode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TMiscFlags);
            this.groupBox2.Controls.Add(this.TGUIFlags);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры загрузки программы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "OverwriteMode по-умолчанию:";
            // 
            // TOverwriteMode
            // 
            this.TOverwriteMode.Location = new System.Drawing.Point(185, 105);
            this.TOverwriteMode.MaxLength = 3;
            this.TOverwriteMode.Name = "TOverwriteMode";
            this.TOverwriteMode.Size = new System.Drawing.Size(290, 22);
            this.TOverwriteMode.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "GUIMode по-умолчанию:";
            // 
            // TGUIMode
            // 
            this.TGUIMode.Location = new System.Drawing.Point(185, 77);
            this.TGUIMode.MaxLength = 1;
            this.TGUIMode.Name = "TGUIMode";
            this.TGUIMode.Size = new System.Drawing.Size(290, 22);
            this.TGUIMode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "* флаги разделять символом \"+\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MiscFlags по-умолчанию:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GUIFlags по-умолчанию:";
            // 
            // TMiscFlags
            // 
            this.TMiscFlags.Location = new System.Drawing.Point(185, 49);
            this.TMiscFlags.MaxLength = 8;
            this.TMiscFlags.Name = "TMiscFlags";
            this.TMiscFlags.Size = new System.Drawing.Size(290, 22);
            this.TMiscFlags.TabIndex = 1;
            // 
            // TGUIFlags
            // 
            this.TGUIFlags.Location = new System.Drawing.Point(185, 21);
            this.TGUIFlags.MaxLength = 27;
            this.TGUIFlags.Name = "TGUIFlags";
            this.TGUIFlags.Size = new System.Drawing.Size(290, 22);
            this.TGUIFlags.TabIndex = 0;
            // 
            // TSaveButton
            // 
            this.TSaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.TSaveButton.Image = global::Project_SFX_Config.Properties.Resources.accept;
            this.TSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TSaveButton.Location = new System.Drawing.Point(405, 235);
            this.TSaveButton.Name = "TSaveButton";
            this.TSaveButton.Size = new System.Drawing.Size(88, 26);
            this.TSaveButton.TabIndex = 2;
            this.TSaveButton.Text = "Сохранить";
            this.TSaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TSaveButton.UseVisualStyleBackColor = true;
            this.TSaveButton.Click += new System.EventHandler(this.TSaveButton_Click);
            // 
            // OptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_SFX_Config.Properties.Resources.fon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(505, 265);
            this.Controls.Add(this.TSaveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки программы";
            this.Load += new System.EventHandler(this.OptForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox TAutoReplace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TMiscFlags;
        private System.Windows.Forms.TextBox TGUIFlags;
        private System.Windows.Forms.Button TSaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TOverwriteMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TGUIMode;
    }
}