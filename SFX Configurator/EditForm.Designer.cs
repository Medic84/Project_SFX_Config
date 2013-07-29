namespace Project_SFX_Config
{
    partial class EditForm
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
			this.TOK = new System.Windows.Forms.Button();
			this.TCancel = new System.Windows.Forms.Button();
			this.TEdit = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// TOK
			// 
			this.TOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.TOK.Image = global::Project_SFX_Config.Properties.Resources.accept;
			this.TOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TOK.Location = new System.Drawing.Point(6, 230);
			this.TOK.Name = "TOK";
			this.TOK.Size = new System.Drawing.Size(79, 23);
			this.TOK.TabIndex = 0;
			this.TOK.Text = "  ОК";
			this.TOK.UseVisualStyleBackColor = true;
			// 
			// TCancel
			// 
			this.TCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.TCancel.Image = global::Project_SFX_Config.Properties.Resources.cancel;
			this.TCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.TCancel.Location = new System.Drawing.Point(322, 230);
			this.TCancel.Name = "TCancel";
			this.TCancel.Size = new System.Drawing.Size(83, 23);
			this.TCancel.TabIndex = 1;
			this.TCancel.Text = "  Отмена";
			this.TCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TCancel.UseVisualStyleBackColor = true;
			// 
			// TEdit
			// 
			this.TEdit.AcceptsTab = true;
			this.TEdit.Location = new System.Drawing.Point(6, 6);
			this.TEdit.Multiline = true;
			this.TEdit.Name = "TEdit";
			this.TEdit.Size = new System.Drawing.Size(399, 219);
			this.TEdit.TabIndex = 2;
			// 
			// EditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Project_SFX_Config.Properties.Resources.fon;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CancelButton = this.TCancel;
			this.ClientSize = new System.Drawing.Size(412, 258);
			this.ControlBox = false;
			this.Controls.Add(this.TEdit);
			this.Controls.Add(this.TCancel);
			this.Controls.Add(this.TOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "   Редактор строк";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TOK;
        private System.Windows.Forms.Button TCancel;
        private System.Windows.Forms.TextBox TEdit;
    }
}