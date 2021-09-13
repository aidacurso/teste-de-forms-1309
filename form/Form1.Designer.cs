
namespace form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconButtonCadastro = new FontAwesome.Sharp.IconButton();
            this.iconButtonPedido = new FontAwesome.Sharp.IconButton();
            this.iconButtonInformacoes = new FontAwesome.Sharp.IconButton();
            this.iconButtonCardapio = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MediumPurple;
            this.panelMenu.Controls.Add(this.iconButtonCardapio);
            this.panelMenu.Controls.Add(this.iconButtonInformacoes);
            this.panelMenu.Controls.Add(this.iconButtonPedido);
            this.panelMenu.Controls.Add(this.iconButtonCadastro);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // iconButtonCadastro
            // 
            this.iconButtonCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCadastro.FlatAppearance.BorderSize = 0;
            this.iconButtonCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCadastro.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonCadastro.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonCadastro.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCadastro.Location = new System.Drawing.Point(0, 140);
            this.iconButtonCadastro.Name = "iconButtonCadastro";
            this.iconButtonCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonCadastro.Size = new System.Drawing.Size(220, 50);
            this.iconButtonCadastro.TabIndex = 1;
            this.iconButtonCadastro.Text = "Cadastrar";
            this.iconButtonCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCadastro.UseVisualStyleBackColor = true;
            // 
            // iconButtonPedido
            // 
            this.iconButtonPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonPedido.FlatAppearance.BorderSize = 0;
            this.iconButtonPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPedido.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonPedido.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.iconButtonPedido.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonPedido.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPedido.Location = new System.Drawing.Point(0, 190);
            this.iconButtonPedido.Name = "iconButtonPedido";
            this.iconButtonPedido.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonPedido.Size = new System.Drawing.Size(220, 50);
            this.iconButtonPedido.TabIndex = 2;
            this.iconButtonPedido.Text = "Fazer pedido";
            this.iconButtonPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPedido.UseVisualStyleBackColor = true;
            // 
            // iconButtonInformacoes
            // 
            this.iconButtonInformacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonInformacoes.FlatAppearance.BorderSize = 0;
            this.iconButtonInformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonInformacoes.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonInformacoes.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            this.iconButtonInformacoes.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonInformacoes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInformacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonInformacoes.Location = new System.Drawing.Point(0, 240);
            this.iconButtonInformacoes.Name = "iconButtonInformacoes";
            this.iconButtonInformacoes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonInformacoes.Size = new System.Drawing.Size(220, 50);
            this.iconButtonInformacoes.TabIndex = 3;
            this.iconButtonInformacoes.Text = "Ver cadastrados";
            this.iconButtonInformacoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonInformacoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonInformacoes.UseVisualStyleBackColor = true;
            // 
            // iconButtonCardapio
            // 
            this.iconButtonCardapio.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCardapio.FlatAppearance.BorderSize = 0;
            this.iconButtonCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCardapio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonCardapio.IconChar = FontAwesome.Sharp.IconChar.Elementor;
            this.iconButtonCardapio.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButtonCardapio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCardapio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCardapio.Location = new System.Drawing.Point(0, 290);
            this.iconButtonCardapio.Name = "iconButtonCardapio";
            this.iconButtonCardapio.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonCardapio.Size = new System.Drawing.Size(220, 50);
            this.iconButtonCardapio.TabIndex = 4;
            this.iconButtonCardapio.Text = "Cardápio";
            this.iconButtonCardapio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCardapio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCardapio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonCardapio;
        private FontAwesome.Sharp.IconButton iconButtonInformacoes;
        private FontAwesome.Sharp.IconButton iconButtonPedido;
        private FontAwesome.Sharp.IconButton iconButtonCadastro;
        private System.Windows.Forms.Panel panelLogo;
    }
}

