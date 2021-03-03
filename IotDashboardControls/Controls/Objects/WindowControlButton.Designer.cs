
namespace IotDashboard.Controls.Objects
{
    partial class WindowControlButton
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
            this.SuspendLayout();
            // 
            // WindowControlButton
            // 
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowControlButton_MouseDown);
            this.MouseEnter += new System.EventHandler(this.WindowControlButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.WindowControlButton_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowControlButton_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
