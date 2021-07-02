
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblCustomerInfo = new DevExpress.XtraEditors.LabelControl();
            this.gridItems = new DevExpress.XtraGrid.GridControl();
            this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ctrlQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gridTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.gridViewTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditTypeLines = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDeleteLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDeleteLine = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTotalPrice = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCustomer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlDiscount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlInitialTotalprice = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditTypeLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDeleteLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlInitialTotalprice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(12, 122);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(108, 42);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Select an Item \r\nfrom the list :";
            // 
            // btnOK
            // 
            this.btnOK.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnOK.Appearance.Options.UseBackColor = true;
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Location = new System.Drawing.Point(686, 647);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 46);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(841, 647);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblCustomerInfo.Appearance.Options.UseFont = true;
            this.lblCustomerInfo.Location = new System.Drawing.Point(12, 19);
            this.lblCustomerInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(173, 21);
            this.lblCustomerInfo.TabIndex = 13;
            this.lblCustomerInfo.Text = "Customer Information :";
            // 
            // gridItems
            // 
            this.gridItems.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridItems.Location = new System.Drawing.Point(152, 67);
            this.gridItems.MainView = this.gridViewItems;
            this.gridItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridItems.Name = "gridItems";
            this.gridItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repLookUpEditType});
            this.gridItems.Size = new System.Drawing.Size(812, 199);
            this.gridItems.TabIndex = 14;
            this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
            // 
            // gridViewItems
            // 
            this.gridViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDescription,
            this.gridColumnType,
            this.gridColumnPrice,
            this.gridColumn6,
            this.gridColumnID});
            this.gridViewItems.GridControl = this.gridItems;
            this.gridViewItems.Name = "gridViewItems";
            // 
            // gridColumnDescription
            // 
            this.gridColumnDescription.Caption = "Description";
            this.gridColumnDescription.FieldName = "Description";
            this.gridColumnDescription.MinWidth = 24;
            this.gridColumnDescription.Name = "gridColumnDescription";
            this.gridColumnDescription.OptionsColumn.AllowEdit = false;
            this.gridColumnDescription.Visible = true;
            this.gridColumnDescription.VisibleIndex = 0;
            this.gridColumnDescription.Width = 94;
            // 
            // gridColumnType
            // 
            this.gridColumnType.Caption = "Type";
            this.gridColumnType.ColumnEdit = this.repLookUpEditType;
            this.gridColumnType.FieldName = "ItemType";
            this.gridColumnType.MinWidth = 24;
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.OptionsColumn.AllowEdit = false;
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 1;
            this.gridColumnType.Width = 94;
            // 
            // repLookUpEditType
            // 
            this.repLookUpEditType.AutoHeight = false;
            this.repLookUpEditType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditType.Name = "repLookUpEditType";
            this.repLookUpEditType.ReadOnly = true;
            // 
            // gridColumnPrice
            // 
            this.gridColumnPrice.Caption = "Price";
            this.gridColumnPrice.FieldName = "Price";
            this.gridColumnPrice.MinWidth = 24;
            this.gridColumnPrice.Name = "gridColumnPrice";
            this.gridColumnPrice.OptionsColumn.AllowEdit = false;
            this.gridColumnPrice.Visible = true;
            this.gridColumnPrice.VisibleIndex = 2;
            this.gridColumnPrice.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.FieldName = "Cost";
            this.gridColumn6.MinWidth = 24;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 94;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.MinWidth = 24;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Width = 94;
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlQuantity.Location = new System.Drawing.Point(264, 308);
            this.ctrlQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlQuantity.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ctrlQuantity.Size = new System.Drawing.Size(125, 24);
            this.ctrlQuantity.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(152, 308);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 21);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Quantity :";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.btnAdd.Location = new System.Drawing.Point(467, 293);
            this.btnAdd.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 49);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridTransactionLines
            // 
            this.gridTransactionLines.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridTransactionLines.Location = new System.Drawing.Point(152, 376);
            this.gridTransactionLines.MainView = this.gridViewTransactionLines;
            this.gridTransactionLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridTransactionLines.Name = "gridTransactionLines";
            this.gridTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDeleteLine,
            this.repLookUpEditTypeLines});
            this.gridTransactionLines.Size = new System.Drawing.Size(821, 199);
            this.gridTransactionLines.TabIndex = 18;
            this.gridTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTransactionLines});
            // 
            // gridViewTransactionLines
            // 
            this.gridViewTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumnDeleteLine,
            this.gridColumn7});
            this.gridViewTransactionLines.GridControl = this.gridTransactionLines;
            this.gridViewTransactionLines.Name = "gridViewTransactionLines";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Item Description";
            this.gridColumnName.FieldName = "Description";
            this.gridColumnName.MinWidth = 24;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Item Type";
            this.gridColumn1.ColumnEdit = this.repLookUpEditTypeLines;
            this.gridColumn1.FieldName = "ItemType";
            this.gridColumn1.MinWidth = 24;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 94;
            // 
            // repLookUpEditTypeLines
            // 
            this.repLookUpEditTypeLines.AutoHeight = false;
            this.repLookUpEditTypeLines.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditTypeLines.Name = "repLookUpEditTypeLines";
            this.repLookUpEditTypeLines.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Quantity";
            this.gridColumn2.FieldName = "Quantity";
            this.gridColumn2.MinWidth = 24;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Price";
            this.gridColumn3.FieldName = "ItemPrice";
            this.gridColumn3.MinWidth = 24;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Value";
            this.gridColumn4.FieldName = "Value";
            this.gridColumn4.MinWidth = 24;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ID";
            this.gridColumn5.FieldName = "ID";
            this.gridColumn5.MinWidth = 24;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 94;
            // 
            // gridColumnDeleteLine
            // 
            this.gridColumnDeleteLine.Caption = "DeleteLine";
            this.gridColumnDeleteLine.ColumnEdit = this.repDeleteLine;
            this.gridColumnDeleteLine.MinWidth = 25;
            this.gridColumnDeleteLine.Name = "gridColumnDeleteLine";
            this.gridColumnDeleteLine.Visible = true;
            this.gridColumnDeleteLine.VisibleIndex = 5;
            this.gridColumnDeleteLine.Width = 87;
            // 
            // repDeleteLine
            // 
            this.repDeleteLine.AutoHeight = false;
            this.repDeleteLine.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repDeleteLine.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("repDeleteLine.ContextImageOptions.SvgImage")));
            this.repDeleteLine.Name = "repDeleteLine";
            this.repDeleteLine.Click += new System.EventHandler(this.repDeleteLine_Click);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cost";
            this.gridColumn7.FieldName = "Cost";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 94;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 458);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 42);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Transaction \r\nLines:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 672);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 21);
            this.labelControl5.TabIndex = 20;
            this.labelControl5.Text = "Total Price : ";
            // 
            // ctrlTotalPrice
            // 
            this.ctrlTotalPrice.Location = new System.Drawing.Point(166, 669);
            this.ctrlTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlTotalPrice.Name = "ctrlTotalPrice";
            this.ctrlTotalPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlTotalPrice.Properties.Appearance.Options.UseFont = true;
            this.ctrlTotalPrice.Properties.ReadOnly = true;
            this.ctrlTotalPrice.Size = new System.Drawing.Size(159, 28);
            this.ctrlTotalPrice.TabIndex = 21;
            // 
            // ctrlCustomer
            // 
            this.ctrlCustomer.Location = new System.Drawing.Point(210, 12);
            this.ctrlCustomer.Name = "ctrlCustomer";
            this.ctrlCustomer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlCustomer.Properties.Appearance.Options.UseFont = true;
            this.ctrlCustomer.Properties.ReadOnly = true;
            this.ctrlCustomer.Size = new System.Drawing.Size(544, 28);
            this.ctrlCustomer.TabIndex = 22;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 627);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 21);
            this.labelControl2.TabIndex = 23;
            this.labelControl2.Text = "Discount : ";
            // 
            // ctrlDiscount
            // 
            this.ctrlDiscount.Location = new System.Drawing.Point(166, 624);
            this.ctrlDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlDiscount.Name = "ctrlDiscount";
            this.ctrlDiscount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlDiscount.Properties.Appearance.Options.UseFont = true;
            this.ctrlDiscount.Properties.ReadOnly = true;
            this.ctrlDiscount.Size = new System.Drawing.Size(159, 28);
            this.ctrlDiscount.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 590);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(148, 21);
            this.labelControl3.TabIndex = 25;
            this.labelControl3.Text = "Intitial Total Price : ";
            // 
            // ctrlInitialTotalprice
            // 
            this.ctrlInitialTotalprice.Location = new System.Drawing.Point(166, 583);
            this.ctrlInitialTotalprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlInitialTotalprice.Name = "ctrlInitialTotalprice";
            this.ctrlInitialTotalprice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.ctrlInitialTotalprice.Properties.Appearance.Options.UseFont = true;
            this.ctrlInitialTotalprice.Properties.ReadOnly = true;
            this.ctrlInitialTotalprice.Size = new System.Drawing.Size(159, 28);
            this.ctrlInitialTotalprice.TabIndex = 26;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 719);
            this.Controls.Add(this.ctrlInitialTotalprice);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ctrlDiscount);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ctrlCustomer);
            this.Controls.Add(this.ctrlTotalPrice);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.gridTransactionLines);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlQuantity);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelControl6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionForm";
            this.Text = "Make Transaction";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionForm_FormClosing);
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditTypeLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDeleteLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTotalPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDiscount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlInitialTotalprice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblCustomerInfo;
        private DevExpress.XtraGrid.GridControl gridItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraEditors.SpinEdit ctrlQuantity;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraGrid.GridControl gridTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTransactionLines;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDeleteLine;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDeleteLine;
        private DevExpress.XtraEditors.TextEdit ctrlCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditTypeLines;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit ctrlDiscount;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit ctrlInitialTotalprice;
    }
}