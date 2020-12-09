namespace ChatBot.View
{
    partial class frmEnviarMensagem
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgDados = new System.Windows.Forms.DataGridView();
            this.ibtnEnviar = new FontAwesome.Sharp.IconButton();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(58, 167);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(388, 304);
            this.txtMensagem.TabIndex = 6;
            this.txtMensagem.Text = "Mensagem";
            this.txtMensagem.Enter += new System.EventHandler(this.txtMensagem_Enter);
            this.txtMensagem.Leave += new System.EventHandler(this.txtMensagem_Leave);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(58, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(388, 26);
            this.txtNome.TabIndex = 5;
            this.txtNome.Text = "Nome";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(58, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(388, 26);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Email";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // dgDados
            // 
            this.dgDados.AllowUserToAddRows = false;
            this.dgDados.AllowUserToDeleteRows = false;
            this.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDados.Location = new System.Drawing.Point(482, 37);
            this.dgDados.Name = "dgDados";
            this.dgDados.ReadOnly = true;
            this.dgDados.Size = new System.Drawing.Size(488, 434);
            this.dgDados.TabIndex = 8;
            this.dgDados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelecionarDados);
            // 
            // ibtnEnviar
            // 
            this.ibtnEnviar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ibtnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(214)))));
            this.ibtnEnviar.FlatAppearance.BorderSize = 0;
            this.ibtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEnviar.ForeColor = System.Drawing.Color.White;
            this.ibtnEnviar.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.ibtnEnviar.IconColor = System.Drawing.Color.White;
            this.ibtnEnviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEnviar.Location = new System.Drawing.Point(349, 514);
            this.ibtnEnviar.Name = "ibtnEnviar";
            this.ibtnEnviar.Size = new System.Drawing.Size(242, 75);
            this.ibtnEnviar.TabIndex = 15;
            this.ibtnEnviar.Text = "Enviar";
            this.ibtnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEnviar.UseVisualStyleBackColor = false;
            this.ibtnEnviar.Click += new System.EventHandler(this.ibtnEnviar_Click);
            this.ibtnEnviar.Leave += new System.EventHandler(this.ibtnEnviar_Leave);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(58, 121);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(388, 26);
            this.txtAssunto.TabIndex = 16;
            this.txtAssunto.Text = "Assunto";
            this.txtAssunto.Enter += new System.EventHandler(this.txtAssunto_Enter);
            // 
            // frmEnviarMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1025, 622);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.ibtnEnviar);
            this.Controls.Add(this.dgDados);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEnviarMensagem";
            this.Text = "frmEnviarMensagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgDados;
        private FontAwesome.Sharp.IconButton ibtnEnviar;
        private System.Windows.Forms.TextBox txtAssunto;
    }
}