
namespace ProjetoCSharpExemplos
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lstListas = new System.Windows.Forms.ListBox();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.lblItemEscolhido = new System.Windows.Forms.Label();
            this.lstItensLista = new System.Windows.Forms.ListBox();
            this.txtItemLista = new System.Windows.Forms.TextBox();
            this.btnInserirItem = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstListas
            // 
            this.lstListas.FormattingEnabled = true;
            this.lstListas.Location = new System.Drawing.Point(51, 12);
            this.lstListas.Name = "lstListas";
            this.lstListas.Size = new System.Drawing.Size(241, 238);
            this.lstListas.TabIndex = 0;
            this.lstListas.SelectedIndexChanged += new System.EventHandler(this.lstListas_SelectedIndexChanged);
            // 
            // btnCarrega
            // 
            this.btnCarrega.Location = new System.Drawing.Point(51, 256);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(241, 62);
            this.btnCarrega.TabIndex = 1;
            this.btnCarrega.Text = "Carrega Lista";
            this.btnCarrega.UseVisualStyleBackColor = true;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // lblItemEscolhido
            // 
            this.lblItemEscolhido.AutoSize = true;
            this.lblItemEscolhido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemEscolhido.Location = new System.Drawing.Point(171, 348);
            this.lblItemEscolhido.Name = "lblItemEscolhido";
            this.lblItemEscolhido.Size = new System.Drawing.Size(0, 31);
            this.lblItemEscolhido.TabIndex = 2;
            // 
            // lstItensLista
            // 
            this.lstItensLista.FormattingEnabled = true;
            this.lstItensLista.Location = new System.Drawing.Point(346, 15);
            this.lstItensLista.Name = "lstItensLista";
            this.lstItensLista.Size = new System.Drawing.Size(245, 225);
            this.lstItensLista.TabIndex = 3;
            // 
            // txtItemLista
            // 
            this.txtItemLista.Location = new System.Drawing.Point(346, 256);
            this.txtItemLista.MaxLength = 50;
            this.txtItemLista.Name = "txtItemLista";
            this.txtItemLista.Size = new System.Drawing.Size(245, 20);
            this.txtItemLista.TabIndex = 4;
            // 
            // btnInserirItem
            // 
            this.btnInserirItem.Location = new System.Drawing.Point(346, 296);
            this.btnInserirItem.Name = "btnInserirItem";
            this.btnInserirItem.Size = new System.Drawing.Size(245, 52);
            this.btnInserirItem.TabIndex = 5;
            this.btnInserirItem.Text = "Inserir item";
            this.btnInserirItem.UseVisualStyleBackColor = true;
            this.btnInserirItem.Click += new System.EventHandler(this.btnInserirItem_Click);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.Location = new System.Drawing.Point(346, 355);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(245, 56);
            this.btnLimparLista.TabIndex = 6;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 467);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.btnInserirItem);
            this.Controls.Add(this.txtItemLista);
            this.Controls.Add(this.lstItensLista);
            this.Controls.Add(this.lblItemEscolhido);
            this.Controls.Add(this.btnCarrega);
            this.Controls.Add(this.lstListas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListas;
        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.Label lblItemEscolhido;
        private System.Windows.Forms.ListBox lstItensLista;
        private System.Windows.Forms.TextBox txtItemLista;
        private System.Windows.Forms.Button btnInserirItem;
        private System.Windows.Forms.Button btnLimparLista;
    }
}