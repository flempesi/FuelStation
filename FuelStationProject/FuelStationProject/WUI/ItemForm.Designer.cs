
namespace FuelStationProject.WUI {
    partial class ItemForm {
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
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.lblDescription = new DevExpress.XtraEditors.LabelControl();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.lblCost = new DevExpress.XtraEditors.LabelControl();
            this.ctrlCode = new DevExpress.XtraEditors.TextEdit();
            this.ctrlDescription = new DevExpress.XtraEditors.TextEdit();
            this.ctrlPrice = new DevExpress.XtraEditors.SpinEdit();
            this.ctrlCost = new DevExpress.XtraEditors.SpinEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlItemType = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCode.Appearance.Options.UseFont = true;
            this.lblCode.Location = new System.Drawing.Point(50, 52);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(53, 21);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code : ";
            // 
            // lblDescription
            // 
            this.lblDescription.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblDescription.Appearance.Options.UseFont = true;
            this.lblDescription.Location = new System.Drawing.Point(50, 107);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 21);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description : ";
            // 
            // lblPrice
            // 
            this.lblPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblPrice.Appearance.Options.UseFont = true;
            this.lblPrice.Location = new System.Drawing.Point(51, 236);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 21);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price : ";
            // 
            // lblType
            // 
            this.lblType.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblType.Appearance.Options.UseFont = true;
            this.lblType.Location = new System.Drawing.Point(51, 165);
            this.lblType.Margin = new System.Windows.Forms.Padding(5);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 21);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type : ";
            // 
            // lblCost
            // 
            this.lblCost.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCost.Appearance.Options.UseFont = true;
            this.lblCost.Location = new System.Drawing.Point(50, 305);
            this.lblCost.Margin = new System.Windows.Forms.Padding(6);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(49, 21);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost : ";
            // 
            // ctrlCode
            // 
            this.ctrlCode.Location = new System.Drawing.Point(252, 45);
            this.ctrlCode.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlCode.Properties.Appearance.Options.UseFont = true;
            this.ctrlCode.Size = new System.Drawing.Size(314, 28);
            this.ctrlCode.TabIndex = 5;
            // 
            // ctrlDescription
            // 
            this.ctrlDescription.Location = new System.Drawing.Point(252, 104);
            this.ctrlDescription.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlDescription.Name = "ctrlDescription";
            this.ctrlDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlDescription.Properties.Appearance.Options.UseFont = true;
            this.ctrlDescription.Size = new System.Drawing.Size(314, 28);
            this.ctrlDescription.TabIndex = 6;
            // 
            // ctrlPrice
            // 
            this.ctrlPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlPrice.Location = new System.Drawing.Point(248, 232);
            this.ctrlPrice.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlPrice.Name = "ctrlPrice";
            this.ctrlPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlPrice.Properties.Appearance.Options.UseFont = true;
            this.ctrlPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPrice.Size = new System.Drawing.Size(318, 28);
            this.ctrlPrice.TabIndex = 8;
            // 
            // ctrlCost
            // 
            this.ctrlCost.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlCost.Location = new System.Drawing.Point(248, 301);
            this.ctrlCost.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlCost.Name = "ctrlCost";
            this.ctrlCost.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlCost.Properties.Appearance.Options.UseFont = true;
            this.ctrlCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCost.Size = new System.Drawing.Size(318, 28);
            this.ctrlCost.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(394, 391);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 44);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(517, 391);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 44);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.ctlrCancel_Click);
            // 
            // ctrlItemType
            // 
            this.ctrlItemType.Location = new System.Drawing.Point(252, 162);
            this.ctrlItemType.Name = "ctrlItemType";
            this.ctrlItemType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlItemType.Properties.Appearance.Options.UseFont = true;
            this.ctrlItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlItemType.Properties.NullText = "";
            this.ctrlItemType.Size = new System.Drawing.Size(314, 28);
            this.ctrlItemType.TabIndex = 14;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 466);
            this.Controls.Add(this.ctrlItemType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctrlCost);
            this.Controls.Add(this.ctrlPrice);
            this.Controls.Add(this.ctrlDescription);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Name = "ItemForm";
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCode;
        private DevExpress.XtraEditors.LabelControl lblDescription;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.LabelControl lblCost;
        private DevExpress.XtraEditors.TextEdit ctrlCode;
        private DevExpress.XtraEditors.TextEdit ctrlDescription;
        private DevExpress.XtraEditors.SpinEdit ctrlPrice;
        private DevExpress.XtraEditors.SpinEdit ctrlCost;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LookUpEdit ctrlItemType;
    }
}