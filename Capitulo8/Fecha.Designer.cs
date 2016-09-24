namespace Capitulo8
{
    partial class Fecha
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
            this.VerResultado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ImprimoHora = new System.Windows.Forms.TextBox();
            this.ImprimoFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora:";
            // 
            // VerResultado
            // 
            this.VerResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.VerResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerResultado.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerResultado.Location = new System.Drawing.Point(151, 12);
            this.VerResultado.Name = "VerResultado";
            this.VerResultado.Size = new System.Drawing.Size(109, 32);
            this.VerResultado.TabIndex = 1;
            this.VerResultado.Text = "Ver";
            this.VerResultado.UseVisualStyleBackColor = false;
            this.VerResultado.Click += new System.EventHandler(this.VerResultado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // ImprimoHora
            // 
            this.ImprimoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ImprimoHora.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimoHora.Location = new System.Drawing.Point(80, 88);
            this.ImprimoHora.Name = "ImprimoHora";
            this.ImprimoHora.Size = new System.Drawing.Size(114, 23);
            this.ImprimoHora.TabIndex = 3;
            // 
            // ImprimoFecha
            // 
            this.ImprimoFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ImprimoFecha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimoFecha.Location = new System.Drawing.Point(274, 88);
            this.ImprimoFecha.Name = "ImprimoFecha";
            this.ImprimoFecha.Size = new System.Drawing.Size(122, 23);
            this.ImprimoFecha.TabIndex = 4;
            // 
            // Fecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(425, 154);
            this.Controls.Add(this.ImprimoFecha);
            this.Controls.Add(this.ImprimoHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VerResultado);
            this.Controls.Add(this.label1);
            this.Name = "Fecha";
            this.Text = "Fecha y Hora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VerResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImprimoHora;
        private System.Windows.Forms.TextBox ImprimoFecha;
    }
}

