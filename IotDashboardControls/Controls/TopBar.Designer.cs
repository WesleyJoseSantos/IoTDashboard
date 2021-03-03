
using IotDashboard.Controls;

namespace IoTDashboard.Controls
{
    partial class TopBar
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
            this.buttonMin = new IotDashboard.Controls.WindowControlButton();
            this.buttonMax = new IotDashboard.Controls.WindowControlButton();
            this.buttonClose = new IotDashboard.Controls.WindowControlButton();
            this.headerText = new IotDashboard.Controls.HeaderText();
            this.headerIcon = new IotDashboard.Controls.HeaderIcon();
            ((System.ComponentModel.ISupportInitialize)(this.headerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMin
            // 
            this.buttonMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMin.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMin.ForeColor = System.Drawing.Color.White;
            this.buttonMin.Location = new System.Drawing.Point(467, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(40, 40);
            this.buttonMin.TabIndex = 4;
            this.buttonMin.Text = "0";
            this.buttonMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMin.Theme = null;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMax.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonMax.ForeColor = System.Drawing.Color.White;
            this.buttonMax.Location = new System.Drawing.Point(507, 0);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(40, 40);
            this.buttonMax.TabIndex = 3;
            this.buttonMax.Text = "1";
            this.buttonMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonMax.Theme = null;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(547, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 40);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "r";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonClose.Theme = null;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // headerText
            // 
            this.headerText.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.Color.White;
            this.headerText.Location = new System.Drawing.Point(41, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(421, 40);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Cabeçalho";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.headerText.Theme = null;
            // 
            // headerIcon
            // 
            this.headerIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.headerIcon.Location = new System.Drawing.Point(0, 0);
            this.headerIcon.Margin = new System.Windows.Forms.Padding(10);
            this.headerIcon.Name = "headerIcon";
            this.headerIcon.Padding = new System.Windows.Forms.Padding(10);
            this.headerIcon.Size = new System.Drawing.Size(41, 40);
            this.headerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerIcon.TabIndex = 1;
            this.headerIcon.TabStop = false;
            this.headerIcon.Theme = null;
            this.headerIcon.Click += new System.EventHandler(this.headerIcon_Click);
            this.headerIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerIcon_MouseDown);
            this.headerIcon.MouseEnter += new System.EventHandler(this.headerIcon_MouseEnter);
            this.headerIcon.MouseLeave += new System.EventHandler(this.headerIcon_MouseLeave);
            this.headerIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerIcon_MouseUp);
            // 
            // TopBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.buttonMax);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.headerIcon);
            this.Name = "TopBar";
            this.Size = new System.Drawing.Size(587, 40);
            ((System.ComponentModel.ISupportInitialize)(this.headerIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HeaderText headerText;
        private HeaderIcon headerIcon;
        private WindowControlButton buttonClose;
        private WindowControlButton buttonMax;
        private WindowControlButton buttonMin;
    }
}
