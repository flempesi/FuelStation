
namespace FuelStationProject.WUI {
    partial class CustomerCheckForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ctlrCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(323, 259);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(115, 39);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ctrlCardNumber
            // 
            this.ctrlCardNumber.Location = new System.Drawing.Point(42, 127);
            this.ctrlCardNumber.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlCardNumber.Name = "ctrlCardNumber";
            this.ctrlCardNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlCardNumber.Properties.Appearance.Options.UseFont = true;
            this.ctrlCardNumber.Size = new System.Drawing.Size(544, 28);
            this.ctrlCardNumber.TabIndex = 14;
            this.ctrlCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctrlCardNumber_KeyDown);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(42, 62);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(184, 21);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Customer Card Number :";
            // 
            // ctlrCancel
            // 
            this.ctlrCancel.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.ctlrCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctlrCancel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ctlrCancel.Appearance.Options.UseBackColor = true;
            this.ctlrCancel.Appearance.Options.UseFont = true;
            this.ctlrCancel.Appearance.Options.UseForeColor = true;
            this.ctlrCancel.Location = new System.Drawing.Point(478, 259);
            this.ctlrCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctlrCancel.Name = "ctlrCancel";
            this.ctlrCancel.Size = new System.Drawing.Size(108, 39);
            this.ctlrCancel.TabIndex = 47;
            this.ctlrCancel.Text = "Cancel";
            this.ctlrCancel.Click += new System.EventHandler(this.ctlrCancel_Click);
            // 
            // CustomerCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 345);
            this.Controls.Add(this.ctlrCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctrlCardNumber);
            this.Controls.Add(this.labelControl2);
            this.Name = "CustomerCheckForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Card Number Checker";
            this.Load += new System.EventHandler(this.CustomerCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnOK;
        public DevExpress.XtraEditors.TextEdit ctrlCardNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton ctlrCancel;
    }
}