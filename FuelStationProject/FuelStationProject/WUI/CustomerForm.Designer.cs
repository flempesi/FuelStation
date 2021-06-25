
namespace FuelStationProject.WUI {
    partial class CustomerForm {
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
            this.ctlrCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.Title = new DevExpress.XtraEditors.LabelControl();
            this.lblCardNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblSurname = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlrCancel
            // 
            this.ctlrCancel.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.ctlrCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctlrCancel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ctlrCancel.Appearance.Options.UseBackColor = true;
            this.ctlrCancel.Appearance.Options.UseFont = true;
            this.ctlrCancel.Appearance.Options.UseForeColor = true;
            this.ctlrCancel.Location = new System.Drawing.Point(717, 469);
            this.ctlrCancel.Name = "ctlrCancel";
            this.ctlrCancel.Size = new System.Drawing.Size(123, 40);
            this.ctlrCancel.TabIndex = 42;
            this.ctlrCancel.Text = "Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOK.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Appearance.Options.UseForeColor = true;
            this.btnOK.Location = new System.Drawing.Point(569, 469);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 40);
            this.btnOK.TabIndex = 41;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Title
            // 
            this.Title.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Title.Appearance.Options.UseFont = true;
            this.Title.Location = new System.Drawing.Point(47, 33);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(144, 24);
            this.Title.TabIndex = 40;
            this.Title.Text = "Add Customer : ";
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCardNumber.Appearance.Options.UseFont = true;
            this.lblCardNumber.Location = new System.Drawing.Point(47, 233);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(108, 21);
            this.lblCardNumber.TabIndex = 39;
            this.lblCardNumber.Text = "CardNumber : ";
            // 
            // lblSurname
            // 
            this.lblSurname.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSurname.Appearance.Options.UseFont = true;
            this.lblSurname.Location = new System.Drawing.Point(47, 179);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 21);
            this.lblSurname.TabIndex = 38;
            this.lblSurname.Text = "Surname : ";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(47, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 37;
            this.lblName.Text = "Name : ";
            // 
            // ctrlCardNumber
            // 
            this.ctrlCardNumber.Location = new System.Drawing.Point(257, 230);
            this.ctrlCardNumber.Name = "ctrlCardNumber";
            this.ctrlCardNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlCardNumber.Properties.Appearance.Options.UseFont = true;
            this.ctrlCardNumber.Size = new System.Drawing.Size(299, 28);
            this.ctrlCardNumber.TabIndex = 36;
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(257, 176);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlSurname.Properties.Appearance.Options.UseFont = true;
            this.ctrlSurname.Size = new System.Drawing.Size(299, 28);
            this.ctrlSurname.TabIndex = 35;
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(257, 117);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlName.Properties.Appearance.Options.UseFont = true;
            this.ctrlName.Size = new System.Drawing.Size(299, 28);
            this.ctrlName.TabIndex = 34;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 528);
            this.Controls.Add(this.ctlrCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ctrlCardNumber);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ctlrCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl Title;
        private DevExpress.XtraEditors.LabelControl lblCardNumber;
        private DevExpress.XtraEditors.LabelControl lblSurname;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit ctrlCardNumber;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlName;
    }
}