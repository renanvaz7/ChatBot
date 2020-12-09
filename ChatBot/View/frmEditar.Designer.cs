namespace ChatBot.View
{
    partial class frmEditar
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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.ibtnEditar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(214)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.White;
            this.txtTelefone.Location = new System.Drawing.Point(69, 198);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(879, 31);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.Text = "Telefone";
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(214)))));
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.ForeColor = System.Drawing.Color.White;
            this.txtCPF.Location = new System.Drawing.Point(69, 138);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(879, 31);
            this.txtCPF.TabIndex = 6;
            this.txtCPF.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(214)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(69, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(879, 31);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(214)))));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(69, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(879, 31);
            this.txtNome.TabIndex = 4;
            this.txtNome.Text = "Nome";
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(69, 254);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.Size = new System.Drawing.Size(879, 182);
            this.dgDados.TabIndex = 8;
            this.dgDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelecionarDados);
            // 
            // ibtnEditar
            // 
            this.ibtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ibtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(214)))));
            this.ibtnEditar.FlatAppearance.BorderSize = 0;
            this.ibtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEditar.ForeColor = System.Drawing.Color.White;
            this.ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnEditar.IconColor = System.Drawing.Color.White;
            this.ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEditar.Location = new System.Drawing.Point(374, 474);
            this.ibtnEditar.Name = "ibtnEditar";
            this.ibtnEditar.Size = new System.Drawing.Size(242, 75);
            this.ibtnEditar.TabIndex = 9;
            this.ibtnEditar.Text = "Editar";
            this.ibtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEditar.UseVisualStyleBackColor = false;
            this.ibtnEditar.Click += new System.EventHandler(this.ibtnEditar_Click);
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1009, 583);
            this.Controls.Add(this.ibtnEditar);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditar";
            this.Text = "frmEditar";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgDados;
        private FontAwesome.Sharp.IconButton ibtnEditar;
    }
}