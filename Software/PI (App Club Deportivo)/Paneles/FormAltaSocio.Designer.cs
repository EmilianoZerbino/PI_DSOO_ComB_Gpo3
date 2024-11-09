namespace PI__App_Club_Deportivo_.Paneles
{
    partial class FormAltaSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaSocio));
            label1 = new Label();
            label3 = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            label4 = new Label();
            txtDni = new TextBox();
            label5 = new Label();
            txtNacionalidad = new TextBox();
            label6 = new Label();
            txtNDpto = new TextBox();
            label7 = new Label();
            txtNPiso = new TextBox();
            label8 = new Label();
            txtAltura = new TextBox();
            label9 = new Label();
            txtCalle = new TextBox();
            label10 = new Label();
            txtLocalidad = new TextBox();
            label12 = new Label();
            txtBarrio = new TextBox();
            label13 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            gbDatosPersonales = new GroupBox();
            gbDireccion = new GroupBox();
            gbCategoria = new GroupBox();
            rbNoSocio = new RadioButton();
            rbSocio = new RadioButton();
            gbDatosPersonales.SuspendLayout();
            gbDireccion.SuspendLayout();
            gbCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(59, 18);
            label1.Name = "label1";
            label1.Size = new Size(419, 37);
            label1.TabIndex = 0;
            label1.Text = "Formulario de Inscripción al Club";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 31);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombres:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(126, 28);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(350, 29);
            txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(126, 63);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(350, 29);
            txtApellidos.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 66);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 4;
            label4.Text = "Apellidos:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(126, 98);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(350, 29);
            txtDni.TabIndex = 7;
            txtDni.KeyPress += txt_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(16, 101);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 6;
            label5.Text = "Dni:";
            // 
            // txtNacionalidad
            // 
            txtNacionalidad.Location = new Point(126, 133);
            txtNacionalidad.Name = "txtNacionalidad";
            txtNacionalidad.Size = new Size(350, 29);
            txtNacionalidad.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(16, 136);
            label6.Name = "label6";
            label6.Size = new Size(104, 21);
            label6.TabIndex = 8;
            label6.Text = "Nacionalidad:";
            // 
            // txtNDpto
            // 
            txtNDpto.Location = new Point(431, 63);
            txtNDpto.Name = "txtNDpto";
            txtNDpto.Size = new Size(45, 29);
            txtNDpto.TabIndex = 18;
            txtNDpto.KeyPress += txt_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(378, 70);
            label7.Name = "label7";
            label7.Size = new Size(47, 21);
            label7.TabIndex = 17;
            label7.Text = "Dpto:";
            // 
            // txtNPiso
            // 
            txtNPiso.Location = new Point(308, 63);
            txtNPiso.Name = "txtNPiso";
            txtNPiso.Size = new Size(45, 29);
            txtNPiso.TabIndex = 16;
            txtNPiso.KeyPress += txt_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(255, 70);
            label8.Name = "label8";
            label8.Size = new Size(42, 21);
            label8.TabIndex = 15;
            label8.Text = "Piso:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(126, 63);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(91, 29);
            txtAltura.TabIndex = 14;
            txtAltura.KeyPress += txt_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 66);
            label9.Name = "label9";
            label9.Size = new Size(55, 21);
            label9.TabIndex = 13;
            label9.Text = "Altura:";
            // 
            // txtCalle
            // 
            txtCalle.Location = new Point(126, 28);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(350, 29);
            txtCalle.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(16, 31);
            label10.Name = "label10";
            label10.Size = new Size(47, 21);
            label10.TabIndex = 11;
            label10.Text = "Calle:";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(126, 133);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(350, 29);
            txtLocalidad.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(16, 136);
            label12.Name = "label12";
            label12.Size = new Size(79, 21);
            label12.TabIndex = 21;
            label12.Text = "Localidad:";
            // 
            // txtBarrio
            // 
            txtBarrio.Location = new Point(126, 98);
            txtBarrio.Name = "txtBarrio";
            txtBarrio.Size = new Size(350, 29);
            txtBarrio.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(16, 101);
            label13.Name = "label13";
            label13.Size = new Size(55, 21);
            label13.TabIndex = 19;
            label13.Text = "Barrio:";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Green;
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = SystemColors.ButtonFace;
            btnAceptar.Location = new Point(157, 537);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(98, 35);
            btnAceptar.TabIndex = 23;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = SystemColors.ButtonFace;
            btnCancelar.Location = new Point(272, 537);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 35);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // gbDatosPersonales
            // 
            gbDatosPersonales.Controls.Add(txtNombres);
            gbDatosPersonales.Controls.Add(label3);
            gbDatosPersonales.Controls.Add(label4);
            gbDatosPersonales.Controls.Add(txtApellidos);
            gbDatosPersonales.Controls.Add(label5);
            gbDatosPersonales.Controls.Add(txtDni);
            gbDatosPersonales.Controls.Add(label6);
            gbDatosPersonales.Controls.Add(txtNacionalidad);
            gbDatosPersonales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDatosPersonales.Location = new Point(18, 73);
            gbDatosPersonales.Name = "gbDatosPersonales";
            gbDatosPersonales.Size = new Size(489, 177);
            gbDatosPersonales.TabIndex = 25;
            gbDatosPersonales.TabStop = false;
            gbDatosPersonales.Text = "Datos Personales";
            // 
            // gbDireccion
            // 
            gbDireccion.Controls.Add(txtCalle);
            gbDireccion.Controls.Add(label10);
            gbDireccion.Controls.Add(label9);
            gbDireccion.Controls.Add(txtLocalidad);
            gbDireccion.Controls.Add(txtAltura);
            gbDireccion.Controls.Add(label12);
            gbDireccion.Controls.Add(label8);
            gbDireccion.Controls.Add(txtBarrio);
            gbDireccion.Controls.Add(txtNPiso);
            gbDireccion.Controls.Add(label13);
            gbDireccion.Controls.Add(label7);
            gbDireccion.Controls.Add(txtNDpto);
            gbDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            gbDireccion.Location = new Point(18, 256);
            gbDireccion.Name = "gbDireccion";
            gbDireccion.Size = new Size(489, 184);
            gbDireccion.TabIndex = 10;
            gbDireccion.TabStop = false;
            gbDireccion.Text = "Dirección";
            // 
            // gbCategoria
            // 
            gbCategoria.Controls.Add(rbNoSocio);
            gbCategoria.Controls.Add(rbSocio);
            gbCategoria.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbCategoria.Location = new Point(121, 456);
            gbCategoria.Name = "gbCategoria";
            gbCategoria.Size = new Size(282, 64);
            gbCategoria.TabIndex = 26;
            gbCategoria.TabStop = false;
            gbCategoria.Text = "Categoria";
            // 
            // rbNoSocio
            // 
            rbNoSocio.AutoSize = true;
            rbNoSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbNoSocio.Location = new Point(160, 26);
            rbNoSocio.Name = "rbNoSocio";
            rbNoSocio.Size = new Size(88, 24);
            rbNoSocio.TabIndex = 1;
            rbNoSocio.Text = "No Socio";
            rbNoSocio.UseVisualStyleBackColor = true;
            // 
            // rbSocio
            // 
            rbSocio.AutoSize = true;
            rbSocio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbSocio.Location = new Point(48, 26);
            rbSocio.Name = "rbSocio";
            rbSocio.Size = new Size(64, 24);
            rbSocio.TabIndex = 0;
            rbSocio.Text = "Socio";
            rbSocio.UseVisualStyleBackColor = true;
            // 
            // FormAltaSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 588);
            Controls.Add(gbCategoria);
            Controls.Add(gbDireccion);
            Controls.Add(gbDatosPersonales);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAltaSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario de Inscripción";
            gbDatosPersonales.ResumeLayout(false);
            gbDatosPersonales.PerformLayout();
            gbDireccion.ResumeLayout(false);
            gbDireccion.PerformLayout();
            gbCategoria.ResumeLayout(false);
            gbCategoria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private Label label4;
        private TextBox txtDni;
        private Label label5;
        private TextBox txtNacionalidad;
        private Label label6;
        private TextBox txtNDpto;
        private Label label7;
        private TextBox txtNPiso;
        private Label label8;
        private TextBox txtAltura;
        private Label label9;
        private TextBox txtCalle;
        private Label label10;
        private TextBox txtLocalidad;
        private Label label12;
        private TextBox txtBarrio;
        private Label label13;
        private Button btnAceptar;
        private Button btnCancelar;
        private GroupBox gbDatosPersonales;
        private GroupBox gbDireccion;
        private GroupBox gbCategoria;
        private RadioButton rbNoSocio;
        private RadioButton rbSocio;
    }
}