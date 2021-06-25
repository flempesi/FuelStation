
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
            this.ctrlType = new DevExpress.XtraEditors.DropDownButton();
            this.ctrlPrice = new DevExpress.XtraEditors.SpinEdit();
            this.ctrlCost = new DevExpress.XtraEditors.SpinEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(50, 52);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(29, 16);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Code";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(50, 107);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(51, 236);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(28, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(51, 165);
            this.lblType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(28, 16);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            // 
            // lblCost
            // 
            this.lblCost.Location = new System.Drawing.Point(50, 305);
            this.lblCost.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(25, 16);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Cost";
            // 
            // ctrlCode
            // 
            this.ctrlCode.Location = new System.Drawing.Point(252, 45);
            this.ctrlCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(314, 22);
            this.ctrlCode.TabIndex = 5;
            // 
            // ctrlDescription
            // 
            this.ctrlDescription.Location = new System.Drawing.Point(252, 104);
            this.ctrlDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlDescription.Name = "ctrlDescription";
            this.ctrlDescription.Size = new System.Drawing.Size(314, 22);
            this.ctrlDescription.TabIndex = 6;
            // 
            // ctrlType
            // 
            this.ctrlType.Location = new System.Drawing.Point(252, 165);
            this.ctrlType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlType.Name = "ctrlType";
            this.ctrlType.Size = new System.Drawing.Size(314, 29);
            this.ctrlType.TabIndex = 7;
            this.ctrlType.Text = "dropDownButton1";
            // 
            // ctrlPrice
            // 
            this.ctrlPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.ctrlPrice.Location = new System.Drawing.Point(248, 243);
            this.ctrlPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrlPrice.Name = "ctrlPrice";
            this.ctrlPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlPrice.Size = new System.Drawing.Size(318, 24);
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
            this.ctrlCost.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ctrlCost.Name = "ctrlCost";
            this.ctrlCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlCost.Size = new System.Drawing.Size(318, 24);
            this.ctrlCost.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(321, 377);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(106, 41);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(448, 374);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 44);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 463);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctrlCost);
            this.Controls.Add(this.ctrlPrice);
            this.Controls.Add(this.ctrlType);
            this.Controls.Add(this.ctrlDescription);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Name = "ItemForm";
            this.Text = "Add Item";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost.Properties)).EndInit();
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
        private DevExpress.XtraEditors.DropDownButton ctrlType;
        private DevExpress.XtraEditors.SpinEdit ctrlPrice;
        private DevExpress.XtraEditors.SpinEdit ctrlCost;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}