namespace Thot
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.chkIngles = new System.Windows.Forms.CheckBox();
            this.chkEspanhol = new System.Windows.Forms.CheckBox();
            this.chkFrances = new System.Windows.Forms.CheckBox();
            this.chkItaliano = new System.Windows.Forms.CheckBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.prgPesquisar = new System.Windows.Forms.ProgressBar();
            this.chkAlemao = new System.Windows.Forms.CheckBox();
            this.salvarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.lblInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(89, 12);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(311, 26);
            this.txtPesquisar.TabIndex = 1;
            // 
            // chkIngles
            // 
            this.chkIngles.AutoSize = true;
            this.chkIngles.Location = new System.Drawing.Point(89, 50);
            this.chkIngles.Name = "chkIngles";
            this.chkIngles.Size = new System.Drawing.Size(64, 24);
            this.chkIngles.TabIndex = 2;
            this.chkIngles.Text = "Inglês";
            this.chkIngles.UseVisualStyleBackColor = true;
            this.chkIngles.Visible = false;
            // 
            // chkEspanhol
            // 
            this.chkEspanhol.AutoSize = true;
            this.chkEspanhol.Location = new System.Drawing.Point(159, 50);
            this.chkEspanhol.Name = "chkEspanhol";
            this.chkEspanhol.Size = new System.Drawing.Size(84, 24);
            this.chkEspanhol.TabIndex = 3;
            this.chkEspanhol.Text = "Espanhol";
            this.chkEspanhol.UseVisualStyleBackColor = true;
            this.chkEspanhol.Visible = false;
            // 
            // chkFrances
            // 
            this.chkFrances.AutoSize = true;
            this.chkFrances.Location = new System.Drawing.Point(249, 50);
            this.chkFrances.Name = "chkFrances";
            this.chkFrances.Size = new System.Drawing.Size(76, 24);
            this.chkFrances.TabIndex = 4;
            this.chkFrances.Text = "Francês";
            this.chkFrances.UseVisualStyleBackColor = true;
            this.chkFrances.Visible = false;
            // 
            // chkItaliano
            // 
            this.chkItaliano.AutoSize = true;
            this.chkItaliano.Location = new System.Drawing.Point(331, 50);
            this.chkItaliano.Name = "chkItaliano";
            this.chkItaliano.Size = new System.Drawing.Size(69, 24);
            this.chkItaliano.TabIndex = 5;
            this.chkItaliano.Text = "Italiano";
            this.chkItaliano.UseVisualStyleBackColor = true;
            this.chkItaliano.Visible = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(424, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(159, 26);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // prgPesquisar
            // 
            this.prgPesquisar.Location = new System.Drawing.Point(3, 119);
            this.prgPesquisar.Name = "prgPesquisar";
            this.prgPesquisar.Size = new System.Drawing.Size(580, 34);
            this.prgPesquisar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgPesquisar.TabIndex = 7;
            // 
            // chkAlemao
            // 
            this.chkAlemao.AutoSize = true;
            this.chkAlemao.Location = new System.Drawing.Point(406, 50);
            this.chkAlemao.Name = "chkAlemao";
            this.chkAlemao.Size = new System.Drawing.Size(74, 24);
            this.chkAlemao.TabIndex = 8;
            this.chkAlemao.Text = "Alemão";
            this.chkAlemao.UseVisualStyleBackColor = true;
            this.chkAlemao.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(-1, 156);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(98, 20);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Aguardando....";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentagem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentagem.Location = new System.Drawing.Point(289, 133);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(15, 16);
            this.lblPorcentagem.TabIndex = 10;
            this.lblPorcentagem.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "%";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(531, 156);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(52, 20);
            this.lblVersao.TabIndex = 12;
            this.lblVersao.Text = "Versão";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 183);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chkAlemao);
            this.Controls.Add(this.prgPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.chkItaliano);
            this.Controls.Add(this.chkFrances);
            this.Controls.Add(this.chkEspanhol);
            this.Controls.Add(this.chkIngles);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":__Thot__:";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.CheckBox chkIngles;
        private System.Windows.Forms.CheckBox chkEspanhol;
        private System.Windows.Forms.CheckBox chkFrances;
        private System.Windows.Forms.CheckBox chkItaliano;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ProgressBar prgPesquisar;
        private System.Windows.Forms.CheckBox chkAlemao;
        private System.Windows.Forms.SaveFileDialog salvarArquivo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVersao;
    }
}

