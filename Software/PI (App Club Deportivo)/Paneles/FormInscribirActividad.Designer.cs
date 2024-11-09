namespace PI__App_Club_Deportivo_.Paneles
{
    partial class FormInscribirActividad
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
            btnCerrar = new Button();
            btnInscribir = new Button();
            txtDni = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabla = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(349, 389);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(146, 41);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.Purple;
            btnInscribir.FlatStyle = FlatStyle.Flat;
            btnInscribir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInscribir.ForeColor = SystemColors.ButtonFace;
            btnInscribir.Location = new Point(188, 389);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(146, 41);
            btnInscribir.TabIndex = 10;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(18, 106);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(238, 33);
            txtDni.TabIndex = 9;
            txtDni.KeyPress += txt_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(272, 21);
            label2.TabIndex = 8;
            label2.Text = "Ingrese el DNI del Socio / No Socio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(660, 37);
            label1.TabIndex = 7;
            label1.Text = "Formulario de Inscripcion a Atividad Socio / No Socio";
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(18, 190);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(646, 193);
            tabla.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 155);
            label3.Name = "label3";
            label3.Size = new Size(166, 21);
            label3.TabIndex = 13;
            label3.Text = "Seleccione Actividad:";
            // 
            // FormInscribirActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 436);
            Controls.Add(label3);
            Controls.Add(tabla);
            Controls.Add(btnCerrar);
            Controls.Add(btnInscribir);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInscribirActividad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Inscribir Actividad";
            Load += FormInscribirActividad_Load;
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private Button btnInscribir;
        private TextBox txtDni;
        private Label label2;
        private Label label1;
        private DataGridView tabla;
        private Label label3;
    }
}