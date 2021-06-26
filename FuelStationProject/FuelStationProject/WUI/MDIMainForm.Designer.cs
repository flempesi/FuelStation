
namespace FuelStationProject.WUI {
    partial class MDIMainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIMainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewTransaction = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewLedger = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(43, 46, 43, 46);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnExit,
            this.btnAddCustomer,
            this.btnViewCustomer,
            this.btnAddEmployee,
            this.btnViewEmployee,
            this.btnAddItem,
            this.btnViewItem,
            this.btnAddTransaction,
            this.btnViewTransaction,
            this.btnViewLedger});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 481;
            this.ribbonControl1.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6,
            this.ribbonPage7});
            this.ribbonControl1.Size = new System.Drawing.Size(933, 193);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 1;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Caption = "Add";
            this.btnAddCustomer.Id = 2;
            this.btnAddCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.Image")));
            this.btnAddCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddCustomer.ImageOptions.LargeImage")));
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddCustomer_ItemClick);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Caption = "View";
            this.btnViewCustomer.Id = 3;
            this.btnViewCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewCustomer.ImageOptions.Image")));
            this.btnViewCustomer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewCustomer.ImageOptions.LargeImage")));
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewCustomer_ItemClick);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Caption = "Add";
            this.btnAddEmployee.Id = 4;
            this.btnAddEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ImageOptions.Image")));
            this.btnAddEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.ImageOptions.LargeImage")));
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddEmployee_ItemClick);
            // 
            // btnViewEmployee
            // 
            this.btnViewEmployee.Caption = "View";
            this.btnViewEmployee.Id = 5;
            this.btnViewEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewEmployee.ImageOptions.Image")));
            this.btnViewEmployee.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewEmployee.ImageOptions.LargeImage")));
            this.btnViewEmployee.Name = "btnViewEmployee";
            this.btnViewEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewEmployee_ItemClick);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Caption = "Add";
            this.btnAddItem.Id = 6;
            this.btnAddItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.ImageOptions.Image")));
            this.btnAddItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddItem.ImageOptions.LargeImage")));
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddItem_ItemClick);
            // 
            // btnViewItem
            // 
            this.btnViewItem.Caption = "View";
            this.btnViewItem.Id = 7;
            this.btnViewItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewItem.ImageOptions.Image")));
            this.btnViewItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewItem.ImageOptions.LargeImage")));
            this.btnViewItem.Name = "btnViewItem";
            this.btnViewItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewItem_ItemClick);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Caption = "Add";
            this.btnAddTransaction.Id = 8;
            this.btnAddTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTransaction.ImageOptions.Image")));
            this.btnAddTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddTransaction.ImageOptions.LargeImage")));
            this.btnAddTransaction.Name = "btnAddTransaction";
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.Caption = "View";
            this.btnViewTransaction.Id = 9;
            this.btnViewTransaction.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewTransaction.ImageOptions.Image")));
            this.btnViewTransaction.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewTransaction.ImageOptions.LargeImage")));
            this.btnViewTransaction.Name = "btnViewTransaction";
            // 
            // btnViewLedger
            // 
            this.btnViewLedger.Caption = "View";
            this.btnViewLedger.Id = 10;
            this.btnViewLedger.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewLedger.ImageOptions.Image")));
            this.btnViewLedger.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnViewLedger.ImageOptions.LargeImage")));
            this.btnViewLedger.Name = "btnViewLedger";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "File";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Customers";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAddCustomer);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnViewCustomer);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Employees";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnAddEmployee);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnViewEmployee);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Items";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnAddItem);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnViewItem);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Transactions";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnAddTransaction);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnViewTransaction);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "Ledger";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnViewLedger);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 524);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(933, 30);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // MDIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MDIMainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Fuel Station";
            this.Load += new System.EventHandler(this.MDIMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnAddCustomer;
        private DevExpress.XtraBars.BarButtonItem btnViewCustomer;
        private DevExpress.XtraBars.BarButtonItem btnAddEmployee;
        private DevExpress.XtraBars.BarButtonItem btnViewEmployee;
        private DevExpress.XtraBars.BarButtonItem btnAddItem;
        private DevExpress.XtraBars.BarButtonItem btnViewItem;
        private DevExpress.XtraBars.BarButtonItem btnAddTransaction;
        private DevExpress.XtraBars.BarButtonItem btnViewTransaction;
        private DevExpress.XtraBars.BarButtonItem btnViewLedger;
    }
}