namespace Prueba3Hint
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxHint1 = new ControlPersonalizadoHint.TextBoxHint();
            this.SuspendLayout();
            // 
            // textBoxHint1
            // 
            this.textBoxHint1.Hint = "HOLAHOLA";
            this.textBoxHint1.Location = new System.Drawing.Point(254, 162);
            this.textBoxHint1.Name = "textBoxHint1";
            this.textBoxHint1.Size = new System.Drawing.Size(100, 20);
            this.textBoxHint1.TabIndex = 0;
            this.textBoxHint1.TextChanged += new System.EventHandler(this.textBoxHint1_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxHint1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlPersonalizadoHint.TextBoxHint textBoxHint1;
    }
}
