
namespace FuelStationProject.WUI {
    partial class TransactionForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.lblCustomerInfo = new DevExpress.XtraEditors.LabelControl();
            this.gridItems = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctrlQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTotalPrice = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 24);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Customer Card Number";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(13, 110);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(136, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Select an Item from the list :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(540, 541);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 33);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(675, 538);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(127, 37);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Cancel";
            // 
            // ctrlCardNumber
            // 
            this.ctrlCardNumber.Location = new System.Drawing.Point(174, 20);
            this.ctrlCardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCardNumber.Name = "ctrlCardNumber";
            this.ctrlCardNumber.Size = new System.Drawing.Size(467, 20);
            this.ctrlCardNumber.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(675, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.Location = new System.Drawing.Point(10, 58);
            this.lblCustomerInfo.Margin = new System.Windows.Forms.Padding(4);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(105, 13);
            this.lblCustomerInfo.TabIndex = 13;
            this.lblCustomerInfo.Text = "Customer Information";
            // 
            // gridItems
            // 
            this.gridItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridItems.Location = new System.Drawing.Point(162, 110);
            this.gridItems.MainView = this.gridView2;
            this.gridItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(664, 162);
            this.gridItems.TabIndex = 14;
            this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDescription,
            this.gridColumnType,
            this.gridColumnPrice,
            this.gridColumn6,
            this.gridColumnID});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.gridItems;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "Description";
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.MinWidth = 21;
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.OptionsColumn.AllowEdit = false;
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 0;
            this.gridColumnDescription.Width = 81;
            // 
            // gridColumnType
            // 
            this.gridColumnType.Caption = "Type";
            this.gridColumnType.FieldName = "ItemType";
            this.gridColumnType.MinWidth = 21;
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.OptionsColumn.AllowEdit = false;
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 1;
            this.gridColumnType.Width = 81;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.Caption = "Price";
            this.gridColumnPrice.FieldName = "Price";
            this.gridColumnPrice.MinWidth = 21;
            this.gridColumnPrice.Name = "gridColumnPrice";
            this.gridColumnPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 2;
            this.gridColumnPrice.Width = 81;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "Cost";
            this.gridColumn6.MinWidth = 21;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 81;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.MinWidth = 21;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Width = 81;
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlQuantity.Location = new System.Drawing.Point(10, 179);
            this.ctrlQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlQuantity.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ctrlQuantity.Size = new System.Drawing.Size(107, 20);
            this.ctrlQuantity.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 158);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Quantity :";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(10, 233);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 40);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridTransactionLines
            // 
            this.gridTransactionLines.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridTransactionLines.Location = new System.Drawing.Point(182, 327);
            this.gridTransactionLines.MainView = this.gridView1;
            this.gridTransactionLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridTransactionLines.Name = "gridTransactionLines";
            this.gridTransactionLines.Size = new System.Drawing.Size(652, 162);
            this.gridTransactionLines.TabIndex = 18;
            this.gridTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridTransactionLines;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Item";
            this.gridColumnName.FieldName = "Item";
            this.gridColumnName.MinWidth = 21;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 81;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ItemType";
            this.gridColumn1.FieldName = "ItemType";
            this.gridColumn1.MinWidth = 21;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 81;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Quantity";
            this.gridColumn2.FieldName = "Quantity";
            this.gridColumn2.MinWidth = 21;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 81;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Price";
            this.gridColumn3.FieldName = "ItemPrice";
            this.gridColumn3.MinWidth = 21;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 81;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Value";
            this.gridColumn4.FieldName = "Value";
            this.gridColumn4.MinWidth = 21;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 81;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.FieldName = "ID";
            this.gridColumn5.MinWidth = 21;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 81;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 327);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "transaction Lines:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(22, 550);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(47, 13);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "TotalPrice";
            // 
            // ctrlTotalPrice
            // 
            this.ctrlTotalPrice.Location = new System.Drawing.Point(130, 548);
            this.ctrlTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlTotalPrice.Name = "ctrlTotalPrice";
            this.ctrlTotalPrice.Size = new System.Drawing.Size(107, 20);
            this.ctrlTotalPrice.TabIndex = 21;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 611);
            this.Controls.Add(this.ctrlTotalPrice);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridTransactionLines);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ctrlCardNumber);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.TextEdit ctrlCardNumber;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl lblCustomerInfo;
        private DevExpress.XtraGrid.GridControl gridItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraEditors.SpinEdit ctrlQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit ctrlTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}