namespace ChatBot
{
    partial class frmPrincipal
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnMensagem = new FontAwesome.Sharp.IconButton();
            this.ibtnSair = new FontAwesome.Sharp.IconButton();
            this.ibtnExcluir = new FontAwesome.Sharp.IconButton();
            this.ibtnListar = new FontAwesome.Sharp.IconButton();
            this.ibtnEditar = new FontAwesome.Sharp.IconButton();
            this.ibtnAdicionar = new FontAwesome.Sharp.IconButton();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(214)))));
            this.pnlMenu.Controls.Add(this.ibtnMensagem);
            this.pnlMenu.Controls.Add(this.ibtnSair);
            this.pnlMenu.Controls.Add(this.ibtnExcluir);
            this.pnlMenu.Controls.Add(this.ibtnListar);
            this.pnlMenu.Controls.Add(this.ibtnEditar);
            this.pnlMenu.Controls.Add(this.ibtnAdicionar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(243, 661);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarFormulario);
            // 
            // ibtnMensagem
            // 
            this.ibtnMensagem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ibtnMensagem.FlatAppearance.BorderSize = 0;
            this.ibtnMensagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnMensagem.ForeColor = System.Drawing.Color.White;
            this.ibtnMensagem.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.ibtnMensagem.IconColor = System.Drawing.Color.White;
            this.ibtnMensagem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnMensagem.Location = new System.Drawing.Point(3, 107);
            this.ibtnMensagem.Name = "ibtnMensagem";
            this.ibtnMensagem.Size = new System.Drawing.Size(237, 66);
            this.ibtnMensagem.TabIndex = 5;
            this.ibtnMensagem.Text = "Mensagem";
            this.ibtnMensagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnMensagem.UseVisualStyleBackColor = true;
            this.ibtnMensagem.Click += new System.EventHandler(this.ibtnMensagem_Click);
            // 
            // ibtnSair
            // 
            this.ibtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ibtnSair.FlatAppearance.BorderSize = 0;
            this.ibtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSair.ForeColor = System.Drawing.Color.White;
            this.ibtnSair.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.ibtnSair.IconColor = System.Drawing.Color.White;
            this.ibtnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSair.Location = new System.Drawing.Point(3, 583);
            this.ibtnSair.Name = "ibtnSair";
            this.ibtnSair.Size = new System.Drawing.Size(237, 66);
            this.ibtnSair.TabIndex = 4;
            this.ibtnSair.Text = "Sair";
            this.ibtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnSair.UseVisualStyleBackColor = true;
            this.ibtnSair.Click += new System.EventHandler(this.ibtnSair_Click);
            // 
            // ibtnExcluir
            // 
            this.ibtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ibtnExcluir.FlatAppearance.BorderSize = 0;
            this.ibtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnExcluir.ForeColor = System.Drawing.Color.White;
            this.ibtnExcluir.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnExcluir.IconColor = System.Drawing.Color.White;
            this.ibtnExcluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExcluir.Location = new System.Drawing.Point(3, 395);
            this.ibtnExcluir.Name = "ibtnExcluir";
            this.ibtnExcluir.Size = new System.Drawing.Size(237, 66);
            this.ibtnExcluir.TabIndex = 3;
            this.ibtnExcluir.Text = "Remover";
            this.ibtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnExcluir.UseVisualStyleBackColor = true;
            this.ibtnExcluir.Click += new System.EventHandler(this.ibtnExcluir_Click);
            // 
            // ibtnListar
            // 
            this.ibtnListar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ibtnListar.FlatAppearance.BorderSize = 0;
            this.ibtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnListar.ForeColor = System.Drawing.Color.White;
            this.ibtnListar.IconChar = FontAwesome.Sharp.IconChar.Stream;
            this.ibtnListar.IconColor = System.Drawing.Color.White;
            this.ibtnListar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnListar.Location = new System.Drawing.Point(3, 323);
            this.ibtnListar.Name = "ibtnListar";
            this.ibtnListar.Size = new System.Drawing.Size(237, 66);
            this.ibtnListar.TabIndex = 2;
            this.ibtnListar.Text = "Listar";
            this.ibtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnListar.UseVisualStyleBackColor = true;
            this.ibtnListar.Click += new System.EventHandler(this.ibtnListar_Click);
            // 
            // ibtnEditar
            // 
            this.ibtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ibtnEditar.FlatAppearance.BorderSize = 0;
            this.ibtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnEditar.ForeColor = System.Drawing.Color.White;
            this.ibtnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnEditar.IconColor = System.Drawing.Color.White;
            this.ibtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnEditar.Location = new System.Drawing.Point(3, 251);
            this.ibtnEditar.Name = "ibtnEditar";
            this.ibtnEditar.Size = new System.Drawing.Size(237, 66);
            this.ibtnEditar.TabIndex = 1;
            this.ibtnEditar.Text = "Editar";
            this.ibtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnEditar.UseVisualStyleBackColor = true;
            this.ibtnEditar.Click += new System.EventHandler(this.ibtnEditar_Click);
            // 
            // ibtnAdicionar
            // 
            this.ibtnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ibtnAdicionar.FlatAppearance.BorderSize = 0;
            this.ibtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnAdicionar.ForeColor = System.Drawing.Color.White;
            this.ibtnAdicionar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ibtnAdicionar.IconColor = System.Drawing.Color.White;
            this.ibtnAdicionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAdicionar.Location = new System.Drawing.Point(3, 179);
            this.ibtnAdicionar.Name = "ibtnAdicionar";
            this.ibtnAdicionar.Size = new System.Drawing.Size(237, 66);
            this.ibtnAdicionar.TabIndex = 0;
            this.ibtnAdicionar.Text = "Adicionar ";
            this.ibtnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibtnAdicionar.UseVisualStyleBackColor = true;
            this.ibtnAdicionar.Click += new System.EventHandler(this.ibtnAdicionar_Click);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.AutoSize = true;
            this.pnlConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(71)))), ((int)(((byte)(143)))));
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(243, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(1041, 661);
            this.pnlConteudo.TabIndex = 2;
            this.pnlConteudo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrastarFormulario);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlConteudo;
        private FontAwesome.Sharp.IconButton ibtnSair;
        private FontAwesome.Sharp.IconButton ibtnExcluir;
        private FontAwesome.Sharp.IconButton ibtnListar;
        private FontAwesome.Sharp.IconButton ibtnEditar;
        private FontAwesome.Sharp.IconButton ibtnAdicionar;
        private FontAwesome.Sharp.IconButton ibtnMensagem;
    }
}

