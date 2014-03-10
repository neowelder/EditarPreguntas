namespace EditarPreguntas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rondas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ans1 = new System.Windows.Forms.TextBox();
            this.ans2 = new System.Windows.Forms.TextBox();
            this.ans3 = new System.Windows.Forms.TextBox();
            this.ans4 = new System.Windows.Forms.TextBox();
            this.ans5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pts1 = new System.Windows.Forms.TextBox();
            this.pts2 = new System.Windows.Forms.TextBox();
            this.pts3 = new System.Windows.Forms.TextBox();
            this.pts4 = new System.Windows.Forms.TextBox();
            this.pts5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_ronda = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(530, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rondas
            // 
            this.rondas.FormattingEnabled = true;
            this.rondas.Location = new System.Drawing.Point(12, 12);
            this.rondas.Name = "rondas";
            this.rondas.Size = new System.Drawing.Size(139, 277);
            this.rondas.TabIndex = 1;
            this.rondas.SelectedIndexChanged += new System.EventHandler(this.rondas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pregunta";
            // 
            // question
            // 
            this.question.Location = new System.Drawing.Point(259, 81);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(248, 20);
            this.question.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "1.-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "2.-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "3.-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "4.-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "5.-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Respuesta";
            // 
            // ans1
            // 
            this.ans1.Location = new System.Drawing.Point(210, 161);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(168, 20);
            this.ans1.TabIndex = 10;
            // 
            // ans2
            // 
            this.ans2.Location = new System.Drawing.Point(210, 187);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(168, 20);
            this.ans2.TabIndex = 11;
            // 
            // ans3
            // 
            this.ans3.Location = new System.Drawing.Point(210, 213);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(168, 20);
            this.ans3.TabIndex = 12;
            // 
            // ans4
            // 
            this.ans4.Location = new System.Drawing.Point(210, 239);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(168, 20);
            this.ans4.TabIndex = 13;
            // 
            // ans5
            // 
            this.ans5.Location = new System.Drawing.Point(210, 265);
            this.ans5.Name = "ans5";
            this.ans5.Size = new System.Drawing.Size(168, 20);
            this.ans5.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Puntaje";
            // 
            // pts1
            // 
            this.pts1.Location = new System.Drawing.Point(407, 161);
            this.pts1.Name = "pts1";
            this.pts1.Size = new System.Drawing.Size(100, 20);
            this.pts1.TabIndex = 16;
            // 
            // pts2
            // 
            this.pts2.Location = new System.Drawing.Point(407, 187);
            this.pts2.Name = "pts2";
            this.pts2.Size = new System.Drawing.Size(100, 20);
            this.pts2.TabIndex = 17;
            // 
            // pts3
            // 
            this.pts3.Location = new System.Drawing.Point(407, 213);
            this.pts3.Name = "pts3";
            this.pts3.Size = new System.Drawing.Size(100, 20);
            this.pts3.TabIndex = 18;
            // 
            // pts4
            // 
            this.pts4.Location = new System.Drawing.Point(407, 239);
            this.pts4.Name = "pts4";
            this.pts4.Size = new System.Drawing.Size(100, 20);
            this.pts4.TabIndex = 19;
            // 
            // pts5
            // 
            this.pts5.Location = new System.Drawing.Point(407, 265);
            this.pts5.Name = "pts5";
            this.pts5.Size = new System.Drawing.Size(100, 20);
            this.pts5.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(175, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "100 Mexicanos Dijeron";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(176, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(192, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Editar preguntas, respuestas y puntajes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_ronda
            // 
            this.label_ronda.AutoSize = true;
            this.label_ronda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ronda.Location = new System.Drawing.Point(176, 58);
            this.label_ronda.Name = "label_ronda";
            this.label_ronda.Size = new System.Drawing.Size(217, 16);
            this.label_ronda.TabIndex = 24;
            this.label_ronda.Text = "*** Selecciona una ronda de la lista";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(218, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Diseñado y Elaborado para NeoWelder Labs";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 322);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "por evilnapsis";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 335);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 13);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://neowelder.com";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 380);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_ronda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pts5);
            this.Controls.Add(this.pts4);
            this.Controls.Add(this.pts3);
            this.Controls.Add(this.pts2);
            this.Controls.Add(this.pts1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ans5);
            this.Controls.Add(this.ans4);
            this.Controls.Add(this.ans3);
            this.Controls.Add(this.ans2);
            this.Controls.Add(this.ans1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.question);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rondas);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Preguntas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox rondas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ans1;
        private System.Windows.Forms.TextBox ans2;
        private System.Windows.Forms.TextBox ans3;
        private System.Windows.Forms.TextBox ans4;
        private System.Windows.Forms.TextBox ans5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pts1;
        private System.Windows.Forms.TextBox pts2;
        private System.Windows.Forms.TextBox pts3;
        private System.Windows.Forms.TextBox pts4;
        private System.Windows.Forms.TextBox pts5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_ronda;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button2;
    }
}

