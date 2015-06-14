namespace PsicoManager
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.lblHome = new System.Windows.Forms.Label();
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.lblPagamentos = new System.Windows.Forms.Label();
            this.lblFuncionarios = new System.Windows.Forms.Label();
            this.lblAjuda = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PsicoManager";
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 96);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1111, 546);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.ShadowStyle = SkinSoft.VisualStyler.ShadowStyle.None;
            this.visualStyler1.LoadVisualStyle(null, "Windows Metro (White).vssf");
            // 
            // lblHome
            // 
            this.lblHome.AllowDrop = true;
            this.lblHome.AutoEllipsis = true;
            this.lblHome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHome.Location = new System.Drawing.Point(12, 54);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(128, 35);
            this.lblHome.TabIndex = 2;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblPacientes
            // 
            this.lblPacientes.AllowDrop = true;
            this.lblPacientes.AutoEllipsis = true;
            this.lblPacientes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacientes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPacientes.Location = new System.Drawing.Point(146, 54);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(168, 35);
            this.lblPacientes.TabIndex = 3;
            this.lblPacientes.Text = "Pacientes";
            this.lblPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPacientes.Click += new System.EventHandler(this.lblPacientes_Click);
            // 
            // lblAgenda
            // 
            this.lblAgenda.AllowDrop = true;
            this.lblAgenda.AutoEllipsis = true;
            this.lblAgenda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAgenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAgenda.Location = new System.Drawing.Point(320, 54);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(168, 35);
            this.lblAgenda.TabIndex = 4;
            this.lblAgenda.Text = "Agenda";
            this.lblAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgenda.Click += new System.EventHandler(this.lblAgenda_Click);
            // 
            // lblPagamentos
            // 
            this.lblPagamentos.AllowDrop = true;
            this.lblPagamentos.AutoEllipsis = true;
            this.lblPagamentos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPagamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamentos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPagamentos.Location = new System.Drawing.Point(494, 54);
            this.lblPagamentos.Name = "lblPagamentos";
            this.lblPagamentos.Size = new System.Drawing.Size(168, 35);
            this.lblPagamentos.TabIndex = 5;
            this.lblPagamentos.Text = "Pagamentos";
            this.lblPagamentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPagamentos.Click += new System.EventHandler(this.lblPagamentos_Click);
            // 
            // lblFuncionarios
            // 
            this.lblFuncionarios.AllowDrop = true;
            this.lblFuncionarios.AutoEllipsis = true;
            this.lblFuncionarios.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionarios.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFuncionarios.Location = new System.Drawing.Point(668, 54);
            this.lblFuncionarios.Name = "lblFuncionarios";
            this.lblFuncionarios.Size = new System.Drawing.Size(168, 35);
            this.lblFuncionarios.TabIndex = 6;
            this.lblFuncionarios.Text = "Funcionários";
            this.lblFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFuncionarios.Click += new System.EventHandler(this.lblFuncionarios_Click);
            // 
            // lblAjuda
            // 
            this.lblAjuda.AllowDrop = true;
            this.lblAjuda.AutoEllipsis = true;
            this.lblAjuda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjuda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAjuda.Location = new System.Drawing.Point(984, 54);
            this.lblAjuda.Name = "lblAjuda";
            this.lblAjuda.Size = new System.Drawing.Size(127, 35);
            this.lblAjuda.TabIndex = 7;
            this.lblAjuda.Text = "Ajuda";
            this.lblAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAjuda.Click += new System.EventHandler(this.lblAjuda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1116, 2);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(886, 2);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNomeUsuario.Size = new System.Drawing.Size(221, 25);
            this.lblNomeUsuario.TabIndex = 9;
            this.lblNomeUsuario.Text = "Olá, Administrador";
            this.lblNomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSair
            // 
            this.lblSair.AllowDrop = true;
            this.lblSair.AutoEllipsis = true;
            this.lblSair.BackColor = System.Drawing.Color.Transparent;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.ForeColor = System.Drawing.Color.Maroon;
            this.lblSair.Location = new System.Drawing.Point(1052, 23);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(55, 26);
            this.lblSair.TabIndex = 10;
            this.lblSair.Text = "Sair";
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1119, 644);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblNomeUsuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAjuda);
            this.Controls.Add(this.lblFuncionarios);
            this.Controls.Add(this.lblPagamentos);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.lblPacientes);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPrincipal;
        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblFuncionarios;
        private System.Windows.Forms.Label lblPagamentos;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblAjuda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Label lblNomeUsuario;
    }
}

