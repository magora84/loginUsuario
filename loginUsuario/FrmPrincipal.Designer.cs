namespace loginUsuario
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sensillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.capturaToolStripMenuItem,
            this.revisionToolStripMenuItem,
            this.campañasToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.miCuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // capturaToolStripMenuItem
            // 
            this.capturaToolStripMenuItem.Name = "capturaToolStripMenuItem";
            this.capturaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.capturaToolStripMenuItem.Text = "Captura";
            // 
            // revisionToolStripMenuItem
            // 
            this.revisionToolStripMenuItem.Name = "revisionToolStripMenuItem";
            this.revisionToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.revisionToolStripMenuItem.Text = "Revision";
            // 
            // campañasToolStripMenuItem
            // 
            this.campañasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sensillasToolStripMenuItem,
            this.grupalesToolStripMenuItem});
            this.campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            this.campañasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.campañasToolStripMenuItem.Text = "campañas";
            // 
            // sensillasToolStripMenuItem
            // 
            this.sensillasToolStripMenuItem.Name = "sensillasToolStripMenuItem";
            this.sensillasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sensillasToolStripMenuItem.Text = "Sensillas";
            // 
            // grupalesToolStripMenuItem
            // 
            this.grupalesToolStripMenuItem.Name = "grupalesToolStripMenuItem";
            this.grupalesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grupalesToolStripMenuItem.Text = "Grupales";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.promocionesToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.promocionesToolStripMenuItem.Text = "Promociones";
            // 
            // miCuentaToolStripMenuItem
            // 
            this.miCuentaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            this.miCuentaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.miCuentaToolStripMenuItem.Text = "mi cuenta";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verToolStripMenuItem.Text = "ver";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 360);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sensillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
    }
}