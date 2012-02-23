namespace Caixa.Controls
{
    partial class CaixaButton
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
                        
            this.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(99,99,99);
            this.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(99, 99, 99);
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseVisualStyleBackColor = false;
        }

        #endregion
    }
}
