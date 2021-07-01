
namespace FuelStationProject.WUI
{
    partial class ConnectionForm
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
            this.ctrlConnectionString = new DevExpress.XtraEditors.TextEdit();
            this.lblConnectionString = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlConnectionString.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlConnectionString
            // 
            this.ctrlConnectionString.EditValue = "Server=localhost\\SQLEXPRESS;Database=FuelStation;Trusted_Connection=True;";
            this.ctrlConnectionString.Location = new System.Drawing.Point(40, 100);
            this.ctrlConnectionString.Name = "ctrlConnectionString";
            this.ctrlConnectionString.Size = new System.Drawing.Size(751, 22);
            this.ctrlConnectionString.TabIndex = 0;
            this.ctrlConnectionString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlConnectionString_KeyDown);
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblConnectionString.Appearance.Options.UseFont = true;
            this.lblConnectionString.Location = new System.Drawing.Point(40, 49);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(262, 28);
            this.lblConnectionString.TabIndex = 1;
            this.lblConnectionString.Text = "Insert connection string...";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(567, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 44);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(702, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 275);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblConnectionString);
            this.Controls.Add(this.ctrlConnectionString);
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionForm_FormClosing);
            this.Load += new System.EventHandler(this.ConnectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlConnectionString.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ctrlConnectionString;
        private DevExpress.XtraEditors.LabelControl lblConnectionString;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}