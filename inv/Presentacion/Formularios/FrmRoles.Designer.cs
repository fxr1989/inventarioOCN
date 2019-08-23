namespace Presentacion.Formularios
{
    partial class FrmRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRoles));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.gRoles = new DevExpress.XtraGrid.GridControl();
            this.gvRoles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcRolAccesoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPermiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAgregar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEliminar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Controls.Add(this.gRoles);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1263, 712);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnGuardar);
            this.panelControl1.Controls.Add(this.btnAgregar);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1239, 69);
            this.panelControl1.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(595, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 38);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Appearance.Options.UseFont = true;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(477, 17);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gRoles
            // 
            this.gRoles.Location = new System.Drawing.Point(12, 85);
            this.gRoles.MainView = this.gvRoles;
            this.gRoles.Name = "gRoles";
            this.gRoles.Size = new System.Drawing.Size(1239, 615);
            this.gRoles.TabIndex = 4;
            this.gRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoles});
            // 
            // gvRoles
            // 
            this.gvRoles.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvRoles.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvRoles.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvRoles.Appearance.Row.Options.UseFont = true;
            this.gvRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcRolAccesoID,
            this.gcRol,
            this.gcPermiso,
            this.gcVer,
            this.gcAgregar,
            this.gcEditar,
            this.gcEliminar});
            this.gvRoles.GridControl = this.gRoles;
            this.gvRoles.GroupCount = 1;
            this.gvRoles.Name = "gvRoles";
            this.gvRoles.OptionsView.ShowAutoFilterRow = true;
            this.gvRoles.OptionsView.ShowGroupPanel = false;
            this.gvRoles.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcRol, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gcRolAccesoID
            // 
            this.gcRolAccesoID.Caption = "RolAccesoID";
            this.gcRolAccesoID.FieldName = "RolAccesoID";
            this.gcRolAccesoID.Name = "gcRolAccesoID";
            // 
            // gcRol
            // 
            this.gcRol.Caption = "Rol";
            this.gcRol.FieldName = "Rol";
            this.gcRol.Name = "gcRol";
            this.gcRol.Visible = true;
            this.gcRol.VisibleIndex = 0;
            // 
            // gcPermiso
            // 
            this.gcPermiso.Caption = "Permiso";
            this.gcPermiso.FieldName = "Permiso";
            this.gcPermiso.Name = "gcPermiso";
            this.gcPermiso.Visible = true;
            this.gcPermiso.VisibleIndex = 0;
            // 
            // gcVer
            // 
            this.gcVer.Caption = "Ver";
            this.gcVer.FieldName = "Ver";
            this.gcVer.Name = "gcVer";
            this.gcVer.Visible = true;
            this.gcVer.VisibleIndex = 1;
            // 
            // gcAgregar
            // 
            this.gcAgregar.Caption = "Agregar";
            this.gcAgregar.FieldName = "Agregar";
            this.gcAgregar.Name = "gcAgregar";
            this.gcAgregar.Visible = true;
            this.gcAgregar.VisibleIndex = 2;
            // 
            // gcEditar
            // 
            this.gcEditar.Caption = "Editar";
            this.gcEditar.FieldName = "Editar";
            this.gcEditar.Name = "gcEditar";
            this.gcEditar.Visible = true;
            this.gcEditar.VisibleIndex = 3;
            // 
            // gcEliminar
            // 
            this.gcEliminar.Caption = "Eliminar";
            this.gcEliminar.FieldName = "Eliminar";
            this.gcEliminar.Name = "gcEliminar";
            this.gcEliminar.Visible = true;
            this.gcEliminar.VisibleIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1263, 712);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gRoles;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1243, 619);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1243, 73);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 712);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gRoles;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRoles;
        private DevExpress.XtraGrid.Columns.GridColumn gcRolAccesoID;
        private DevExpress.XtraGrid.Columns.GridColumn gcRol;
        private DevExpress.XtraGrid.Columns.GridColumn gcPermiso;
        private DevExpress.XtraGrid.Columns.GridColumn gcAgregar;
        private DevExpress.XtraGrid.Columns.GridColumn gcEditar;
        private DevExpress.XtraGrid.Columns.GridColumn gcEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn gcVer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}