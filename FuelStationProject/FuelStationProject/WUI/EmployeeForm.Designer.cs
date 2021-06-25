
namespace FuelStationProject.WUI {
    partial class EmployeeForm {
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
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.lblSalary = new DevExpress.XtraEditors.LabelControl();
            this.lblDateTo = new DevExpress.XtraEditors.LabelControl();
            this.lblDatefrom = new DevExpress.XtraEditors.LabelControl();
            this.ctrlDateEnd = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.ctrlDateStart = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.Title = new DevExpress.XtraEditors.LabelControl();
            this.lblSurname = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateStart.Properties)).BeginInit();
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
            this.ctlrCancel.Location = new System.Drawing.Point(791, 546);
            this.ctlrCancel.Name = "ctlrCancel";
            this.ctlrCancel.Size = new System.Drawing.Size(123, 40);
            this.ctlrCancel.TabIndex = 46;
            this.ctlrCancel.Text = "Cancel";
            this.ctlrCancel.Click += new System.EventHandler(this.ctlrCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOK.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Appearance.Options.UseForeColor = true;
            this.btnOK.Location = new System.Drawing.Point(629, 546);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(123, 40);
            this.btnOK.TabIndex = 45;
            this.btnOK.Text = "OK";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(282, 393);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.spinEdit1.Properties.Appearance.Options.UseFont = true;
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(299, 28);
            this.spinEdit1.TabIndex = 44;
            // 
            // lblSalary
            // 
            this.lblSalary.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSalary.Appearance.Options.UseFont = true;
            this.lblSalary.Location = new System.Drawing.Point(72, 396);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(61, 21);
            this.lblSalary.TabIndex = 43;
            this.lblSalary.Text = "Salary : ";
            // 
            // lblDateTo
            // 
            this.lblDateTo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDateTo.Appearance.Options.UseFont = true;
            this.lblDateTo.Location = new System.Drawing.Point(72, 333);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(76, 21);
            this.lblDateTo.TabIndex = 42;
            this.lblDateTo.Text = "Date To : ";
            // 
            // lblDatefrom
            // 
            this.lblDatefrom.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDatefrom.Appearance.Options.UseFont = true;
            this.lblDatefrom.Location = new System.Drawing.Point(72, 273);
            this.lblDatefrom.Name = "lblDatefrom";
            this.lblDatefrom.Size = new System.Drawing.Size(90, 21);
            this.lblDatefrom.TabIndex = 41;
            this.lblDatefrom.Text = "Date From :";
            // 
            // ctrlDateEnd
            // 
            this.ctrlDateEnd.EditValue = null;
            this.ctrlDateEnd.Location = new System.Drawing.Point(282, 330);
            this.ctrlDateEnd.Name = "ctrlDateEnd";
            this.ctrlDateEnd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlDateEnd.Properties.Appearance.Options.UseFont = true;
            this.ctrlDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateEnd.Size = new System.Drawing.Size(299, 28);
            this.ctrlDateEnd.TabIndex = 40;
            // 
            // ctrlDateStart
            // 
            this.ctrlDateStart.EditValue = null;
            this.ctrlDateStart.Location = new System.Drawing.Point(282, 266);
            this.ctrlDateStart.Name = "ctrlDateStart";
            this.ctrlDateStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlDateStart.Properties.Appearance.Options.UseFont = true;
            this.ctrlDateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlDateStart.Size = new System.Drawing.Size(299, 28);
            this.ctrlDateStart.TabIndex = 39;
            // 
            // Title
            // 
            this.Title.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Title.Appearance.Options.UseFont = true;
            this.Title.Location = new System.Drawing.Point(72, 76);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(140, 24);
            this.Title.TabIndex = 38;
            this.Title.Text = "Add Employee :";
            // 
            // lblSurname
            // 
            this.lblSurname.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblSurname.Appearance.Options.UseFont = true;
            this.lblSurname.Location = new System.Drawing.Point(72, 208);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(81, 21);
            this.lblSurname.TabIndex = 37;
            this.lblSurname.Text = "Surname : ";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(72, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 21);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Name : ";
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(282, 205);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlSurname.Properties.Appearance.Options.UseFont = true;
            this.ctrlSurname.Size = new System.Drawing.Size(299, 28);
            this.ctrlSurname.TabIndex = 35;
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(282, 146);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlName.Properties.Appearance.Options.UseFont = true;
            this.ctrlName.Size = new System.Drawing.Size(299, 28);
            this.ctrlName.TabIndex = 34;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 663);
            this.Controls.Add(this.ctlrCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDatefrom);
            this.Controls.Add(this.ctrlDateEnd);
            this.Controls.Add(this.ctrlDateStart);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.ctrlName);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton ctlrCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.LabelControl lblSalary;
        private DevExpress.XtraEditors.LabelControl lblDateTo;
        private DevExpress.XtraEditors.LabelControl lblDatefrom;
        private DevExpress.XtraEditors.DateTimeOffsetEdit ctrlDateEnd;
        private DevExpress.XtraEditors.DateTimeOffsetEdit ctrlDateStart;
        private DevExpress.XtraEditors.LabelControl Title;
        private DevExpress.XtraEditors.LabelControl lblSurname;
        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.TextEdit ctrlName;
    }
}