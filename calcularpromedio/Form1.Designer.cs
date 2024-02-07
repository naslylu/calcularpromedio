namespace calcularpromedio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_P1 = new System.Windows.Forms.TextBox();
            this.btn_CalcularPromedio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_P2 = new System.Windows.Forms.TextBox();
            this.txt_P3 = new System.Windows.Forms.TextBox();
            this.txt_P4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_BorrarTodo = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P1";
            // 
            // txt_P1
            // 
            this.txt_P1.Location = new System.Drawing.Point(213, 32);
            this.txt_P1.Name = "txt_P1";
            this.txt_P1.Size = new System.Drawing.Size(100, 20);
            this.txt_P1.TabIndex = 1;
            // 
            // btn_CalcularPromedio
            // 
            this.btn_CalcularPromedio.BackColor = System.Drawing.Color.LightGreen;
            this.btn_CalcularPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularPromedio.Location = new System.Drawing.Point(150, 226);
            this.btn_CalcularPromedio.Name = "btn_CalcularPromedio";
            this.btn_CalcularPromedio.Size = new System.Drawing.Size(138, 23);
            this.btn_CalcularPromedio.TabIndex = 2;
            this.btn_CalcularPromedio.Text = "Calcular Promedio";
            this.btn_CalcularPromedio.UseVisualStyleBackColor = false;
            this.btn_CalcularPromedio.Click += new System.EventHandler(this.btn_CalcularPromedio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "P2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "P3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "P4";
            // 
            // txt_P2
            // 
            this.txt_P2.Location = new System.Drawing.Point(213, 70);
            this.txt_P2.Name = "txt_P2";
            this.txt_P2.Size = new System.Drawing.Size(100, 20);
            this.txt_P2.TabIndex = 7;
            // 
            // txt_P3
            // 
            this.txt_P3.Location = new System.Drawing.Point(213, 116);
            this.txt_P3.Name = "txt_P3";
            this.txt_P3.Size = new System.Drawing.Size(100, 20);
            this.txt_P3.TabIndex = 8;
            this.txt_P3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_P4
            // 
            this.txt_P4.Location = new System.Drawing.Point(213, 162);
            this.txt_P4.Name = "txt_P4";
            this.txt_P4.Size = new System.Drawing.Size(100, 20);
            this.txt_P4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "CALIFICACIONES";
            // 
            // btn_BorrarTodo
            // 
            this.btn_BorrarTodo.BackColor = System.Drawing.Color.LightGreen;
            this.btn_BorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrarTodo.Location = new System.Drawing.Point(150, 266);
            this.btn_BorrarTodo.Name = "btn_BorrarTodo";
            this.btn_BorrarTodo.Size = new System.Drawing.Size(137, 23);
            this.btn_BorrarTodo.TabIndex = 12;
            this.btn_BorrarTodo.Text = "Borrar Todo";
            this.btn_BorrarTodo.UseVisualStyleBackColor = false;
            this.btn_BorrarTodo.Click += new System.EventHandler(this.btn_BorrarTodo_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(183, 306);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 13;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_BorrarTodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_P4);
            this.Controls.Add(this.txt_P3);
            this.Controls.Add(this.txt_P2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_CalcularPromedio);
            this.Controls.Add(this.txt_P1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_P1;
        private System.Windows.Forms.Button btn_CalcularPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_P2;
        private System.Windows.Forms.TextBox txt_P3;
        private System.Windows.Forms.TextBox txt_P4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_BorrarTodo;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

