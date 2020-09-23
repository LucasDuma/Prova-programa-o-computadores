namespace Programação_computadores
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.msktelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DateTimePicker();
            this.btnincluir = new System.Windows.Forms.Button();
            this.nupdinheiro = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.mskcpfalterar = new System.Windows.Forms.MaskedTextBox();
            this.msktelefonealterar = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataalterar = new System.Windows.Forms.DateTimePicker();
            this.btnalterar = new System.Windows.Forms.Button();
            this.nupdinheiroalterar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnomealterar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdinheiro)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdinheiroalterar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1014, 514);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(10, 16);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(-1, -2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1061, 551);
            this.tabControl2.TabIndex = 21;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.mskcpf);
            this.tabPage3.Controls.Add(this.msktelefone);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.data);
            this.tabPage3.Controls.Add(this.btnincluir);
            this.tabPage3.Controls.Add(this.nupdinheiro);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtnome);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1053, 525);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Incluir";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(241, 172);
            this.mskcpf.Mask = "000.000.000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(215, 20);
            this.mskcpf.TabIndex = 34;
            // 
            // msktelefone
            // 
            this.msktelefone.Location = new System.Drawing.Point(241, 119);
            this.msktelefone.Mask = "(00)00000-0000";
            this.msktelefone.Name = "msktelefone";
            this.msktelefone.Size = new System.Drawing.Size(215, 20);
            this.msktelefone.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Telefone:";
            // 
            // data
            // 
            this.data.CustomFormat = "";
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(240, 233);
            this.data.MaxDate = new System.DateTime(2020, 9, 23, 0, 0, 0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(214, 20);
            this.data.TabIndex = 30;
            this.data.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(616, 191);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(272, 74);
            this.btnincluir.TabIndex = 29;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // nupdinheiro
            // 
            this.nupdinheiro.DecimalPlaces = 2;
            this.nupdinheiro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupdinheiro.Location = new System.Drawing.Point(239, 304);
            this.nupdinheiro.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nupdinheiro.Name = "nupdinheiro";
            this.nupdinheiro.Size = new System.Drawing.Size(215, 20);
            this.nupdinheiro.TabIndex = 27;
            this.nupdinheiro.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Dinheiro em conta:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Data de nascimento:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "CPF:";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(241, 70);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(215, 20);
            this.txtnome.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Nome Completo:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox1);
            this.tabPage4.Controls.Add(this.btnexcluir);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.mskcpfalterar);
            this.tabPage4.Controls.Add(this.msktelefonealterar);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.dataalterar);
            this.tabPage4.Controls.Add(this.btnalterar);
            this.tabPage4.Controls.Add(this.nupdinheiroalterar);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtnomealterar);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1053, 525);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Alterar/Excluir";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(49, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(430, 344);
            this.listBox1.TabIndex = 39;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(783, 393);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(169, 49);
            this.btnexcluir.TabIndex = 38;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(204, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Cadastros";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(768, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Altere os dados:";
            // 
            // mskcpfalterar
            // 
            this.mskcpfalterar.Location = new System.Drawing.Point(677, 188);
            this.mskcpfalterar.Mask = "000.000.000-00";
            this.mskcpfalterar.Name = "mskcpfalterar";
            this.mskcpfalterar.Size = new System.Drawing.Size(307, 26);
            this.mskcpfalterar.TabIndex = 34;
            // 
            // msktelefonealterar
            // 
            this.msktelefonealterar.Location = new System.Drawing.Point(677, 143);
            this.msktelefonealterar.Mask = "(00)99999-9999";
            this.msktelefonealterar.Name = "msktelefonealterar";
            this.msktelefonealterar.Size = new System.Drawing.Size(307, 26);
            this.msktelefonealterar.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Telefone:";
            // 
            // dataalterar
            // 
            this.dataalterar.Location = new System.Drawing.Point(677, 234);
            this.dataalterar.Name = "dataalterar";
            this.dataalterar.Size = new System.Drawing.Size(307, 26);
            this.dataalterar.TabIndex = 30;
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(550, 393);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(175, 49);
            this.btnalterar.TabIndex = 29;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // nupdinheiroalterar
            // 
            this.nupdinheiroalterar.DecimalPlaces = 2;
            this.nupdinheiroalterar.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nupdinheiroalterar.Location = new System.Drawing.Point(677, 283);
            this.nupdinheiroalterar.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nupdinheiroalterar.Name = "nupdinheiroalterar";
            this.nupdinheiroalterar.Size = new System.Drawing.Size(307, 26);
            this.nupdinheiroalterar.TabIndex = 27;
            this.nupdinheiroalterar.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dinheiro em conta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Data de nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(515, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "CPF:";
            // 
            // txtnomealterar
            // 
            this.txtnomealterar.Location = new System.Drawing.Point(677, 90);
            this.txtnomealterar.Name = "txtnomealterar";
            this.txtnomealterar.Size = new System.Drawing.Size(307, 26);
            this.txtnomealterar.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome Completo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 542);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdinheiro)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdinheiroalterar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MaskedTextBox mskcpf;
        private System.Windows.Forms.MaskedTextBox msktelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.NumericUpDown nupdinheiro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mskcpfalterar;
        private System.Windows.Forms.MaskedTextBox msktelefonealterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dataalterar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.NumericUpDown nupdinheiroalterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnomealterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

