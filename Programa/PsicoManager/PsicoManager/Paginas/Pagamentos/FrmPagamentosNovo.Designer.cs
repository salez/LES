namespace PsicoManager
{
    partial class FrmPagamentosNovo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVoltar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.lblDataPagamento = new System.Windows.Forms.Label();
            this.chkPago = new System.Windows.Forms.CheckBox();
            this.cboPacientes = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.dpDataLimitePagamento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagamentos - Cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 2);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AllowDrop = true;
            this.lblVoltar.AutoEllipsis = true;
            this.lblVoltar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoltar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblVoltar.Location = new System.Drawing.Point(147, 428);
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(128, 35);
            this.lblVoltar.TabIndex = 3;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVoltar.Click += new System.EventHandler(this.lblVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paciente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(445, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Limite Pagamento";
            // 
            // lblSalvar
            // 
            this.lblSalvar.AllowDrop = true;
            this.lblSalvar.AutoEllipsis = true;
            this.lblSalvar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSalvar.Location = new System.Drawing.Point(13, 428);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(128, 35);
            this.lblSalvar.TabIndex = 12;
            this.lblSalvar.Text = "Salvar";
            this.lblSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalvar.Click += new System.EventHandler(this.lblSalvar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 260);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(1072, 139);
            this.txtObservacao.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(14, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Observação";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dpDataPagamento);
            this.groupBox2.Controls.Add(this.lblDataPagamento);
            this.groupBox2.Controls.Add(this.chkPago);
            this.groupBox2.Controls.Add(this.cboPacientes);
            this.groupBox2.Controls.Add(this.txtValor);
            this.groupBox2.Controls.Add(this.dpDataLimitePagamento);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1072, 149);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pessoal";
            // 
            // dpDataPagamento
            // 
            this.dpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataPagamento.Location = new System.Drawing.Point(254, 107);
            this.dpDataPagamento.Name = "dpDataPagamento";
            this.dpDataPagamento.Size = new System.Drawing.Size(224, 20);
            this.dpDataPagamento.TabIndex = 27;
            // 
            // lblDataPagamento
            // 
            this.lblDataPagamento.AutoSize = true;
            this.lblDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPagamento.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDataPagamento.Location = new System.Drawing.Point(250, 83);
            this.lblDataPagamento.Name = "lblDataPagamento";
            this.lblDataPagamento.Size = new System.Drawing.Size(144, 20);
            this.lblDataPagamento.TabIndex = 26;
            this.lblDataPagamento.Text = "Data Pagamento";
            // 
            // chkPago
            // 
            this.chkPago.AutoSize = true;
            this.chkPago.Location = new System.Drawing.Point(199, 109);
            this.chkPago.Name = "chkPago";
            this.chkPago.Size = new System.Drawing.Size(51, 17);
            this.chkPago.TabIndex = 25;
            this.chkPago.Text = "Pago";
            this.chkPago.UseVisualStyleBackColor = true;
            // 
            // cboPacientes
            // 
            this.cboPacientes.FormattingEnabled = true;
            this.cboPacientes.Location = new System.Drawing.Point(12, 48);
            this.cboPacientes.Name = "cboPacientes";
            this.cboPacientes.Size = new System.Drawing.Size(427, 21);
            this.cboPacientes.TabIndex = 24;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(12, 107);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(173, 20);
            this.txtValor.TabIndex = 23;
            this.txtValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // dpDataLimitePagamento
            // 
            this.dpDataLimitePagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDataLimitePagamento.Location = new System.Drawing.Point(449, 49);
            this.dpDataLimitePagamento.Name = "dpDataLimitePagamento";
            this.dpDataLimitePagamento.Size = new System.Drawing.Size(224, 20);
            this.dpDataLimitePagamento.TabIndex = 21;
            // 
            // FrmPagamentosNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblSalvar);
            this.Controls.Add(this.lblVoltar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPagamentosNovo";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmPagamentosNovo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dpDataLimitePagamento;
        private System.Windows.Forms.MaskedTextBox txtValor;
        private System.Windows.Forms.DateTimePicker dpDataPagamento;
        private System.Windows.Forms.Label lblDataPagamento;
        private System.Windows.Forms.CheckBox chkPago;
        private System.Windows.Forms.ComboBox cboPacientes;
    }
}