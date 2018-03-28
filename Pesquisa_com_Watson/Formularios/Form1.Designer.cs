namespace Pesquisa_com_Watson
{
    partial class frmPrincipal
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
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gkWeb = new Gecko.GeckoWebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPt = new System.Windows.Forms.CheckBox();
            this.chkIng = new System.Windows.Forms.CheckBox();
            this.chkEsp = new System.Windows.Forms.CheckBox();
            this.chkFra = new System.Windows.Forms.CheckBox();
            this.chkIta = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisar sobre:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(137, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(697, 26);
            this.txtPesquisa.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(873, 13);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(141, 32);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar Assunto";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // gkWeb
            // 
            this.gkWeb.FrameEventsPropagateToMainWindow = false;
            this.gkWeb.Location = new System.Drawing.Point(137, 147);
            this.gkWeb.Name = "gkWeb";
            this.gkWeb.Size = new System.Drawing.Size(877, 533);
            this.gkWeb.TabIndex = 3;
            this.gkWeb.UseHttpActivityObserver = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIta);
            this.groupBox1.Controls.Add(this.chkFra);
            this.groupBox1.Controls.Add(this.chkEsp);
            this.groupBox1.Controls.Add(this.chkIng);
            this.groupBox1.Controls.Add(this.chkPt);
            this.groupBox1.Location = new System.Drawing.Point(137, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // chkPt
            // 
            this.chkPt.AutoSize = true;
            this.chkPt.Location = new System.Drawing.Point(7, 26);
            this.chkPt.Name = "chkPt";
            this.chkPt.Size = new System.Drawing.Size(89, 24);
            this.chkPt.TabIndex = 0;
            this.chkPt.Text = "Português";
            this.chkPt.UseVisualStyleBackColor = true;
            // 
            // chkIng
            // 
            this.chkIng.AutoSize = true;
            this.chkIng.Location = new System.Drawing.Point(129, 26);
            this.chkIng.Name = "chkIng";
            this.chkIng.Size = new System.Drawing.Size(64, 24);
            this.chkIng.TabIndex = 1;
            this.chkIng.Text = "Inglês";
            this.chkIng.UseVisualStyleBackColor = true;
            // 
            // chkEsp
            // 
            this.chkEsp.AutoSize = true;
            this.chkEsp.Location = new System.Drawing.Point(213, 26);
            this.chkEsp.Name = "chkEsp";
            this.chkEsp.Size = new System.Drawing.Size(84, 24);
            this.chkEsp.TabIndex = 2;
            this.chkEsp.Text = "Espanhol";
            this.chkEsp.UseVisualStyleBackColor = true;
            // 
            // chkFra
            // 
            this.chkFra.AutoSize = true;
            this.chkFra.Location = new System.Drawing.Point(304, 26);
            this.chkFra.Name = "chkFra";
            this.chkFra.Size = new System.Drawing.Size(76, 24);
            this.chkFra.TabIndex = 3;
            this.chkFra.Text = "Francês";
            this.chkFra.UseVisualStyleBackColor = true;
            // 
            // chkIta
            // 
            this.chkIta.AutoSize = true;
            this.chkIta.Location = new System.Drawing.Point(387, 26);
            this.chkIta.Name = "chkIta";
            this.chkIta.Size = new System.Drawing.Size(69, 24);
            this.chkIta.TabIndex = 4;
            this.chkIta.Text = "Italiano";
            this.chkIta.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gkWeb);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "Pesquisa Com Watson";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private Gecko.GeckoWebBrowser gkWeb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkIta;
        private System.Windows.Forms.CheckBox chkFra;
        private System.Windows.Forms.CheckBox chkEsp;
        private System.Windows.Forms.CheckBox chkIng;
        private System.Windows.Forms.CheckBox chkPt;
    }
}

