﻿namespace PsicoManager
{
    partial class FrmFuncionarios
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
            this.lblNovo = new System.Windows.Forms.Label();
            this.gridFuncionarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionários";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 2);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblNovo
            // 
            this.lblNovo.AllowDrop = true;
            this.lblNovo.AutoEllipsis = true;
            this.lblNovo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNovo.Location = new System.Drawing.Point(961, 75);
            this.lblNovo.Name = "lblNovo";
            this.lblNovo.Size = new System.Drawing.Size(128, 35);
            this.lblNovo.TabIndex = 12;
            this.lblNovo.Text = "Novo";
            this.lblNovo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNovo.Click += new System.EventHandler(this.lblNovo_Click);
            // 
            // gridFuncionarios
            // 
            this.gridFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFuncionarios.Location = new System.Drawing.Point(18, 117);
            this.gridFuncionarios.Name = "gridFuncionarios";
            this.gridFuncionarios.Size = new System.Drawing.Size(1071, 348);
            this.gridFuncionarios.TabIndex = 13;
            this.gridFuncionarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPacientes_CellClick);
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 477);
            this.Controls.Add(this.gridFuncionarios);
            this.Controls.Add(this.lblNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmFuncionarios";
            this.Text = "FrmHome";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNovo;
        private System.Windows.Forms.DataGridView gridFuncionarios;
    }
}