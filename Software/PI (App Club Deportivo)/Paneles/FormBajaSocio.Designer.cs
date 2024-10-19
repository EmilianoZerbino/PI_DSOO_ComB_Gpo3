namespace PI__App_Club_Deportivo_.Paneles
{
    partial class FormBajaSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBajaSocio));
            label1 = new Label();
            label2 = new Label();
            txtDni = new TextBox();
            btnBaja = new Button();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(486, 37);
            label1.TabIndex = 1;
            label1.Text = "Formulario de baja de Socio / No Socio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 88);
            label2.Name = "label2";
            label2.Size = new Size(272, 21);
            label2.TabIndex = 2;
            label2.Text = "Ingrese el DNI del Socio / No Socio:";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(135, 140);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(287, 33);
            txtDni.TabIndex = 3;
            txtDni.KeyPress += txt_KeyPress;
            // 
            // btnBaja
            // 
            btnBaja.BackColor = Color.Purple;
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.ForeColor = SystemColors.ButtonFace;
            btnBaja.Location = new Point(135, 184);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(287, 41);
            btnBaja.TabIndex = 4;
            btnBaja.Text = "Dar de Baja del Sistema";
            btnBaja.UseVisualStyleBackColor = false;
            btnBaja.Click += BtnBaja_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(372, 297);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(146, 41);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // FormBajaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 350);
            Controls.Add(btnCerrar);
            Controls.Add(btnBaja);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormBajaSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de Baja de Socio / No Socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtDni;
        private Button btnBaja;
        private Button btnAceptar;
        private Button btnCerrar;
    }
}