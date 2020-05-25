namespace App
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txb01 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbProfessoras = new System.Windows.Forms.GroupBox();
            this.gpbProfessores = new System.Windows.Forms.GroupBox();
            this.btnFoward = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.clbProfessor = new System.Windows.Forms.CheckedListBox();
            this.clbProfessora = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpbProfessoras.SuspendLayout();
            this.gpbProfessores.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.btnTotal);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Controls.Add(this.btnZero);
            this.tabPage1.Controls.Add(this.btn3);
            this.tabPage1.Controls.Add(this.btn2);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.btn6);
            this.tabPage1.Controls.Add(this.btn5);
            this.tabPage1.Controls.Add(this.btn4);
            this.tabPage1.Controls.Add(this.btn9);
            this.tabPage1.Controls.Add(this.btn8);
            this.tabPage1.Controls.Add(this.btn7);
            this.tabPage1.Controls.Add(this.txb01);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exercicio 01";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(217, 247);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "00000";
            // 
            // listBox1
            // 
            this.listBox1.FormatString = "N0";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(220, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 212);
            this.listBox1.TabIndex = 14;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(22, 242);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(168, 23);
            this.btnTotal.TabIndex = 13;
            this.btnTotal.Text = "TOTAL";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(153, 159);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(37, 77);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(153, 60);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(37, 74);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(22, 208);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(126, 28);
            this.btnZero.TabIndex = 10;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(112, 164);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(36, 38);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(67, 164);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 38);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(22, 164);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 38);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(112, 113);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(36, 38);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(67, 113);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 38);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(22, 113);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(36, 38);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(112, 60);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(36, 38);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(67, 60);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(36, 38);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(22, 60);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(36, 38);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // txb01
            // 
            this.txb01.Location = new System.Drawing.Point(22, 27);
            this.txb01.Name = "txb01";
            this.txb01.Size = new System.Drawing.Size(168, 20);
            this.txb01.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.btnFoward);
            this.tabPage2.Controls.Add(this.gpbProfessoras);
            this.tabPage2.Controls.Add(this.gpbProfessores);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exercicio 02";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(127, 360);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(111, 29);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "22:54:04";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Professores",
            "Professoras"});
            this.comboBox1.Location = new System.Drawing.Point(71, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione:";
            // 
            // gpbProfessoras
            // 
            this.gpbProfessoras.Controls.Add(this.clbProfessora);
            this.gpbProfessoras.Location = new System.Drawing.Point(8, 54);
            this.gpbProfessoras.Name = "gpbProfessoras";
            this.gpbProfessoras.Size = new System.Drawing.Size(147, 100);
            this.gpbProfessoras.TabIndex = 2;
            this.gpbProfessoras.TabStop = false;
            this.gpbProfessoras.Text = "Professoras";
            this.gpbProfessoras.Visible = false;
            // 
            // gpbProfessores
            // 
            this.gpbProfessores.Controls.Add(this.clbProfessor);
            this.gpbProfessores.Location = new System.Drawing.Point(8, 54);
            this.gpbProfessores.Name = "gpbProfessores";
            this.gpbProfessores.Size = new System.Drawing.Size(147, 100);
            this.gpbProfessores.TabIndex = 0;
            this.gpbProfessores.TabStop = false;
            this.gpbProfessores.Text = "Professores";
            this.gpbProfessores.Visible = false;
            // 
            // btnFoward
            // 
            this.btnFoward.Location = new System.Drawing.Point(170, 96);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(34, 23);
            this.btnFoward.TabIndex = 0;
            this.btnFoward.Text = ">>>";
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(219, 54);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(136, 173);
            this.listBox2.TabIndex = 3;
            // 
            // clbProfessor
            // 
            this.clbProfessor.FormattingEnabled = true;
            this.clbProfessor.Items.AddRange(new object[] {
            "Professor 01",
            "Professor 02",
            "Professor 03"});
            this.clbProfessor.Location = new System.Drawing.Point(6, 19);
            this.clbProfessor.Name = "clbProfessor";
            this.clbProfessor.Size = new System.Drawing.Size(135, 64);
            this.clbProfessor.TabIndex = 0;
            // 
            // clbProfessora
            // 
            this.clbProfessora.FormattingEnabled = true;
            this.clbProfessora.Items.AddRange(new object[] {
            "Professora 01",
            "Professora 02",
            "Professora 03"});
            this.clbProfessora.Location = new System.Drawing.Point(6, 19);
            this.clbProfessora.Name = "clbProfessora";
            this.clbProfessora.Size = new System.Drawing.Size(135, 64);
            this.clbProfessora.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 398);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gpbProfessoras.ResumeLayout(false);
            this.gpbProfessores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txb01;
        private System.Windows.Forms.GroupBox gpbProfessoras;
        private System.Windows.Forms.GroupBox gpbProfessores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnFoward;
        private System.Windows.Forms.CheckedListBox clbProfessora;
        private System.Windows.Forms.CheckedListBox clbProfessor;
        private System.Windows.Forms.Button button1;
    }
}

