namespace ADS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExercicioA = new System.Windows.Forms.Button();
            this.btnExercicioB = new System.Windows.Forms.Button();
            this.btnExercicioC = new System.Windows.Forms.Button();
            this.btnExercicioD = new System.Windows.Forms.Button();
            this.btnExercicioE = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExercicioA
            // 
            this.btnExercicioA.Location = new System.Drawing.Point(154, 61);
            this.btnExercicioA.Name = "btnExercicioA";
            this.btnExercicioA.Size = new System.Drawing.Size(95, 30);
            this.btnExercicioA.TabIndex = 0;
            this.btnExercicioA.Text = "Exercicio A";
            this.btnExercicioA.UseVisualStyleBackColor = true;
            this.btnExercicioA.Click += new System.EventHandler(this.btnExercicioA_Click);
            // 
            // btnExercicioB
            // 
            this.btnExercicioB.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnExercicioB.Location = new System.Drawing.Point(255, 61);
            this.btnExercicioB.Name = "btnExercicioB";
            this.btnExercicioB.Size = new System.Drawing.Size(95, 30);
            this.btnExercicioB.TabIndex = 1;
            this.btnExercicioB.Text = "Exercicio B";
            this.btnExercicioB.UseVisualStyleBackColor = true;
            this.btnExercicioB.Click += new System.EventHandler(this.btnExercicioB_Click);
            // 
            // btnExercicioC
            // 
            this.btnExercicioC.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnExercicioC.Location = new System.Drawing.Point(356, 61);
            this.btnExercicioC.Name = "btnExercicioC";
            this.btnExercicioC.Size = new System.Drawing.Size(95, 30);
            this.btnExercicioC.TabIndex = 2;
            this.btnExercicioC.Text = "Exercicio C";
            this.btnExercicioC.UseVisualStyleBackColor = true;
            this.btnExercicioC.Click += new System.EventHandler(this.btnExercicioC_Click);
            // 
            // btnExercicioD
            // 
            this.btnExercicioD.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnExercicioD.Location = new System.Drawing.Point(457, 61);
            this.btnExercicioD.Name = "btnExercicioD";
            this.btnExercicioD.Size = new System.Drawing.Size(95, 30);
            this.btnExercicioD.TabIndex = 3;
            this.btnExercicioD.Text = "Exercicio D";
            this.btnExercicioD.UseVisualStyleBackColor = true;
            this.btnExercicioD.Click += new System.EventHandler(this.btnExercicioD_Click);
            // 
            // btnExercicioE
            // 
            this.btnExercicioE.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.btnExercicioE.Location = new System.Drawing.Point(558, 61);
            this.btnExercicioE.Name = "btnExercicioE";
            this.btnExercicioE.Size = new System.Drawing.Size(95, 30);
            this.btnExercicioE.TabIndex = 4;
            this.btnExercicioE.Text = "Exercicio E";
            this.btnExercicioE.UseVisualStyleBackColor = true;
            this.btnExercicioE.Click += new System.EventHandler(this.btnExercicioE_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(76, 177);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(664, 209);
            this.txtResultado.TabIndex = 5;
            this.txtResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnunciado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(177, 94);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(450, 80);
            this.lblEnunciado.TabIndex = 6;
            this.lblEnunciado.Text = "Selecione um exercicio";
            this.lblEnunciado.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnExercicioE);
            this.Controls.Add(this.btnExercicioD);
            this.Controls.Add(this.btnExercicioC);
            this.Controls.Add(this.btnExercicioB);
            this.Controls.Add(this.btnExercicioA);
            this.Name = "Form1";
            this.Text = "form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExercicioA;
        private System.Windows.Forms.Button btnExercicioB;
        private System.Windows.Forms.Button btnExercicioC;
        private System.Windows.Forms.Button btnExercicioD;
        private System.Windows.Forms.Button btnExercicioE;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblEnunciado;
    }
}

