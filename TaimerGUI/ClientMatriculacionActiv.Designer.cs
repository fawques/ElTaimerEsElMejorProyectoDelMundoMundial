﻿namespace TaimerGUI
{
    partial class ClientMatriculacionActiv
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridMatric = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridActuales = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFiltroAct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxFiltroMat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnDescart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActuales)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Matriculado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Disponibles";
            // 
            // dataGridMatric
            // 
            this.dataGridMatric.AllowUserToAddRows = false;
            this.dataGridMatric.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridMatric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nom,
            this.Column1});
            this.dataGridMatric.Location = new System.Drawing.Point(442, 182);
            this.dataGridMatric.Name = "dataGridMatric";
            this.dataGridMatric.ReadOnly = true;
            this.dataGridMatric.Size = new System.Drawing.Size(331, 373);
            this.dataGridMatric.TabIndex = 23;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nombre";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descipcion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridActuales
            // 
            this.dataGridActuales.AllowUserToAddRows = false;
            this.dataGridActuales.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridActuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridActuales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descrip});
            this.dataGridActuales.Location = new System.Drawing.Point(12, 182);
            this.dataGridActuales.Name = "dataGridActuales";
            this.dataGridActuales.ReadOnly = true;
            this.dataGridActuales.Size = new System.Drawing.Size(331, 373);
            this.dataGridActuales.TabIndex = 21;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descrip
            // 
            this.Descrip.HeaderText = "Descripcion";
            this.Descrip.Name = "Descrip";
            this.Descrip.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Matrícula";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(708, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "Agrega y elimina las asignaturas en las que deseas estar matriculado. Las asignat" +
                "uras en las que estas matriculado son las que podras utilizar en tu gestión de h" +
                "orarios.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Filtro:";
            // 
            // txtBoxFiltroAct
            // 
            this.txtBoxFiltroAct.Location = new System.Drawing.Point(61, 156);
            this.txtBoxFiltroAct.Name = "txtBoxFiltroAct";
            this.txtBoxFiltroAct.Size = new System.Drawing.Size(167, 20);
            this.txtBoxFiltroAct.TabIndex = 29;
            this.txtBoxFiltroAct.TextChanged += new System.EventHandler(this.txtBoxFiltroAct_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Filtro:";
            // 
            // txtBoxFiltroMat
            // 
            this.txtBoxFiltroMat.Location = new System.Drawing.Point(486, 156);
            this.txtBoxFiltroMat.Name = "txtBoxFiltroMat";
            this.txtBoxFiltroMat.Size = new System.Drawing.Size(167, 20);
            this.txtBoxFiltroMat.TabIndex = 31;
            this.txtBoxFiltroMat.TextChanged += new System.EventHandler(this.txtBoxFiltroMat_TextChanged);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::TaimerGUI.Properties.Resources.flechaLeft;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(376, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 43);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TaimerGUI.Properties.Resources.flechaRight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(376, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 42);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(538, 581);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(103, 33);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnDescart
            // 
            this.btnDescart.Location = new System.Drawing.Point(670, 581);
            this.btnDescart.Name = "btnDescart";
            this.btnDescart.Size = new System.Drawing.Size(103, 33);
            this.btnDescart.TabIndex = 34;
            this.btnDescart.Text = "Descartar";
            this.btnDescart.UseVisualStyleBackColor = true;
            this.btnDescart.Click += new System.EventHandler(this.btnDescart_Click);
            // 
            // ClientMatriculacionActiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(795, 635);
            this.Controls.Add(this.btnDescart);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxFiltroMat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxFiltroAct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridMatric);
            this.Controls.Add(this.dataGridActuales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientMatriculacionActiv";
            this.Text = "ClientMatriculacionActiv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.ClientMatriculacionActiv_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridActuales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridMatric;
        private System.Windows.Forms.DataGridView dataGridActuales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFiltroAct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxFiltroMat;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnDescart;
    }
}