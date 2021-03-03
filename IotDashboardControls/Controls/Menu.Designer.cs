
namespace IoTDashboardControls.Controls
{
    partial class Menu
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.menuHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuHeader
            // 
            this.menuHeader.Controls.Add(this.labelHeader);
            this.menuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuHeader.Location = new System.Drawing.Point(0, 0);
            this.menuHeader.Name = "menuHeader";
            this.menuHeader.Size = new System.Drawing.Size(239, 135);
            this.menuHeader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelHeader.Location = new System.Drawing.Point(0, 122);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(34, 13);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Menu";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.menuHeader);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(239, 375);
            this.menuHeader.ResumeLayout(false);
            this.menuHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuHeader;
        private System.Windows.Forms.Label labelHeader;
    }
}
