namespace primerform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chsuma = new System.Windows.Forms.CheckBox();
            this.chresta = new System.Windows.Forms.CheckBox();
            this.chmultiplicar = new System.Windows.Forms.CheckBox();
            this.chdiv = new System.Windows.Forms.CheckBox();
            this.chmodu = new System.Windows.Forms.CheckBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(420, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(62, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(338, 269);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "operaciones básicas";
            // 
            // chsuma
            // 
            this.chsuma.AutoSize = true;
            this.chsuma.Location = new System.Drawing.Point(308, 151);
            this.chsuma.Name = "chsuma";
            this.chsuma.Size = new System.Drawing.Size(68, 20);
            this.chsuma.TabIndex = 7;
            this.chsuma.Text = "Sumar";
            this.chsuma.UseVisualStyleBackColor = true;
            // 
            // chresta
            // 
            this.chresta.AutoSize = true;
            this.chresta.Location = new System.Drawing.Point(413, 151);
            this.chresta.Name = "chresta";
            this.chresta.Size = new System.Drawing.Size(69, 20);
            this.chresta.TabIndex = 8;
            this.chresta.Text = "Restar";
            this.chresta.UseVisualStyleBackColor = true;
            // 
            // chmultiplicar
            // 
            this.chmultiplicar.AutoSize = true;
            this.chmultiplicar.Location = new System.Drawing.Point(308, 186);
            this.chmultiplicar.Name = "chmultiplicar";
            this.chmultiplicar.Size = new System.Drawing.Size(89, 20);
            this.chmultiplicar.TabIndex = 9;
            this.chmultiplicar.Text = "Multiplicar";
            this.chmultiplicar.UseVisualStyleBackColor = true;
            // 
            // chdiv
            // 
            this.chdiv.AutoSize = true;
            this.chdiv.Location = new System.Drawing.Point(413, 186);
            this.chdiv.Name = "chdiv";
            this.chdiv.Size = new System.Drawing.Size(67, 20);
            this.chdiv.TabIndex = 10;
            this.chdiv.Text = "Dividir";
            this.chdiv.UseVisualStyleBackColor = true;
            // 
            // chmodu
            // 
            this.chmodu.AutoSize = true;
            this.chmodu.Location = new System.Drawing.Point(308, 221);
            this.chmodu.Name = "chmodu";
            this.chmodu.Size = new System.Drawing.Size(74, 20);
            this.chmodu.TabIndex = 11;
            this.chmodu.Text = "Módulo";
            this.chmodu.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.Highlight;
            this.result.Location = new System.Drawing.Point(324, 316);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(132, 25);
            this.result.TabIndex = 12;
            this.result.Text = "Resultados: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.result);
            this.Controls.Add(this.chmodu);
            this.Controls.Add(this.chdiv);
            this.Controls.Add(this.chmultiplicar);
            this.Controls.Add(this.chresta);
            this.Controls.Add(this.chsuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ControlesDavid";
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form1_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chsuma;
        private System.Windows.Forms.CheckBox chresta;
        private System.Windows.Forms.CheckBox chmultiplicar;
        private System.Windows.Forms.CheckBox chdiv;
        private System.Windows.Forms.CheckBox chmodu;
        private System.Windows.Forms.Label result;
    }
}

