namespace Presentacion
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnArea = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnUusarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnUbicacion = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnEntrada = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnArea,
            this.btnCategorias,
            this.btnProductos,
            this.btnUusarios,
            this.btnUbicacion,
            this.btnEntrada});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1202, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnArea
            // 
            this.btnArea.Caption = "Area";
            this.btnArea.Id = 1;
            this.btnArea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnArea.ImageOptions.Image")));
            this.btnArea.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnArea.ImageOptions.LargeImage")));
            this.btnArea.Name = "btnArea";
            this.btnArea.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnArea_ItemClick);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Caption = "Categoria";
            this.btnCategorias.Id = 2;
            this.btnCategorias.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.ImageOptions.Image")));
            this.btnCategorias.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCategorias.ImageOptions.LargeImage")));
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategorias_ItemClick);
            // 
            // btnProductos
            // 
            this.btnProductos.Caption = "Productos";
            this.btnProductos.Id = 3;
            this.btnProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.ImageOptions.Image")));
            this.btnProductos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProductos.ImageOptions.LargeImage")));
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductos_ItemClick);
            // 
            // btnUusarios
            // 
            this.btnUusarios.Caption = "Usuarios";
            this.btnUusarios.Id = 4;
            this.btnUusarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUusarios.ImageOptions.Image")));
            this.btnUusarios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUusarios.ImageOptions.LargeImage")));
            this.btnUusarios.Name = "btnUusarios";
            this.btnUusarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUusarios_ItemClick);
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Caption = "Ubicaciones";
            this.btnUbicacion.Id = 5;
            this.btnUbicacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUbicacion.ImageOptions.Image")));
            this.btnUbicacion.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUbicacion.ImageOptions.LargeImage")));
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUbicacion_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Catalogos";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCategorias);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProductos);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUbicacion);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Productos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnArea);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUusarios);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Usuarios";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 703);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1202, 32);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Black";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Entradas";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnEntrada);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Entrada";
            // 
            // btnEntrada
            // 
            this.btnEntrada.Caption = "Nueva Entrada";
            this.btnEntrada.Id = 6;
            this.btnEntrada.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrada.ImageOptions.Image")));
            this.btnEntrada.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEntrada.ImageOptions.LargeImage")));
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEntrada_ItemClick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 735);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnArea;
        private DevExpress.XtraBars.BarButtonItem btnCategorias;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraBars.BarButtonItem btnUusarios;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnUbicacion;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btnEntrada;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}