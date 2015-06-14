namespace PsicoManager
{
    partial class FrmAgendaNovo
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
            this.label5 = new System.Windows.Forms.Label();
            this.lblSalvar = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dpHora = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cboPaciente = new System.Windows.Forms.ComboBox();
            this.dpData = new System.Windows.Forms.DateTimePicker();
            this.lblNovoPaciente = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agenda - Cadastro";
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
            this.lblVoltar.Location = new System.Drawing.Point(147, 466);
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
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(8, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data";
            // 
            // lblSalvar
            // 
            this.lblSalvar.AllowDrop = true;
            this.lblSalvar.AutoEllipsis = true;
            this.lblSalvar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalvar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSalvar.Location = new System.Drawing.Point(13, 466);
            this.lblSalvar.Name = "lblSalvar";
            this.lblSalvar.Size = new System.Drawing.Size(128, 35);
            this.lblSalvar.TabIndex = 12;
            this.lblSalvar.Text = "Salvar";
            this.lblSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalvar.Click += new System.EventHandler(this.lblSalvar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 259);
            this.txtObservacao.MaxLength = 500;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(1072, 94);
            this.txtObservacao.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label14.Location = new System.Drawing.Point(14, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "Observação";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNovoPaciente);
            this.groupBox2.Controls.Add(this.dpHora);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cboPaciente);
            this.groupBox2.Controls.Add(this.dpData);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1072, 142);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pessoal";
            // 
            // dpHora
            // 
            this.dpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpHora.Location = new System.Drawing.Point(115, 101);
            this.dpHora.Name = "dpHora";
            this.dpHora.Size = new System.Drawing.Size(97, 20);
            this.dpHora.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label15.Location = new System.Drawing.Point(111, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Hora";
            // 
            // cboPaciente
            // 
            this.cboPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPaciente.FormattingEnabled = true;
            this.cboPaciente.Location = new System.Drawing.Point(12, 46);
            this.cboPaciente.MaxLength = 100;
            this.cboPaciente.Name = "cboPaciente";
            this.cboPaciente.Size = new System.Drawing.Size(521, 21);
            this.cboPaciente.Sorted = true;
            this.cboPaciente.TabIndex = 26;
            // 
            // dpData
            // 
            this.dpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpData.Location = new System.Drawing.Point(12, 101);
            this.dpData.Name = "dpData";
            this.dpData.Size = new System.Drawing.Size(97, 20);
            this.dpData.TabIndex = 21;
            // 
            // lblNovoPaciente
            // 
            this.lblNovoPaciente.AllowDrop = true;
            this.lblNovoPaciente.AutoEllipsis = true;
            this.lblNovoPaciente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNovoPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoPaciente.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNovoPaciente.Location = new System.Drawing.Point(539, 46);
            this.lblNovoPaciente.Name = "lblNovoPaciente";
            this.lblNovoPaciente.Size = new System.Drawing.Size(139, 21);
            this.lblNovoPaciente.TabIndex = 31;
            this.lblNovoPaciente.Text = "Novo Paciente";
            this.lblNovoPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNovoPaciente.Click += new System.EventHandler(this.lblNovoPaciente_Click);
            // 
            // FrmAgendaNovo
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
            this.Name = "FrmAgendaNovo";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmAgendaNovo_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSalvar;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dpData;
        private System.Windows.Forms.DateTimePicker dpHora;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboPaciente;
        private System.Windows.Forms.Label lblNovoPaciente;
    }
}