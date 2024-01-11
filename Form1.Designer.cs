namespace V2_Biblioteca
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabalunos = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.textMatricula = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.textAluno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tablivros = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtexcluirlivros = new System.Windows.Forms.Button();
            this.txtatualizarlivros = new System.Windows.Forms.Button();
            this.txtexibirlivros = new System.Windows.Forms.Button();
            this.txtinserirlivros = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtexibiremprestimo = new System.Windows.Forms.Button();
            this.txtinseriremprestimo = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabalunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tablivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabalunos);
            this.tabControl.Controls.Add(this.tablivros);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 437);
            this.tabControl.TabIndex = 0;
            // 
            // tabalunos
            // 
            this.tabalunos.Controls.Add(this.dgvDados);
            this.tabalunos.Controls.Add(this.button4);
            this.tabalunos.Controls.Add(this.button3);
            this.tabalunos.Controls.Add(this.btn);
            this.tabalunos.Controls.Add(this.btnInserir);
            this.tabalunos.Controls.Add(this.textMatricula);
            this.tabalunos.Controls.Add(this.textCpf);
            this.tabalunos.Controls.Add(this.textAluno);
            this.tabalunos.Controls.Add(this.label3);
            this.tabalunos.Controls.Add(this.label2);
            this.tabalunos.Controls.Add(this.label1);
            this.tabalunos.Location = new System.Drawing.Point(4, 22);
            this.tabalunos.Name = "tabalunos";
            this.tabalunos.Padding = new System.Windows.Forms.Padding(3);
            this.tabalunos.Size = new System.Drawing.Size(768, 411);
            this.tabalunos.TabIndex = 0;
            this.tabalunos.Text = "Alunos";
            this.tabalunos.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(6, 190);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(756, 215);
            this.dgvDados.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(127, 146);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 7;
            this.btn.Text = "Exibir";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(30, 146);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 6;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textMatricula
            // 
            this.textMatricula.Location = new System.Drawing.Point(85, 98);
            this.textMatricula.Name = "textMatricula";
            this.textMatricula.Size = new System.Drawing.Size(240, 20);
            this.textMatricula.TabIndex = 5;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(85, 63);
            this.textCpf.Mask = "000.000.000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(240, 20);
            this.textCpf.TabIndex = 4;
            this.textCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // textAluno
            // 
            this.textAluno.Location = new System.Drawing.Point(85, 25);
            this.textAluno.Name = "textAluno";
            this.textAluno.Size = new System.Drawing.Size(240, 20);
            this.textAluno.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // tablivros
            // 
            this.tablivros.Controls.Add(this.dataGridView3);
            this.tablivros.Controls.Add(this.txtexcluirlivros);
            this.tablivros.Controls.Add(this.txtatualizarlivros);
            this.tablivros.Controls.Add(this.txtexibirlivros);
            this.tablivros.Controls.Add(this.txtinserirlivros);
            this.tablivros.Controls.Add(this.button7);
            this.tablivros.Controls.Add(this.textBox8);
            this.tablivros.Controls.Add(this.textBox7);
            this.tablivros.Controls.Add(this.label9);
            this.tablivros.Controls.Add(this.label8);
            this.tablivros.Location = new System.Drawing.Point(4, 22);
            this.tablivros.Name = "tablivros";
            this.tablivros.Padding = new System.Windows.Forms.Padding(3);
            this.tablivros.Size = new System.Drawing.Size(768, 411);
            this.tablivros.TabIndex = 1;
            this.tablivros.Text = "Livros";
            this.tablivros.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 171);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(756, 224);
            this.dataGridView3.TabIndex = 14;
            // 
            // txtexcluirlivros
            // 
            this.txtexcluirlivros.Location = new System.Drawing.Point(322, 117);
            this.txtexcluirlivros.Name = "txtexcluirlivros";
            this.txtexcluirlivros.Size = new System.Drawing.Size(75, 23);
            this.txtexcluirlivros.TabIndex = 13;
            this.txtexcluirlivros.Text = "Excluir";
            this.txtexcluirlivros.UseVisualStyleBackColor = true;
            this.txtexcluirlivros.Click += new System.EventHandler(this.txtexcluirlivros_Click);
            // 
            // txtatualizarlivros
            // 
            this.txtatualizarlivros.Location = new System.Drawing.Point(220, 117);
            this.txtatualizarlivros.Name = "txtatualizarlivros";
            this.txtatualizarlivros.Size = new System.Drawing.Size(75, 23);
            this.txtatualizarlivros.TabIndex = 12;
            this.txtatualizarlivros.Text = "Atualizar";
            this.txtatualizarlivros.UseVisualStyleBackColor = true;
            this.txtatualizarlivros.Click += new System.EventHandler(this.txtatualizarlivros_Click);
            // 
            // txtexibirlivros
            // 
            this.txtexibirlivros.Location = new System.Drawing.Point(122, 117);
            this.txtexibirlivros.Name = "txtexibirlivros";
            this.txtexibirlivros.Size = new System.Drawing.Size(75, 23);
            this.txtexibirlivros.TabIndex = 11;
            this.txtexibirlivros.Text = "Exibir";
            this.txtexibirlivros.UseVisualStyleBackColor = true;
            this.txtexibirlivros.Click += new System.EventHandler(this.txtexibirlivros_Click);
            // 
            // txtinserirlivros
            // 
            this.txtinserirlivros.Location = new System.Drawing.Point(25, 117);
            this.txtinserirlivros.Name = "txtinserirlivros";
            this.txtinserirlivros.Size = new System.Drawing.Size(75, 23);
            this.txtinserirlivros.TabIndex = 10;
            this.txtinserirlivros.Text = "Inserir";
            this.txtinserirlivros.UseVisualStyleBackColor = true;
            this.txtinserirlivros.Click += new System.EventHandler(this.txtinserirlivros_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(388, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(8, 8);
            this.button7.TabIndex = 4;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(81, 67);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(216, 20);
            this.textBox8.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(81, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(216, 20);
            this.textBox7.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Autor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Título:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.txtexibiremprestimo);
            this.tabPage1.Controls.Add(this.txtinseriremprestimo);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 411);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Empréstimos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 216);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(756, 189);
            this.dataGridView2.TabIndex = 10;
            // 
            // txtexibiremprestimo
            // 
            this.txtexibiremprestimo.Location = new System.Drawing.Point(139, 170);
            this.txtexibiremprestimo.Name = "txtexibiremprestimo";
            this.txtexibiremprestimo.Size = new System.Drawing.Size(75, 23);
            this.txtexibiremprestimo.TabIndex = 9;
            this.txtexibiremprestimo.Text = "Exibir";
            this.txtexibiremprestimo.UseVisualStyleBackColor = true;
            this.txtexibiremprestimo.Click += new System.EventHandler(this.txtexibiremprestimo_Click);
            // 
            // txtinseriremprestimo
            // 
            this.txtinseriremprestimo.Location = new System.Drawing.Point(40, 170);
            this.txtinseriremprestimo.Name = "txtinseriremprestimo";
            this.txtinseriremprestimo.Size = new System.Drawing.Size(75, 23);
            this.txtinseriremprestimo.TabIndex = 8;
            this.txtinseriremprestimo.Text = "Inserir";
            this.txtinseriremprestimo.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(139, 113);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(229, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(139, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(229, 20);
            this.textBox5.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 20);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(229, 20);
            this.textBox3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Data Devolução:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data Empréstimo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cod. Livro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cod. Aluno:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabalunos.ResumeLayout(false);
            this.tabalunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tablivros.ResumeLayout(false);
            this.tablivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabalunos;
        private System.Windows.Forms.TabPage tablivros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox textMatricula;
        private System.Windows.Forms.MaskedTextBox textCpf;
        private System.Windows.Forms.TextBox textAluno;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button txtexibiremprestimo;
        private System.Windows.Forms.Button txtinseriremprestimo;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button txtexcluirlivros;
        private System.Windows.Forms.Button txtatualizarlivros;
        private System.Windows.Forms.Button txtexibirlivros;
        private System.Windows.Forms.Button txtinserirlivros;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

