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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.btnArea = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnUusarios = new DevExpress.XtraBars.BarButtonItem();
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
            this.btnUusarios});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1208, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Productos";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 704);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1208, 31);
            // 
            // btnArea
            // 
            this.btnArea.Caption = "Area";
            this.btnArea.Id = 1;
            this.btnArea.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnArea.ImageOptions.Image")));
            this.btnArea.Name = "btnArea";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Caption = "Categoria";
            this.btnCategorias.Id = 2;
            this.btnCategorias.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.ImageOptions.Image")));
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategorias_ItemClick);
            // 
            // btnProductos
            // 
            this.btnProductos.Caption = "Productos";
            this.btnProductos.Id = 3;
            this.btnProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.ImageOptions.Image")));
            this.btnProductos.Name = "btnProductos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnArea);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUusarios);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Usuarios";
            // 
            // btnUusarios
            // 
            this.btnUusarios.Caption = "Usuarios";
            this.btnUusarios.Id = 4;
            this.btnUusarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUusarios.ImageOptions.Image")));
            this.btnUusarios.Name = "btnUusarios";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 735);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.Ribbon = this.ribbon;
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
    }
}