
namespace FuelStationProject.WUI {
    partial class ItemViewForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemViewForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.gridItem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnComboBox = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repLookUpEditType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repButtonSave = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repButtonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbItemType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repButtonSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repButtonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItemType)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Refresh";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 425);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Edit";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Delete";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // gridItem
            // 
            this.gridItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItem.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridItem.Location = new System.Drawing.Point(0, 25);
            this.gridItem.MainView = this.gridView1;
            this.gridItem.Margin = new System.Windows.Forms.Padding(6);
            this.gridItem.MenuManager = this.barManager1;
            this.gridItem.Name = "gridItem";
            this.gridItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbItemType,
            this.repSpinEdit,
            this.repTextEdit,
            this.repButtonSave,
            this.repButtonDelete,
            this.repLookUpEditType});
            this.gridItem.Size = new System.Drawing.Size(800, 425);
            this.gridItem.TabIndex = 9;
            this.gridItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridItem.Click += new System.EventHandler(this.gridItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumnComboBox,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumnSave,
            this.gridColumnDelete,
            this.gridColumn6});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gridItem;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Code";
            this.gridColumn1.ColumnEdit = this.repTextEdit;
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.MinWidth = 31;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 117;
            // 
            // repTextEdit
            // 
            this.repTextEdit.AutoHeight = false;
            this.repTextEdit.Name = "repTextEdit";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Description";
            this.gridColumn2.ColumnEdit = this.repTextEdit;
            this.gridColumn2.FieldName = "Description";
            this.gridColumn2.MinWidth = 31;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 117;
            // 
            // gridColumnComboBox
            // 
            this.gridColumnComboBox.Caption = "Type";
            this.gridColumnComboBox.ColumnEdit = this.repLookUpEditType;
            this.gridColumnComboBox.FieldName = "ItemType";
            this.gridColumnComboBox.MinWidth = 31;
            this.gridColumnComboBox.Name = "gridColumnComboBox";
            this.gridColumnComboBox.Visible = true;
            this.gridColumnComboBox.VisibleIndex = 2;
            this.gridColumnComboBox.Width = 117;
            // 
            // repLookUpEditType
            // 
            this.repLookUpEditType.AutoHeight = false;
            this.repLookUpEditType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repLookUpEditType.Name = "repLookUpEditType";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Price";
            this.gridColumn4.ColumnEdit = this.repSpinEdit;
            this.gridColumn4.FieldName = "Price";
            this.gridColumn4.MinWidth = 31;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 117;
            // 
            // repSpinEdit
            // 
            this.repSpinEdit.AutoHeight = false;
            this.repSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinEdit.Name = "repSpinEdit";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cost";
            this.gridColumn5.ColumnEdit = this.repSpinEdit;
            this.gridColumn5.FieldName = "Cost";
            this.gridColumn5.MinWidth = 31;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 117;
            // 
            // gridColumnSave
            // 
            this.gridColumnSave.Caption = "Save";
            this.gridColumnSave.ColumnEdit = this.repButtonSave;
            this.gridColumnSave.MinWidth = 25;
            this.gridColumnSave.Name = "gridColumnSave";
            this.gridColumnSave.Visible = true;
            this.gridColumnSave.VisibleIndex = 5;
            this.gridColumnSave.Width = 94;
            // 
            // repButtonSave
            // 
            this.repButtonSave.AutoHeight = false;
            this.repButtonSave.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repButtonSave.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("repButtonSave.ContextImageOptions.SvgImage")));
            this.repButtonSave.Name = "repButtonSave";
            this.repButtonSave.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repButtonSave.Click += new System.EventHandler(this.repSaveButtonEdit_Click);
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.Caption = "Delete";
            this.gridColumnDelete.ColumnEdit = this.repButtonDelete;
            this.gridColumnDelete.MinWidth = 25;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 6;
            this.gridColumnDelete.Width = 94;
            // 
            // repButtonDelete
            // 
            this.repButtonDelete.AutoHeight = false;
            this.repButtonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repButtonDelete.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("repButtonDelete.ContextImageOptions.SvgImage")));
            this.repButtonDelete.Name = "repButtonDelete";
            this.repButtonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repButtonDelete.Click += new System.EventHandler(this.repdeleteButtonEdit_Click);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "ID";
            this.gridColumn6.FieldName = "ID";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 94;
            // 
            // cmbItemType
            // 
            this.cmbItemType.AutoHeight = false;
            this.cmbItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // ItemViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridItem);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ItemViewForm";
            this.Text = "View Items";
            this.Load += new System.EventHandler(this.ItemViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repLookUpEditType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repButtonSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repButtonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItemType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.GridControl gridItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmbItemType;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repButtonSave;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repButtonDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repLookUpEditType;
    }
}