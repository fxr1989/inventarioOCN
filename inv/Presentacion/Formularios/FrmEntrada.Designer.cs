namespace Presentacion.Formularios
{
    partial class FrmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrada));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gLinea = new DevExpress.XtraGrid.GridControl();
            this.gvLinea = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCboProductos = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcUbicacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCboUbicacion = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtCantidad = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcMoneda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCboMoneda = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtPrecioUnitario = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDonacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gcTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gbDatosEntrada = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGuardarEntrada = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.deFechaEntrada = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCboProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCboUbicacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCboMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosEntrada)).BeginInit();
            this.gbDatosEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrada.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gLinea);
            this.layoutControl1.Controls.Add(this.gbDatosEntrada);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(965, 769);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gLinea
            // 
            this.gLinea.Location = new System.Drawing.Point(12, 174);
            this.gLinea.MainView = this.gvLinea;
            this.gLinea.Name = "gLinea";
            this.gLinea.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTxtCantidad,
            this.repTxtPrecioUnitario,
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit3,
            this.repCboUbicacion,
            this.repCboProductos,
            this.repCboMoneda});
            this.gLinea.Size = new System.Drawing.Size(941, 583);
            this.gLinea.TabIndex = 5;
            this.gLinea.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLinea});
            // 
            // gvLinea
            // 
            this.gvLinea.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLinea.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLinea.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLinea.Appearance.Row.Options.UseFont = true;
            this.gvLinea.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcProducto,
            this.gcUbicacion,
            this.gcCantidad,
            this.gcMoneda,
            this.gcPrecioUnitario,
            this.gcObservacion,
            this.gcDonacion,
            this.gcTotal});
            this.gvLinea.GridControl = this.gLinea;
            this.gvLinea.Name = "gvLinea";
            this.gvLinea.OptionsView.ShowAutoFilterRow = true;
            this.gvLinea.OptionsView.ShowGroupPanel = false;
            this.gvLinea.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvLinea_CellValueChanged);
            // 
            // gcProducto
            // 
            this.gcProducto.Caption = "Producto";
            this.gcProducto.ColumnEdit = this.repCboProductos;
            this.gcProducto.FieldName = "productoID";
            this.gcProducto.Name = "gcProducto";
            this.gcProducto.Visible = true;
            this.gcProducto.VisibleIndex = 0;
            // 
            // repCboProductos
            // 
            this.repCboProductos.AutoHeight = false;
            this.repCboProductos.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCboProductos.Name = "repCboProductos";
            this.repCboProductos.NullText = "";
            // 
            // gcUbicacion
            // 
            this.gcUbicacion.Caption = "Ubicacion";
            this.gcUbicacion.ColumnEdit = this.repCboUbicacion;
            this.gcUbicacion.FieldName = "ubicacionID";
            this.gcUbicacion.Name = "gcUbicacion";
            this.gcUbicacion.Visible = true;
            this.gcUbicacion.VisibleIndex = 1;
            // 
            // repCboUbicacion
            // 
            this.repCboUbicacion.AutoHeight = false;
            this.repCboUbicacion.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCboUbicacion.Name = "repCboUbicacion";
            this.repCboUbicacion.NullText = "";
            // 
            // gcCantidad
            // 
            this.gcCantidad.Caption = "Cantidad";
            this.gcCantidad.ColumnEdit = this.repTxtCantidad;
            this.gcCantidad.FieldName = "Cantidad";
            this.gcCantidad.Name = "gcCantidad";
            this.gcCantidad.Visible = true;
            this.gcCantidad.VisibleIndex = 2;
            // 
            // repTxtCantidad
            // 
            this.repTxtCantidad.AutoHeight = false;
            this.repTxtCantidad.DisplayFormat.FormatString = "n";
            this.repTxtCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtCantidad.EditFormat.FormatString = "n";
            this.repTxtCantidad.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtCantidad.Name = "repTxtCantidad";
            // 
            // gcMoneda
            // 
            this.gcMoneda.Caption = "Moneda";
            this.gcMoneda.ColumnEdit = this.repCboMoneda;
            this.gcMoneda.FieldName = "monedaID";
            this.gcMoneda.Name = "gcMoneda";
            this.gcMoneda.Visible = true;
            this.gcMoneda.VisibleIndex = 3;
            // 
            // repCboMoneda
            // 
            this.repCboMoneda.AutoHeight = false;
            this.repCboMoneda.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCboMoneda.Name = "repCboMoneda";
            // 
            // gcPrecioUnitario
            // 
            this.gcPrecioUnitario.Caption = "Precio Unitario";
            this.gcPrecioUnitario.ColumnEdit = this.repTxtPrecioUnitario;
            this.gcPrecioUnitario.FieldName = "PrecioUnitario";
            this.gcPrecioUnitario.Name = "gcPrecioUnitario";
            this.gcPrecioUnitario.Visible = true;
            this.gcPrecioUnitario.VisibleIndex = 4;
            // 
            // repTxtPrecioUnitario
            // 
            this.repTxtPrecioUnitario.AutoHeight = false;
            this.repTxtPrecioUnitario.DisplayFormat.FormatString = "n2";
            this.repTxtPrecioUnitario.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtPrecioUnitario.EditFormat.FormatString = "n2";
            this.repTxtPrecioUnitario.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repTxtPrecioUnitario.Name = "repTxtPrecioUnitario";
            // 
            // gcObservacion
            // 
            this.gcObservacion.Caption = "Observación";
            this.gcObservacion.FieldName = "Observacion";
            this.gcObservacion.Name = "gcObservacion";
            this.gcObservacion.Visible = true;
            this.gcObservacion.VisibleIndex = 7;
            // 
            // gcDonacion
            // 
            this.gcDonacion.Caption = "Donación";
            this.gcDonacion.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gcDonacion.FieldName = "Donacion";
            this.gcDonacion.Name = "gcDonacion";
            this.gcDonacion.Visible = true;
            this.gcDonacion.VisibleIndex = 6;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gcTotal
            // 
            this.gcTotal.Caption = "Total";
            this.gcTotal.FieldName = "Total";
            this.gcTotal.Name = "gcTotal";
            this.gcTotal.Visible = true;
            this.gcTotal.VisibleIndex = 5;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.repositoryItemTextEdit3.ReadOnly = true;
            // 
            // gbDatosEntrada
            // 
            this.gbDatosEntrada.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosEntrada.AppearanceCaption.Options.UseFont = true;
            this.gbDatosEntrada.Controls.Add(this.layoutControl2);
            this.gbDatosEntrada.Location = new System.Drawing.Point(12, 12);
            this.gbDatosEntrada.Name = "gbDatosEntrada";
            this.gbDatosEntrada.Size = new System.Drawing.Size(941, 158);
            this.gbDatosEntrada.TabIndex = 4;
            this.gbDatosEntrada.Text = "Datos de entrada";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.panelControl1);
            this.layoutControl2.Controls.Add(this.txtUsuario);
            this.layoutControl2.Controls.Add(this.deFechaEntrada);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 23);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(937, 133);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnGuardarEntrada);
            this.panelControl1.Controls.Add(this.btnAgregar);
            this.panelControl1.Location = new System.Drawing.Point(12, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(913, 64);
            this.panelControl1.TabIndex = 8;
            // 
            // btnGuardarEntrada
            // 
            this.btnGuardarEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarEntrada.Image")));
            this.btnGuardarEntrada.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnGuardarEntrada.Location = new System.Drawing.Point(839, 10);
            this.btnGuardarEntrada.Name = "btnGuardarEntrada";
            this.btnGuardarEntrada.Size = new System.Drawing.Size(51, 38);
            this.btnGuardarEntrada.TabIndex = 1;
            this.btnGuardarEntrada.Click += new System.EventHandler(this.btnGuardarEntrada_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnAgregar.Location = new System.Drawing.Point(431, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(51, 38);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(470, 31);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Properties.Appearance.Options.UseFont = true;
            this.txtUsuario.Properties.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(455, 22);
            this.txtUsuario.StyleController = this.layoutControl2;
            this.txtUsuario.TabIndex = 5;
            // 
            // deFechaEntrada
            // 
            this.deFechaEntrada.EditValue = null;
            this.deFechaEntrada.Location = new System.Drawing.Point(12, 31);
            this.deFechaEntrada.Name = "deFechaEntrada";
            this.deFechaEntrada.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deFechaEntrada.Properties.Appearance.Options.UseFont = true;
            this.deFechaEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEntrada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaEntrada.Size = new System.Drawing.Size(454, 22);
            this.deFechaEntrada.StyleController = this.layoutControl2;
            this.deFechaEntrada.TabIndex = 4;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(937, 133);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.deFechaEntrada;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(458, 45);
            this.layoutControlItem3.Text = "Fecha de la entrada";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(128, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtUsuario;
            this.layoutControlItem4.Location = new System.Drawing.Point(458, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(459, 45);
            this.layoutControlItem4.Text = "Usuario";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(128, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.panelControl1;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(917, 68);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(965, 769);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gbDatosEntrada;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(945, 162);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gLinea;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 162);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(945, 587);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FrmEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 769);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmEntrada";
            this.Text = "Entrada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCboProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCboUbicacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCboMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDatosEntrada)).EndInit();
            this.gbDatosEntrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gLinea;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLinea;
        private DevExpress.XtraEditors.GroupControl gbDatosEntrada;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gcProducto;
        private DevExpress.XtraGrid.Columns.GridColumn gcUbicacion;
        private DevExpress.XtraGrid.Columns.GridColumn gcCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn gcPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn gcDonacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtCantidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtPrecioUnitario;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.DateEdit deFechaEntrada;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCboUbicacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCboProductos;
        private DevExpress.XtraGrid.Columns.GridColumn gcObservacion;
        private DevExpress.XtraEditors.SimpleButton btnGuardarEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn gcMoneda;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repCboMoneda;
    }
}