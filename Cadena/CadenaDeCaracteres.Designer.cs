namespace Cadena
{
    partial class CadenaDeCaracteres
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngresaCadena = new System.Windows.Forms.TextBox();
            this.ListadoPalabras = new System.Windows.Forms.ListBox();
            this.Resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese una oracion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Las palabras Fueron:";
            // 
            // IngresaCadena
            // 
            this.IngresaCadena.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresaCadena.Location = new System.Drawing.Point(35, 30);
            this.IngresaCadena.Name = "IngresaCadena";
            this.IngresaCadena.Size = new System.Drawing.Size(415, 23);
            this.IngresaCadena.TabIndex = 2;
            // 
            // ListadoPalabras
            // 
            this.ListadoPalabras.FormattingEnabled = true;
            this.ListadoPalabras.Location = new System.Drawing.Point(182, 133);
            this.ListadoPalabras.Name = "ListadoPalabras";
            this.ListadoPalabras.Size = new System.Drawing.Size(145, 95);
            this.ListadoPalabras.TabIndex = 3;
            // 
            // Resultado
            // 
            this.Resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Resultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resultado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(182, 59);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(145, 35);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "Ver ";
            this.Resultado.UseVisualStyleBackColor = false;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // CadenaDeCaracteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(475, 240);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.ListadoPalabras);
            this.Controls.Add(this.IngresaCadena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadenaDeCaracteres";
            this.Text = "Cadena de caracteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IngresaCadena;
        private System.Windows.Forms.ListBox ListadoPalabras;
        private System.Windows.Forms.Button Resultado;
    }
}

