namespace menu_Ordenamientos_P1
{
    partial class Form1
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
            this.btnBurbuja1 = new System.Windows.Forms.Button();
            this.btnBurbuja2 = new System.Windows.Forms.Button();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.btnInsercion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBurbuja1
            // 
            this.btnBurbuja1.Location = new System.Drawing.Point(50, 74);
            this.btnBurbuja1.Name = "btnBurbuja1";
            this.btnBurbuja1.Size = new System.Drawing.Size(157, 64);
            this.btnBurbuja1.TabIndex = 0;
            this.btnBurbuja1.Text = "Burbuja";
            this.btnBurbuja1.UseVisualStyleBackColor = true;
            this.btnBurbuja1.Click += new System.EventHandler(this.btnBurbuja1_Click);
            // 
            // btnBurbuja2
            // 
            this.btnBurbuja2.Location = new System.Drawing.Point(50, 165);
            this.btnBurbuja2.Name = "btnBurbuja2";
            this.btnBurbuja2.Size = new System.Drawing.Size(157, 64);
            this.btnBurbuja2.TabIndex = 1;
            this.btnBurbuja2.Text = "Burbuja Mejorada";
            this.btnBurbuja2.UseVisualStyleBackColor = true;
            this.btnBurbuja2.Click += new System.EventHandler(this.btnBurbuja2_Click);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(263, 74);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(157, 64);
            this.btnSeleccion.TabIndex = 2;
            this.btnSeleccion.Text = "Selección ";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // btnInsercion
            // 
            this.btnInsercion.Location = new System.Drawing.Point(263, 165);
            this.btnInsercion.Name = "btnInsercion";
            this.btnInsercion.Size = new System.Drawing.Size(157, 64);
            this.btnInsercion.TabIndex = 3;
            this.btnInsercion.Text = "Inserción";
            this.btnInsercion.UseVisualStyleBackColor = true;
            this.btnInsercion.Click += new System.EventHandler(this.btnInsercion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ordenamientos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsercion);
            this.Controls.Add(this.btnSeleccion);
            this.Controls.Add(this.btnBurbuja2);
            this.Controls.Add(this.btnBurbuja1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBurbuja1;
        private System.Windows.Forms.Button btnBurbuja2;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Button btnInsercion;
        private System.Windows.Forms.Label label1;
    }
}

