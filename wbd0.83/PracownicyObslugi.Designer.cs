namespace wbd0._83
{
    partial class PracownicyObslugi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pracownicyobslugiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filharmonieDataSet = new wbd0._83.filharmonieDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpracownik_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwyposazenie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluwagi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstanowisko_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pracownicyobslugiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.layoutViewField_colpracownik_id = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colwyposazenie = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_coluwagi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewField_colstanowisko_id = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyobslugiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filharmonieDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyobslugiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colpracownik_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colwyposazenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coluwagi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colstanowisko_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pracownicyobslugiBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(748, 399);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.layoutView1,
            this.gridView2});
            // 
            // pracownicyobslugiBindingSource
            // 
            this.pracownicyobslugiBindingSource.DataMember = "pracownicy_obslugi";
            this.pracownicyobslugiBindingSource.DataSource = this.filharmonieDataSet;
            // 
            // filharmonieDataSet
            // 
            this.filharmonieDataSet.DataSetName = "filharmonieDataSet";
            this.filharmonieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpracownik_id,
            this.colwyposazenie,
            this.coluwagi,
            this.colstanowisko_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colpracownik_id
            // 
            this.colpracownik_id.FieldName = "pracownik_id";
            this.colpracownik_id.Name = "colpracownik_id";
            this.colpracownik_id.Visible = true;
            this.colpracownik_id.VisibleIndex = 0;
            // 
            // colwyposazenie
            // 
            this.colwyposazenie.FieldName = "wyposazenie";
            this.colwyposazenie.Name = "colwyposazenie";
            this.colwyposazenie.Visible = true;
            this.colwyposazenie.VisibleIndex = 1;
            // 
            // coluwagi
            // 
            this.coluwagi.FieldName = "uwagi";
            this.coluwagi.Name = "coluwagi";
            this.coluwagi.Visible = true;
            this.coluwagi.VisibleIndex = 2;
            // 
            // colstanowisko_id
            // 
            this.colstanowisko_id.FieldName = "stanowisko_id";
            this.colstanowisko_id.Name = "colstanowisko_id";
            this.colstanowisko_id.Visible = true;
            this.colstanowisko_id.VisibleIndex = 3;
            // 
            // pracownicyobslugiBindingSource1
            // 
            this.pracownicyobslugiBindingSource1.DataMember = "pracownicy_obslugi";
            this.pracownicyobslugiBindingSource1.DataSource = this.filharmonieDataSet;
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.FieldName = "pracownik_id";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_colpracownik_id;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.FieldName = "wyposazenie";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_colwyposazenie;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.FieldName = "uwagi";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_coluwagi;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.FieldName = "stanowisko_id";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_colstanowisko_id;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colpracownik_id,
            this.layoutViewField_colwyposazenie,
            this.layoutViewField_coluwagi,
            this.layoutViewField_colstanowisko_id});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // layoutViewField_colpracownik_id
            // 
            this.layoutViewField_colpracownik_id.EditorPreferredWidth = 124;
            this.layoutViewField_colpracownik_id.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colpracownik_id.Name = "layoutViewField_colpracownik_id";
            this.layoutViewField_colpracownik_id.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colpracownik_id.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutViewField_colwyposazenie
            // 
            this.layoutViewField_colwyposazenie.EditorPreferredWidth = 124;
            this.layoutViewField_colwyposazenie.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colwyposazenie.Name = "layoutViewField_colwyposazenie";
            this.layoutViewField_colwyposazenie.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colwyposazenie.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutViewField_coluwagi
            // 
            this.layoutViewField_coluwagi.EditorPreferredWidth = 124;
            this.layoutViewField_coluwagi.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_coluwagi.Name = "layoutViewField_coluwagi";
            this.layoutViewField_coluwagi.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_coluwagi.TextSize = new System.Drawing.Size(71, 13);
            // 
            // layoutViewField_colstanowisko_id
            // 
            this.layoutViewField_colstanowisko_id.EditorPreferredWidth = 124;
            this.layoutViewField_colstanowisko_id.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colstanowisko_id.Name = "layoutViewField_colstanowisko_id";
            this.layoutViewField_colstanowisko_id.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colstanowisko_id.TextSize = new System.Drawing.Size(71, 13);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "pracownik_id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "wyposazenie";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "uwagi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "stanowisko_id";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // PracownicyObslugi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "PracownicyObslugi";
            this.Size = new System.Drawing.Size(748, 399);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyobslugiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filharmonieDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyobslugiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colpracownik_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colwyposazenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coluwagi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colstanowisko_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource pracownicyobslugiBindingSource;
        private filharmonieDataSet filharmonieDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colpracownik_id;
        private DevExpress.XtraGrid.Columns.GridColumn colwyposazenie;
        private DevExpress.XtraGrid.Columns.GridColumn coluwagi;
        private DevExpress.XtraGrid.Columns.GridColumn colstanowisko_id;
        private System.Windows.Forms.BindingSource pracownicyobslugiBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colpracownik_id;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colwyposazenie;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coluwagi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colstanowisko_id;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
