namespace TPN_BancoTech
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_montoPagar = new System.Windows.Forms.TextBox();
            this.tb_descuento = new System.Windows.Forms.TextBox();
            this.tb_nmeses = new System.Windows.Forms.TextBox();
            this.tb_pagoAdel = new System.Windows.Forms.TextBox();
            this.cb_dias = new System.Windows.Forms.ComboBox();
            this.b_consultar = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.b_validar = new System.Windows.Forms.Button();
            this.l_mensajes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto a Pagar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "% descuento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Días";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número de meses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pago Adelantado";
            // 
            // tb_montoPagar
            // 
            this.tb_montoPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_montoPagar.Location = new System.Drawing.Point(238, 36);
            this.tb_montoPagar.Name = "tb_montoPagar";
            this.tb_montoPagar.Size = new System.Drawing.Size(227, 20);
            this.tb_montoPagar.TabIndex = 5;
            this.tb_montoPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_montoPagar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_descuento
            // 
            this.tb_descuento.Location = new System.Drawing.Point(238, 89);
            this.tb_descuento.Name = "tb_descuento";
            this.tb_descuento.Size = new System.Drawing.Size(97, 20);
            this.tb_descuento.TabIndex = 6;
            this.tb_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_nmeses
            // 
            this.tb_nmeses.Location = new System.Drawing.Point(238, 198);
            this.tb_nmeses.Name = "tb_nmeses";
            this.tb_nmeses.Size = new System.Drawing.Size(97, 20);
            this.tb_nmeses.TabIndex = 7;
            this.tb_nmeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_pagoAdel
            // 
            this.tb_pagoAdel.Enabled = false;
            this.tb_pagoAdel.Location = new System.Drawing.Point(238, 261);
            this.tb_pagoAdel.Name = "tb_pagoAdel";
            this.tb_pagoAdel.Size = new System.Drawing.Size(227, 20);
            this.tb_pagoAdel.TabIndex = 8;
            this.tb_pagoAdel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cb_dias
            // 
            this.cb_dias.AllowDrop = true;
            this.cb_dias.FormattingEnabled = true;
            this.cb_dias.Items.AddRange(new object[] {
            "",
            "30",
            "60",
            "90",
            "120",
            "180",
            "270"});
            this.cb_dias.Location = new System.Drawing.Point(235, 139);
            this.cb_dias.Name = "cb_dias";
            this.cb_dias.Size = new System.Drawing.Size(116, 21);
            this.cb_dias.TabIndex = 9;
            // 
            // b_consultar
            // 
            this.b_consultar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_consultar.Location = new System.Drawing.Point(14, 331);
            this.b_consultar.Name = "b_consultar";
            this.b_consultar.Size = new System.Drawing.Size(137, 49);
            this.b_consultar.TabIndex = 10;
            this.b_consultar.Text = "Consultar";
            this.b_consultar.UseVisualStyleBackColor = true;
            this.b_consultar.Click += new System.EventHandler(this.b_consultar_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restaurar.Location = new System.Drawing.Point(196, 331);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(137, 49);
            this.btn_restaurar.TabIndex = 11;
            this.btn_restaurar.Text = "Restaurar";
            this.btn_restaurar.UseVisualStyleBackColor = true;
            this.btn_restaurar.Click += new System.EventHandler(this.button2_Click);
            // 
            // b_validar
            // 
            this.b_validar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_validar.Location = new System.Drawing.Point(380, 331);
            this.b_validar.Name = "b_validar";
            this.b_validar.Size = new System.Drawing.Size(137, 49);
            this.b_validar.TabIndex = 12;
            this.b_validar.Text = "Validar";
            this.b_validar.UseVisualStyleBackColor = true;
            // 
            // l_mensajes
            // 
            this.l_mensajes.AutoSize = true;
            this.l_mensajes.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_mensajes.ForeColor = System.Drawing.Color.Red;
            this.l_mensajes.Location = new System.Drawing.Point(12, 423);
            this.l_mensajes.Name = "l_mensajes";
            this.l_mensajes.Size = new System.Drawing.Size(181, 23);
            this.l_mensajes.TabIndex = 13;
            this.l_mensajes.Text = "Zona de Mensajes";
            this.l_mensajes.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(565, 517);
            this.Controls.Add(this.l_mensajes);
            this.Controls.Add(this.b_validar);
            this.Controls.Add(this.btn_restaurar);
            this.Controls.Add(this.b_consultar);
            this.Controls.Add(this.cb_dias);
            this.Controls.Add(this.tb_pagoAdel);
            this.Controls.Add(this.tb_nmeses);
            this.Controls.Add(this.tb_descuento);
            this.Controls.Add(this.tb_montoPagar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Adelanto de Pago";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_montoPagar;
        private System.Windows.Forms.TextBox tb_descuento;
        private System.Windows.Forms.TextBox tb_nmeses;
        private System.Windows.Forms.TextBox tb_pagoAdel;
        private System.Windows.Forms.ComboBox cb_dias;
        private System.Windows.Forms.Button b_consultar;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Button b_validar;
        private System.Windows.Forms.Label l_mensajes;
    }
}

