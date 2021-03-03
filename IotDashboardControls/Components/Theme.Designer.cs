
namespace IoTDashboardControls.Components
{
    partial class Theme
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
            this.components = new System.ComponentModel.Container();
            this.ScreenTheme = new IoTDashboardControls.Components.ScreenTheme(this.components);
            this.TextTheme = new IoTDashboardControls.Components.TextTheme(this.components);
            this.WindowTheme = new IoTDashboardControls.Components.WindowTheme(this.components);
            this.MenuTheme = new IoTDashboardControls.Components.MenuTheme(this.components);
            this.ButtonTheme = new IoTDashboardControls.Components.ButtonTheme(this.components);
            // 
            // ScreenTheme
            // 
            this.ScreenTheme.BackgroundColor = System.Drawing.Color.Empty;
            // 
            // TextTheme
            // 
            this.TextTheme.TextColor = System.Drawing.Color.Empty;
            this.TextTheme.TextFont = null;
            // 
            // WindowTheme
            // 
            this.WindowTheme.BackgroudColor = System.Drawing.Color.Empty;
            // 
            // MenuTheme
            // 
            this.MenuTheme.HeaderColor = System.Drawing.Color.Empty;
            this.MenuTheme.MenuColor = System.Drawing.Color.Empty;
            // 
            // ButtonTheme
            // 
            this.ButtonTheme.Color = System.Drawing.Color.Empty;
            this.ButtonTheme.ColorOnClick = System.Drawing.Color.Empty;
            this.ButtonTheme.ColorOnEnter = System.Drawing.Color.Empty;

        }

        #endregion

        public IoTDashboardControls.Components.ScreenTheme ScreenTheme;
        public IoTDashboardControls.Components.TextTheme TextTheme;
        public IoTDashboardControls.Components.WindowTheme WindowTheme;
        public IoTDashboardControls.Components.MenuTheme MenuTheme;
        public IoTDashboardControls.Components.ButtonTheme ButtonTheme;
    }
}
