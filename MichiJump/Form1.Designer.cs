namespace MichiJump
{
    partial class MichiJump
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
            this.pbEscenario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEscenario)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEscenario
            // 
            this.pbEscenario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEscenario.Location = new System.Drawing.Point(12, 12);
            this.pbEscenario.Name = "pbEscenario";
            this.pbEscenario.Size = new System.Drawing.Size(600, 500);
            this.pbEscenario.TabIndex = 0;
            this.pbEscenario.TabStop = false;
            // 
            // MichiJump
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(623, 547);
            this.Controls.Add(this.pbEscenario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MichiJump";
            this.Text = "MichiJump";
            ((System.ComponentModel.ISupportInitialize)(this.pbEscenario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.PictureBox pbEscenario;
    }
}

