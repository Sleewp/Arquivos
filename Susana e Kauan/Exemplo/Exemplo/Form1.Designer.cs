namespace Exemplo
{
    partial class frmsoma
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(61, 74);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(89, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Digite um número";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(61, 117);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(99, 13);
            this.lblnumero2.TabIndex = 1;
            this.lblnumero2.Text = "Digite outro número";
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.Info;
            this.txtnumero.Location = new System.Drawing.Point(184, 74);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 2;
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.SystemColors.Info;
            this.txtnumero2.Location = new System.Drawing.Point(184, 117);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 3;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(61, 169);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado";
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtresultado.Enabled = false;
            this.txtresultado.Location = new System.Drawing.Point(184, 169);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(100, 20);
            this.txtresultado.TabIndex = 5;
         
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(132, 234);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click_1);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(236, 234);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(657, 380);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmsoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero);
            this.Name = "frmsoma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

