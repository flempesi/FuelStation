
namespace FuelStationProject.WUI {
    partial class EmployeeViewForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeViewForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.btnrefresh = new DevExpress.XtraBars.Bar();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.gridEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDateTime = new DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit();
            this.gridColumnSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSpinEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.gridColumnSave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repSaveButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repDeleteButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSaveButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDeleteButtonEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.btnrefresh});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnEdit,
            this.btnDelete,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.btnrefresh;
            this.barManager1.MaxItemId = 3;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BarName = "Main menu";
            this.btnrefresh.DockCol = 0;
            this.btnrefresh.DockRow = 0;
            this.btnrefresh.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.btnrefresh.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.btnrefresh.OptionsBar.MultiLine = true;
            this.btnrefresh.OptionsBar.UseWholeRow = true;
            this.btnrefresh.Text = "Main menu";
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 0;
            this.btnEdit.Name = "btnEdit";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Refresh";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(700, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(700, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(700, 25);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 425);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 1;
            this.btnDelete.Name = "btnDelete";
            // 
            // gridEmployee
            // 
            this.gridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEmployee.Location = new System.Drawing.Point(0, 25);
            this.gridEmployee.MainView = this.gridView1;
            this.gridEmployee.MenuManager = this.barManager1;
            this.gridEmployee.Name = "gridEmployee";
            this.gridEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDateTime,
            this.repTextEdit,
            this.repSpinEdit,
            this.repSaveButtonEdit,
            this.repDeleteButtonEdit,
            this.repDate});
            this.gridEmployee.Size = new System.Drawing.Size(700, 425);
            this.gridEmployee.TabIndex = 4;
            this.gridEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnSurname,
            this.gridColumnDateStart,
            this.gridColumnDateEnd,
            this.gridColumnSalary,
            this.gridColumnSave,
            this.gridColumnDelete,
            this.gridColumnID});
            this.gridView1.GridControl = this.gridEmployee;
            this.gridView1.Name = "gridView1";
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.ColumnEdit = this.repTextEdit;
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.MinWidth = 22;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 82;
            // 
            // repTextEdit
            // 
            this.repTextEdit.AutoHeight = false;
            this.repTextEdit.Name = "repTextEdit";
            // 
            // gridColumnSurname
            // 
            this.gridColumnSurname.Caption = "Surname";
            this.gridColumnSurname.ColumnEdit = this.repTextEdit;
            this.gridColumnSurname.FieldName = "Surname";
            this.gridColumnSurname.MinWidth = 22;
            this.gridColumnSurname.Name = "gridColumnSurname";
            this.gridColumnSurname.Visible = true;
            this.gridColumnSurname.VisibleIndex = 1;
            this.gridColumnSurname.Width = 82;
            // 
            // gridColumnDateStart
            // 
            this.gridColumnDateStart.Caption = "Date Start";
            this.gridColumnDateStart.ColumnEdit = this.repDate;
            this.gridColumnDateStart.DisplayFormat.FormatString = "d";
            this.gridColumnDateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDateStart.FieldName = "DateStart";
            this.gridColumnDateStart.MinWidth = 22;
            this.gridColumnDateStart.Name = "gridColumnDateStart";
            this.gridColumnDateStart.Visible = true;
            this.gridColumnDateStart.VisibleIndex = 2;
            this.gridColumnDateStart.Width = 82;
            // 
            // repDate
            // 
            this.repDate.AutoHeight = false;
            this.repDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDate.Name = "repDate";
            // 
            // gridColumnDateEnd
            // 
            this.gridColumnDateEnd.Caption = "Date End";
            this.gridColumnDateEnd.ColumnEdit = this.repDate;
            this.gridColumnDateEnd.DisplayFormat.FormatString = "d";
            this.gridColumnDateEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDateEnd.FieldName = "DateEnd";
            this.gridColumnDateEnd.MinWidth = 22;
            this.gridColumnDateEnd.Name = "gridColumnDateEnd";
            this.gridColumnDateEnd.Visible = true;
            this.gridColumnDateEnd.VisibleIndex = 3;
            this.gridColumnDateEnd.Width = 82;
            // 
            // repDateTime
            // 
            this.repDateTime.AutoHeight = false;
            this.repDateTime.BeepOnError = false;
            this.repDateTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repDateTime.EditFormat.FormatString = "d";
            this.repDateTime.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repDateTime.MaskSettings.Set("mask", "G");
            this.repDateTime.Name = "repDateTime";
            // 
            // gridColumnSalary
            // 
            this.gridColumnSalary.Caption = "Salary";
            this.gridColumnSalary.ColumnEdit = this.repSpinEdit;
            this.gridColumnSalary.FieldName = "Salary";
            this.gridColumnSalary.MinWidth = 22;
            this.gridColumnSalary.Name = "gridColumnSalary";
            this.gridColumnSalary.Visible = true;
            this.gridColumnSalary.VisibleIndex = 4;
            this.gridColumnSalary.Width = 82;
            // 
            // repSpinEdit
            // 
            this.repSpinEdit.AutoHeight = false;
            this.repSpinEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repSpinEdit.Name = "repSpinEdit";
            // 
            // gridColumnSave
            // 
            this.gridColumnSave.Caption = "Save";
            this.gridColumnSave.ColumnEdit = this.repSaveButtonEdit;
            this.gridColumnSave.FieldName = "Save";
            this.gridColumnSave.MinWidth = 25;
            this.gridColumnSave.Name = "gridColumnSave";
            this.gridColumnSave.Visible = true;
            this.gridColumnSave.VisibleIndex = 5;
            this.gridColumnSave.Width = 66;
            // 
            // repSaveButtonEdit
            // 
            this.repSaveButtonEdit.AutoHeight = false;
            this.repSaveButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repSaveButtonEdit.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("repSaveButtonEdit.ContextImageOptions.SvgImage")));
            this.repSaveButtonEdit.Name = "repSaveButtonEdit";
            this.repSaveButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repSaveButtonEdit.Click += new System.EventHandler(this.repSaveButtonEdit_Click);
            // 
            // gridColumnDelete
            // 
            this.gridColumnDelete.Caption = "Delete";
            this.gridColumnDelete.ColumnEdit = this.repDeleteButtonEdit;
            this.gridColumnDelete.MinWidth = 25;
            this.gridColumnDelete.Name = "gridColumnDelete";
            this.gridColumnDelete.Visible = true;
            this.gridColumnDelete.VisibleIndex = 6;
            this.gridColumnDelete.Width = 66;
            // 
            // repDeleteButtonEdit
            // 
            this.repDeleteButtonEdit.AutoHeight = false;
            this.repDeleteButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repDeleteButtonEdit.ContextImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("repDeleteButtonEdit.ContextImageOptions.SvgImage")));
            this.repDeleteButtonEdit.Name = "repDeleteButtonEdit";
            this.repDeleteButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repDeleteButtonEdit.Click += new System.EventHandler(this.repdeleteButtonEdit_Click);
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.MinWidth = 25;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Width = 94;
            // 
            // EmployeeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.gridEmployee);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "EmployeeViewForm";
            this.Text = "EmployeeViewForm";
            this.Load += new System.EventHandler(this.EmployeeViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDateTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSpinEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repSaveButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDeleteButtonEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar btnrefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gridEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateStart;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateTimeOffsetEdit repDateTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSurname;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSalary;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repSpinEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSave;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repSaveButtonEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDeleteButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repDate;
    }
}