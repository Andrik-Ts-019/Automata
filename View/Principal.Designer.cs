namespace View
{
    partial class Principal
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.textBoxExpresion = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.labelMuestraAlfabeto = new System.Windows.Forms.Label();
            this.labelAlfabeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(152, 59);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(323, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(62, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(84, 24);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatricula.Location = new System.Drawing.Point(56, 100);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(90, 24);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula:";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(151, 104);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(323, 20);
            this.textBoxMatricula.TabIndex = 3;
            // 
            // textBoxExpresion
            // 
            this.textBoxExpresion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpresion.Location = new System.Drawing.Point(151, 226);
            this.textBoxExpresion.Name = "textBoxExpresion";
            this.textBoxExpresion.Size = new System.Drawing.Size(535, 26);
            this.textBoxExpresion.TabIndex = 4;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(354, 271);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(140, 36);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // labelMuestraAlfabeto
            // 
            this.labelMuestraAlfabeto.AutoSize = true;
            this.labelMuestraAlfabeto.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraAlfabeto.Location = new System.Drawing.Point(147, 154);
            this.labelMuestraAlfabeto.Name = "labelMuestraAlfabeto";
            this.labelMuestraAlfabeto.Size = new System.Drawing.Size(212, 25);
            this.labelMuestraAlfabeto.TabIndex = 6;
            this.labelMuestraAlfabeto.Text = "labelMuestraAlfabeto";
            // 
            // labelAlfabeto
            // 
            this.labelAlfabeto.AutoSize = true;
            this.labelAlfabeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlfabeto.Location = new System.Drawing.Point(56, 154);
            this.labelAlfabeto.Name = "labelAlfabeto";
            this.labelAlfabeto.Size = new System.Drawing.Size(83, 24);
            this.labelAlfabeto.TabIndex = 7;
            this.labelAlfabeto.Text = "Alfabeto:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAlfabeto);
            this.Controls.Add(this.labelMuestraAlfabeto);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxExpresion);
            this.Controls.Add(this.textBoxMatricula);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.TextBox textBoxExpresion;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label labelMuestraAlfabeto;
        private System.Windows.Forms.Label labelAlfabeto;
    }
}

