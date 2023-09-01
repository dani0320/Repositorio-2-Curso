namespace AplicacionWindows_2
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.tbxResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(21, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 14);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "Nombre: ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(21, 48);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(50, 14);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "Apellido:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(21, 92);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(34, 14);
            this.lbl3.TabIndex = 8;
            this.lbl3.Text = "Edad:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(21, 129);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(59, 14);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "Dirección: ";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(21, 168);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(88, 14);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Resultados: ";
            // 
            // tbx1
            // 
            this.tbx1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx1.Location = new System.Drawing.Point(78, 9);
            this.tbx1.MaxLength = 10;
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(392, 20);
            this.tbx1.TabIndex = 0;
            this.tbx1.Validated += new System.EventHandler(this.tbx1_Validated);
            // 
            // tbx4
            // 
            this.tbx4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx4.Location = new System.Drawing.Point(78, 126);
            this.tbx4.MaxLength = 18;
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(392, 20);
            this.tbx4.TabIndex = 3;
            this.tbx4.Validated += new System.EventHandler(this.tbx4_Validated);
            // 
            // tbx3
            // 
            this.tbx3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx3.Location = new System.Drawing.Point(78, 89);
            this.tbx3.MaxLength = 3;
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(61, 20);
            this.tbx3.TabIndex = 2;
            this.tbx3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx3_KeyPress);
            this.tbx3.Validated += new System.EventHandler(this.tbx3_Validated);
            // 
            // tbx2
            // 
            this.tbx2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbx2.Location = new System.Drawing.Point(78, 45);
            this.tbx2.MaxLength = 10;
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(392, 20);
            this.tbx2.TabIndex = 1;
            this.tbx2.Validated += new System.EventHandler(this.tbx2_Validated);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(112, 401);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Aceptar ";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(326, 401);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Cancelar ";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // tbxResultado
            // 
            this.tbxResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxResultado.Enabled = false;
            this.tbxResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxResultado.Location = new System.Drawing.Point(78, 200);
            this.tbxResultado.Multiline = true;
            this.tbxResultado.Name = "tbxResultado";
            this.tbxResultado.Size = new System.Drawing.Size(392, 172);
            this.tbxResultado.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.tbxResultado);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx4);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.MaximumSize = new System.Drawing.Size(544, 489);
            this.MinimumSize = new System.Drawing.Size(544, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox tbxResultado;
    }
}

