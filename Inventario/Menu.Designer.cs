namespace Inventario
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.botonGuardar = new FontAwesome.Sharp.IconToolStripButton();
            this.botonEliminar = new FontAwesome.Sharp.IconToolStripButton();
            this.botonImprimir = new FontAwesome.Sharp.IconToolStripButton();
            this.botonConsultar = new FontAwesome.Sharp.IconToolStripButton();
            this.botonCancelar = new FontAwesome.Sharp.IconToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bAyuda = new FontAwesome.Sharp.IconToolStripButton();
            this.botonSalir = new FontAwesome.Sharp.IconToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.InventarioDataSet = new Inventario.InventarioDataSet();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesTableAdapter = new Inventario.InventarioDataSetTableAdapters.ClientesTableAdapter();
            this.Cerrar = new FontAwesome.Sharp.IconPictureBox();
            this.Minimizar = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.usuario = new System.Windows.Forms.Label();
            this.ventasEntreFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.tsReportes,
            this.tsMantenimientos,
            this.tsProcesos,
            this.toolsMenu,
            this.tsAcerca});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1355, 32);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator4,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.printSetupToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileMenu.Image = ((System.Drawing.Image)(resources.GetObject("fileMenu.Image")));
            this.fileMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(98, 28);
            this.fileMenu.Text = "&Archivo";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.newToolStripMenuItem.Text = "&Nuevo";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.openToolStripMenuItem.Text = "&Abrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(264, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.saveToolStripMenuItem.Text = "&Guardar";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.saveAsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.saveAsToolStripMenuItem.Text = "Guardar &como";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(264, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.printToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.printToolStripMenuItem.Text = "&Imprimir";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.printPreviewToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.printPreviewToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // printSetupToolStripMenuItem
            // 
            this.printSetupToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.printSetupToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
            this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.printSetupToolStripMenuItem.Text = "Configurar impresión";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripSeparator5.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(264, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(267, 38);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator6,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator7,
            this.selectAllToolStripMenuItem});
            this.editMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.editMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editMenu.Image = ((System.Drawing.Image)(resources.GetObject("editMenu.Image")));
            this.editMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(85, 28);
            this.editMenu.Text = "&Editar";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.undoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.undoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.undoToolStripMenuItem.Text = "&Deshacer";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.redoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.redoToolStripMenuItem.Text = "&Rehacer";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(250, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.cutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.cutToolStripMenuItem.Text = "Cor&tar";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.copyToolStripMenuItem.Text = "&Copiar";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.pasteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.pasteToolStripMenuItem.Text = "&Pegar";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripSeparator7.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(250, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.selectAllToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.selectAllToolStripMenuItem.Text = "Seleccionar &todo";
            // 
            // tsReportes
            // 
            this.tsReportes.BackColor = System.Drawing.Color.MidnightBlue;
            this.tsReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.departamentosToolStripMenuItem1,
            this.productosToolStripMenuItem1,
            this.suplidoresToolStripMenuItem1,
            this.unidadesToolStripMenuItem1,
            this.usuariosToolStripMenuItem1,
            this.facturaToolStripMenuItem1,
            this.ventasEntreFechaToolStripMenuItem});
            this.tsReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsReportes.Image = ((System.Drawing.Image)(resources.GetObject("tsReportes.Image")));
            this.tsReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsReportes.Name = "tsReportes";
            this.tsReportes.Size = new System.Drawing.Size(105, 28);
            this.tsReportes.Text = "Reportes";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.clientesToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem1.Image")));
            this.clientesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(220, 38);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // departamentosToolStripMenuItem1
            // 
            this.departamentosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.departamentosToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.departamentosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("departamentosToolStripMenuItem1.Image")));
            this.departamentosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.departamentosToolStripMenuItem1.Name = "departamentosToolStripMenuItem1";
            this.departamentosToolStripMenuItem1.Size = new System.Drawing.Size(220, 38);
            this.departamentosToolStripMenuItem1.Text = "Departamentos";
            this.departamentosToolStripMenuItem1.Click += new System.EventHandler(this.departamentosToolStripMenuItem1_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.productosToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.productosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem1.Image")));
            this.productosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(220, 38);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // suplidoresToolStripMenuItem1
            // 
            this.suplidoresToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.suplidoresToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.suplidoresToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("suplidoresToolStripMenuItem1.Image")));
            this.suplidoresToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.suplidoresToolStripMenuItem1.Name = "suplidoresToolStripMenuItem1";
            this.suplidoresToolStripMenuItem1.Size = new System.Drawing.Size(220, 38);
            this.suplidoresToolStripMenuItem1.Text = "Suplidores";
            this.suplidoresToolStripMenuItem1.Click += new System.EventHandler(this.suplidoresToolStripMenuItem1_Click);
            // 
            // unidadesToolStripMenuItem1
            // 
            this.unidadesToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.unidadesToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.unidadesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("unidadesToolStripMenuItem1.Image")));
            this.unidadesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unidadesToolStripMenuItem1.Name = "unidadesToolStripMenuItem1";
            this.unidadesToolStripMenuItem1.Size = new System.Drawing.Size(220, 38);
            this.unidadesToolStripMenuItem1.Text = "Unidades";
            this.unidadesToolStripMenuItem1.Click += new System.EventHandler(this.unidadesToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.usuariosToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.usuariosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem1.Image")));
            this.usuariosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(220, 38);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // facturaToolStripMenuItem1
            // 
            this.facturaToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.facturaToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.facturaToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("facturaToolStripMenuItem1.Image")));
            this.facturaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturaToolStripMenuItem1.Name = "facturaToolStripMenuItem1";
            this.facturaToolStripMenuItem1.Size = new System.Drawing.Size(220, 38);
            this.facturaToolStripMenuItem1.Text = "Factura";
            this.facturaToolStripMenuItem1.Click += new System.EventHandler(this.facturaToolStripMenuItem1_Click);
            // 
            // tsMantenimientos
            // 
            this.tsMantenimientos.BackColor = System.Drawing.Color.MidnightBlue;
            this.tsMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.departamentosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.suplidoresToolStripMenuItem,
            this.unidadesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.tsMantenimientos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tsMantenimientos.ForeColor = System.Drawing.Color.White;
            this.tsMantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("tsMantenimientos.Image")));
            this.tsMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMantenimientos.Name = "tsMantenimientos";
            this.tsMantenimientos.Size = new System.Drawing.Size(156, 28);
            this.tsMantenimientos.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.clientesToolStripMenuItem.Text = "Clientes ";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.departamentosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.departamentosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departamentosToolStripMenuItem.Image")));
            this.departamentosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            this.departamentosToolStripMenuItem.Click += new System.EventHandler(this.departamentosToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productosToolStripMenuItem.Image")));
            this.productosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // suplidoresToolStripMenuItem
            // 
            this.suplidoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.suplidoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.suplidoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("suplidoresToolStripMenuItem.Image")));
            this.suplidoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.suplidoresToolStripMenuItem.Name = "suplidoresToolStripMenuItem";
            this.suplidoresToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.suplidoresToolStripMenuItem.Text = "Suplidores";
            this.suplidoresToolStripMenuItem.Click += new System.EventHandler(this.suplidoresToolStripMenuItem_Click);
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.unidadesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.unidadesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unidadesToolStripMenuItem.Image")));
            this.unidadesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.unidadesToolStripMenuItem.Text = "Unidades ";
            this.unidadesToolStripMenuItem.Click += new System.EventHandler(this.unidadesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(199, 38);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // tsProcesos
            // 
            this.tsProcesos.BackColor = System.Drawing.Color.MidnightBlue;
            this.tsProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturaToolStripMenuItem});
            this.tsProcesos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsProcesos.Image = ((System.Drawing.Image)(resources.GetObject("tsProcesos.Image")));
            this.tsProcesos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsProcesos.Name = "tsProcesos";
            this.tsProcesos.Size = new System.Drawing.Size(105, 28);
            this.tsProcesos.Text = "Procesos";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.facturaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.facturaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facturaToolStripMenuItem.Image")));
            this.facturaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.facturaToolStripMenuItem.Text = "Facturacion";
            this.facturaToolStripMenuItem.Click += new System.EventHandler(this.facturaToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.ejemplosToolStripMenuItem});
            this.toolsMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolsMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolsMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolsMenu.Image")));
            this.toolsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(137, 28);
            this.toolsMenu.Text = "&Herramientas";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.optionsToolStripMenuItem.Text = "&Opciones";
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ejemplosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejemplosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos";
            this.ejemplosToolStripMenuItem.Click += new System.EventHandler(this.ejemplosToolStripMenuItem_Click);
            // 
            // tsAcerca
            // 
            this.tsAcerca.BackColor = System.Drawing.Color.MidnightBlue;
            this.tsAcerca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsAcerca.Image = ((System.Drawing.Image)(resources.GetObject("tsAcerca.Image")));
            this.tsAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAcerca.Name = "tsAcerca";
            this.tsAcerca.Size = new System.Drawing.Size(124, 28);
            this.tsAcerca.Text = "Acerca de...";
            this.tsAcerca.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.MidnightBlue;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.toolStripSeparator1,
            this.botonGuardar,
            this.botonEliminar,
            this.botonImprimir,
            this.botonConsultar,
            this.botonCancelar,
            this.toolStripSeparator2,
            this.bAyuda,
            this.botonSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 32);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(1355, 39);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.newToolStripButton.Text = "Nuevo";
            this.newToolStripButton.Visible = false;
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(36, 36);
            this.openToolStripButton.Text = "Abrir";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // botonGuardar
            // 
            this.botonGuardar.AutoSize = false;
            this.botonGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.botonGuardar.IconColor = System.Drawing.Color.White;
            this.botonGuardar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.botonGuardar.IconSize = 36;
            this.botonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(36, 36);
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.AutoSize = false;
            this.botonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.botonEliminar.IconColor = System.Drawing.Color.White;
            this.botonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonEliminar.IconSize = 36;
            this.botonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonEliminar.Margin = new System.Windows.Forms.Padding(0);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(36, 36);
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonImprimir
            // 
            this.botonImprimir.AutoSize = false;
            this.botonImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.botonImprimir.IconColor = System.Drawing.Color.White;
            this.botonImprimir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.botonImprimir.IconSize = 36;
            this.botonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonImprimir.Margin = new System.Windows.Forms.Padding(0);
            this.botonImprimir.Name = "botonImprimir";
            this.botonImprimir.Size = new System.Drawing.Size(36, 36);
            this.botonImprimir.Text = "Imprimir";
            this.botonImprimir.Click += new System.EventHandler(this.botonImprimir_Click);
            // 
            // botonConsultar
            // 
            this.botonConsultar.AutoSize = false;
            this.botonConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonConsultar.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.botonConsultar.IconColor = System.Drawing.Color.White;
            this.botonConsultar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.botonConsultar.IconSize = 36;
            this.botonConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botonConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonConsultar.Margin = new System.Windows.Forms.Padding(0);
            this.botonConsultar.Name = "botonConsultar";
            this.botonConsultar.Size = new System.Drawing.Size(36, 36);
            this.botonConsultar.Text = "Consultar";
            this.botonConsultar.Click += new System.EventHandler(this.botonConsultar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.AutoSize = false;
            this.botonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonCancelar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.botonCancelar.IconColor = System.Drawing.Color.White;
            this.botonCancelar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.botonCancelar.IconSize = 36;
            this.botonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(36, 36);
            this.botonCancelar.Text = "Cancelar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bAyuda
            // 
            this.bAyuda.AutoSize = false;
            this.bAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bAyuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.bAyuda.IconColor = System.Drawing.Color.White;
            this.bAyuda.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.bAyuda.IconSize = 36;
            this.bAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bAyuda.Margin = new System.Windows.Forms.Padding(0);
            this.bAyuda.Name = "bAyuda";
            this.bAyuda.Size = new System.Drawing.Size(36, 36);
            this.bAyuda.Text = "Ayuda";
            // 
            // botonSalir
            // 
            this.botonSalir.AutoSize = false;
            this.botonSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botonSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.botonSalir.IconColor = System.Drawing.Color.White;
            this.botonSalir.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.botonSalir.IconSize = 36;
            this.botonSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.botonSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.botonSalir.Margin = new System.Windows.Forms.Padding(0);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(36, 36);
            this.botonSalir.Text = "Salir";
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // InventarioDataSet
            // 
            this.InventarioDataSet.DataSetName = "InventarioDataSet";
            this.InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.InventarioDataSet;
            // 
            // ClientesTableAdapter
            // 
            this.ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.Cerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Cerrar.IconColor = System.Drawing.Color.DarkRed;
            this.Cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cerrar.IconSize = 35;
            this.Cerrar.Location = new System.Drawing.Point(1299, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(35, 44);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 4;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.ForeColor = System.Drawing.Color.DarkRed;
            this.Minimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.Minimizar.IconColor = System.Drawing.Color.DarkRed;
            this.Minimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Minimizar.IconSize = 34;
            this.Minimizar.Location = new System.Drawing.Point(1258, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(34, 34);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Minimizar.TabIndex = 5;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 692);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 63);
            this.panel1.TabIndex = 7;
            // 
            // lblHora
            // 
            this.lblHora.AutoEllipsis = true;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(21, 4);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(117, 54);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.DarkRed;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1051, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 23);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha";
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.BackColor = System.Drawing.Color.MidnightBlue;
            this.usuario.Font = new System.Drawing.Font("Segoe UI", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.White;
            this.usuario.Location = new System.Drawing.Point(949, 33);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(0, 23);
            this.usuario.TabIndex = 10;
            // 
            // ventasEntreFechaToolStripMenuItem
            // 
            this.ventasEntreFechaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.ventasEntreFechaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ventasEntreFechaToolStripMenuItem.Name = "ventasEntreFechaToolStripMenuItem";
            this.ventasEntreFechaToolStripMenuItem.Size = new System.Drawing.Size(220, 38);
            this.ventasEntreFechaToolStripMenuItem.Text = "Ventas entre fecha";
            this.ventasEntreFechaToolStripMenuItem.Click += new System.EventHandler(this.ventasEntreFechaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(68)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1355, 755);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Minimizar);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapon Store";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MdiChildActivate += new System.EventHandler(this.Menu_MdiChildActivate);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem printSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem ejemplosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsReportes;
        private System.Windows.Forms.ToolStripMenuItem tsMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsProcesos;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsAcerca;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem1;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private InventarioDataSet InventarioDataSet;
        private InventarioDataSetTableAdapters.ClientesTableAdapter ClientesTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private FontAwesome.Sharp.IconPictureBox Cerrar;
        private FontAwesome.Sharp.IconPictureBox Minimizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer Hora;
        private FontAwesome.Sharp.IconToolStripButton botonGuardar;
        private FontAwesome.Sharp.IconToolStripButton botonEliminar;
        private FontAwesome.Sharp.IconToolStripButton botonImprimir;
        private FontAwesome.Sharp.IconToolStripButton botonConsultar;
        private FontAwesome.Sharp.IconToolStripButton botonCancelar;
        private FontAwesome.Sharp.IconToolStripButton botonSalir;
        private FontAwesome.Sharp.IconToolStripButton bAyuda;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.ToolStripMenuItem ventasEntreFechaToolStripMenuItem;
    }
}



