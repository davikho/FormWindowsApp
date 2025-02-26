namespace primerform
{
    partial class Persona1
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
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.direcion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.TextBox();
            this.cedula = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.comentario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese su nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(154, 62);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(224, 22);
            this.nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ingrese su edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "cedula";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // direcion
            // 
            this.direcion.AutoSize = true;
            this.direcion.Location = new System.Drawing.Point(151, 226);
            this.direcion.Name = "direcion";
            this.direcion.Size = new System.Drawing.Size(62, 16);
            this.direcion.TabIndex = 4;
            this.direcion.Text = "direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "comentario";
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(154, 121);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(224, 22);
            this.edad.TabIndex = 6;
            // 
            // cedula
            // 
            this.cedula.Location = new System.Drawing.Point(154, 188);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(100, 22);
            this.cedula.TabIndex = 7;
            this.cedula.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // direccion
            // 
            this.direccion.Location = new System.Drawing.Point(154, 257);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(100, 22);
            this.direccion.TabIndex = 8;
            // 
            // comentario
            // 
            this.comentario.Location = new System.Drawing.Point(154, 326);
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(100, 22);
            this.comentario.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 64);
            this.button1.TabIndex = 10;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "ver lista";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(545, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 276);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Persona1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comentario);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "Persona1";
            this.Text = "Persona1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label direcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox cedula;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox comentario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
    }
}