namespace Sumas
{
    partial class Sumas
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
            this.Sumar = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IngresoNum1 = new System.Windows.Forms.TextBox();
            this.IngresoNum2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sumar
            // 
            this.Sumar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sumar.Location = new System.Drawing.Point(140, 131);
            this.Sumar.Name = "Sumar";
            this.Sumar.Size = new System.Drawing.Size(128, 40);
            this.Sumar.TabIndex = 0;
            this.Sumar.Text = "Sumar";
            this.Sumar.UseVisualStyleBackColor = true;
            this.Sumar.Click += new System.EventHandler(this.Sumar_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(173, 20);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(62, 19);
            this.sum.TabIndex = 1;
            this.sum.Text = "Sumas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primer Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo Numero:";
            // 
            // IngresoNum1
            // 
            this.IngresoNum1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresoNum1.Location = new System.Drawing.Point(118, 81);
            this.IngresoNum1.Name = "IngresoNum1";
            this.IngresoNum1.Size = new System.Drawing.Size(59, 23);
            this.IngresoNum1.TabIndex = 4;
            // 
            // IngresoNum2
            // 
            this.IngresoNum2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngresoNum2.Location = new System.Drawing.Point(314, 82);
            this.IngresoNum2.Name = "IngresoNum2";
            this.IngresoNum2.Size = new System.Drawing.Size(59, 23);
            this.IngresoNum2.TabIndex = 5;
            // 
            // Resultado
            // 
            this.Resultado.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(177, 213);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(105, 23);
            this.Resultado.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Resultado:";
            // 
            // Sumas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.IngresoNum2);
            this.Controls.Add(this.IngresoNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.Sumar);
            this.Name = "Sumas";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sumar;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IngresoNum1;
        private System.Windows.Forms.TextBox IngresoNum2;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label3;
    }
}

