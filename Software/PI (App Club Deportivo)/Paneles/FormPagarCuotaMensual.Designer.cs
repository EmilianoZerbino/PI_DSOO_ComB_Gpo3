namespace PI__App_Club_Deportivo_.Paneles
{
    partial class FormPagarCuotaMensual
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
            label3 = new Label();
            btnCerrar = new Button();
            btnPagar = new Button();
            txtDni = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnConsultar = new Button();
            txtSaldo = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 156);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 20;
            label3.Text = "Saldo a Abonar";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(323, 250);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(146, 41);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Purple;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = SystemColors.ButtonFace;
            btnPagar.Location = new Point(156, 250);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(146, 41);
            btnPagar.TabIndex = 17;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(86, 107);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(238, 33);
            txtDni.TabIndex = 16;
            txtDni.KeyPress += txt_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 72);
            label2.Name = "label2";
            label2.Size = new Size(272, 21);
            label2.TabIndex = 15;
            label2.Text = "Ingrese el DNI del Socio / No Socio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(47, 19);
            label1.Name = "label1";
            label1.Size = new Size(481, 37);
            label1.TabIndex = 14;
            label1.Text = "Formulario de Pago de Cuota Mensual";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Green;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = SystemColors.ButtonFace;
            btnConsultar.Location = new Point(343, 104);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(146, 41);
            btnConsultar.TabIndex = 22;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtSaldo
            // 
            txtSaldo.Enabled = false;
            txtSaldo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldo.Location = new Point(86, 197);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(238, 33);
            txtSaldo.TabIndex = 23;
            // 
            // FormPagarCuotaMensual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 331);
            Controls.Add(txtSaldo);
            Controls.Add(btnConsultar);
            Controls.Add(label3);
            Controls.Add(btnCerrar);
            Controls.Add(btnPagar);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPagarCuotaMensual";
            Text = "FormPagarCuota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnCerrar;
        private Button btnPagar;
        private TextBox txtDni;
        private Label label2;
        private Label label1;
        private Button btnConsultar;
        private TextBox txtSaldo;
    }
}