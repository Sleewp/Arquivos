namespace Vendas
{
    partial class frmvendas
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
            this.lblcusto = new System.Windows.Forms.Label();
            this.txtcusto = new System.Windows.Forms.TextBox();
            this.lblimposto = new System.Windows.Forms.Label();
            this.txtimposto = new System.Windows.Forms.TextBox();
            this.lbldistribuidor = new System.Windows.Forms.Label();
            this.txtdistribuidor = new System.Windows.Forms.TextBox();
            this.lblfinal = new System.Windows.Forms.Label();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblsoma = new System.Windows.Forms.Label();
            this.txtsoma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcusto
            // 
            this.lblcusto.AutoSize = true;
            this.lblcusto.Location = new System.Drawing.Point(205, 121);
            this.lblcusto.Name = "lblcusto";
            this.lblcusto.Size = new System.Drawing.Size(117, 13);
            this.lblcusto.TabIndex = 0;
            this.lblcusto.Text = "Digite o custo do carro:";
            // 
            // txtcusto
            // 
            this.txtcusto.Location = new System.Drawing.Point(362, 118);
            this.txtcusto.Name = "txtcusto";
            this.txtcusto.Size = new System.Drawing.Size(100, 20);
            this.txtcusto.TabIndex = 1;
            this.txtcusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblimposto
            // 
            this.lblimposto.AutoSize = true;
            this.lblimposto.Location = new System.Drawing.Point(222, 166);
            this.lblimposto.Name = "lblimposto";
            this.lblimposto.Size = new System.Drawing.Size(88, 13);
            this.lblimposto.TabIndex = 2;
            this.lblimposto.Text = "Valor do imposto:";
            this.lblimposto.Click += new System.EventHandler(this.lblimposto_Click);
            // 
            // txtimposto
            // 
            this.txtimposto.Location = new System.Drawing.Point(362, 163);
            this.txtimposto.Name = "txtimposto";
            this.txtimposto.ReadOnly = true;
            this.txtimposto.Size = new System.Drawing.Size(100, 20);
            this.txtimposto.TabIndex = 3;
            this.txtimposto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtimposto.TextChanged += new System.EventHandler(this.txtimposto_TextChanged);
            // 
            // lbldistribuidor
            // 
            this.lbldistribuidor.AutoSize = true;
            this.lbldistribuidor.Location = new System.Drawing.Point(217, 208);
            this.lbldistribuidor.Name = "lbldistribuidor";
            this.lbldistribuidor.Size = new System.Drawing.Size(105, 13);
            this.lbldistribuidor.TabIndex = 4;
            this.lbldistribuidor.Text = "Lucro do distribuidor:";
            // 
            // txtdistribuidor
            // 
            this.txtdistribuidor.Location = new System.Drawing.Point(362, 205);
            this.txtdistribuidor.Name = "txtdistribuidor";
            this.txtdistribuidor.ReadOnly = true;
            this.txtdistribuidor.Size = new System.Drawing.Size(100, 20);
            this.txtdistribuidor.TabIndex = 5;
            this.txtdistribuidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(235, 297);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(56, 13);
            this.lblfinal.TabIndex = 6;
            this.lblfinal.Text = "Valor final:";
            // 
            // txtfinal
            // 
            this.txtfinal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtfinal.Location = new System.Drawing.Point(362, 297);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.ReadOnly = true;
            this.txtfinal.Size = new System.Drawing.Size(100, 20);
            this.txtfinal.TabIndex = 7;
            this.txtfinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(376, 354);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(247, 354);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(651, 391);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(85, 28);
            this.btnsair.TabIndex = 10;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblsoma
            // 
            this.lblsoma.AutoSize = true;
            this.lblsoma.Location = new System.Drawing.Point(225, 249);
            this.lblsoma.Name = "lblsoma";
            this.lblsoma.Size = new System.Drawing.Size(85, 13);
            this.lblsoma.TabIndex = 11;
            this.lblsoma.Text = "Custo + imposto:";
            // 
            // txtsoma
            // 
            this.txtsoma.Enabled = false;
            this.txtsoma.Location = new System.Drawing.Point(362, 249);
            this.txtsoma.Name = "txtsoma";
            this.txtsoma.ReadOnly = true;
            this.txtsoma.Size = new System.Drawing.Size(100, 20);
            this.txtsoma.TabIndex = 12;
            // 
            // frmvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(810, 469);
            this.Controls.Add(this.txtsoma);
            this.Controls.Add(this.lblsoma);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.txtdistribuidor);
            this.Controls.Add(this.lbldistribuidor);
            this.Controls.Add(this.txtimposto);
            this.Controls.Add(this.lblimposto);
            this.Controls.Add(this.txtcusto);
            this.Controls.Add(this.lblcusto);
            this.Name = "frmvendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda de carros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcusto;
        private System.Windows.Forms.TextBox txtcusto;
        private System.Windows.Forms.Label lblimposto;
        private System.Windows.Forms.TextBox txtimposto;
        private System.Windows.Forms.Label lbldistribuidor;
        private System.Windows.Forms.TextBox txtdistribuidor;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblsoma;
        private System.Windows.Forms.TextBox txtsoma;
    }
}

