namespace Area
{
    partial class Form1
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblbase = new System.Windows.Forms.Label();
            this.txtboxaltura = new System.Windows.Forms.TextBox();
            this.txtboxbase = new System.Windows.Forms.TextBox();
            this.btncalcule = new System.Windows.Forms.Button();
            this.lblarea = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(58, 48);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(110, 23);
            this.lbltitulo.TabIndex = 2;
            this.lbltitulo.Text = "CALCULE A ÁREA";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(29, 134);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(52, 23);
            this.lblaltura.TabIndex = 4;
            this.lblaltura.Text = "Altura:";
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbase.Location = new System.Drawing.Point(29, 107);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(43, 23);
            this.lblbase.TabIndex = 5;
            this.lblbase.Text = "Base:";
            // 
            // txtboxaltura
            // 
            this.txtboxaltura.Location = new System.Drawing.Point(85, 139);
            this.txtboxaltura.Name = "txtboxaltura";
            this.txtboxaltura.Size = new System.Drawing.Size(112, 20);
            this.txtboxaltura.TabIndex = 6;
            // 
            // txtboxbase
            // 
            this.txtboxbase.Location = new System.Drawing.Point(85, 112);
            this.txtboxbase.Name = "txtboxbase";
            this.txtboxbase.Size = new System.Drawing.Size(112, 20);
            this.txtboxbase.TabIndex = 7;
            // 
            // btncalcule
            // 
            this.btncalcule.BackColor = System.Drawing.Color.Brown;
            this.btncalcule.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btncalcule.Location = new System.Drawing.Point(33, 165);
            this.btncalcule.Name = "btncalcule";
            this.btncalcule.Size = new System.Drawing.Size(164, 45);
            this.btncalcule.TabIndex = 8;
            this.btncalcule.Text = "CALCULE";
            this.btncalcule.UseVisualStyleBackColor = false;
            this.btncalcule.Click += new System.EventHandler(this.btncalcule_Click);
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarea.ForeColor = System.Drawing.Color.Brown;
            this.lblarea.Location = new System.Drawing.Point(30, 237);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(55, 29);
            this.lblarea.TabIndex = 9;
            this.lblarea.Text = "Área:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(108, 241);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 25);
            this.lblresultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 321);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.btncalcule);
            this.Controls.Add(this.txtboxbase);
            this.Controls.Add(this.txtboxaltura);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.TextBox txtboxaltura;
        private System.Windows.Forms.TextBox txtboxbase;
        private System.Windows.Forms.Button btncalcule;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lblresultado;
    }
}

