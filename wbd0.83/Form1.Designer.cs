namespace wbd0._83
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nawigacja = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.pracownicy = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tableView = new DevExpress.XtraTab.XtraTabControl();
            this.pocztyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filharmonieDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filharmonieDataSet = new wbd0._83.filharmonieDataSet();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            ((System.ComponentModel.ISupportInitialize)(this.nawigacja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocztyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filharmonieDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filharmonieDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nawigacja
            // 
            this.nawigacja.ActiveGroup = this.navBarGroup1;
            this.nawigacja.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5});
            this.nawigacja.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.pracownicy,
            this.navBarItem2});
            this.nawigacja.Location = new System.Drawing.Point(0, 49);
            this.nawigacja.Name = "nawigacja";
            this.nawigacja.OptionsNavPane.ExpandedWidth = 189;
            this.nawigacja.Size = new System.Drawing.Size(189, 527);
            this.nawigacja.TabIndex = 0;
            this.nawigacja.Text = "navBarControl1";
            this.nawigacja.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Filharmonie";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.pracownicy),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // pracownicy
            // 
            this.pracownicy.Caption = "Pracownicy";
            this.pracownicy.Name = "pracownicy";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "navBarItem2";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "navBarGroup2";
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "navBarGroup3";
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "navBarGroup4";
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "navBarGroup5";
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl1.Size = new System.Drawing.Size(835, 52);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Dodaj";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Usun";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Edytuj";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ogolne";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // tableView
            // 
            this.tableView.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.tableView.Location = new System.Drawing.Point(195, 49);
            this.tableView.Name = "tableView";
            this.tableView.CloseButtonClick += tableView_CloseButtonClick;
            this.tableView.Size = new System.Drawing.Size(639, 526);
            this.tableView.TabIndex = 1;
            // 
            // pocztyBindingSource
            // 
            this.pocztyBindingSource.DataMember = "Poczty";
            this.pocztyBindingSource.DataSource = this.filharmonieDataSetBindingSource;
            // 
            // filharmonieDataSetBindingSource
            // 
            this.filharmonieDataSetBindingSource.DataSource = this.filharmonieDataSet;
            this.filharmonieDataSetBindingSource.Position = 0;
            // 
            // filharmonieDataSet
            // 
            this.filharmonieDataSet.DataSetName = "filharmonieDataSet";
            this.filharmonieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 588);
            this.Controls.Add(this.tableView);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.nawigacja);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nawigacja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pocztyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filharmonieDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filharmonieDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DevExpress.XtraNavBar.NavBarControl nawigacja;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraNavBar.NavBarItem pracownicy;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraTab.XtraTabControl tableView;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource pocztyBindingSource;
        private System.Windows.Forms.BindingSource filharmonieDataSetBindingSource;
        private filharmonieDataSet filharmonieDataSet;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;

    }
}

