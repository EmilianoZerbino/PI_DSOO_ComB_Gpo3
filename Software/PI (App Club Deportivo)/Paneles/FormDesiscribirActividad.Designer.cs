namespace PI__App_Club_Deportivo_.Paneles
{
    partial class FormDesiscribirActividad
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
            tabla = new DataGridView();
            btnCerrar = new Button();
            btnDesinscribir = new Button();
            txtDni = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 156);
            label3.Name = "label3";
            label3.Size = new Size(245, 21);
            label3.TabIndex = 20;
            label3.Text = "Actividades de Socio / No Socio";
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(70, 189);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(703, 193);
            tabla.TabIndex = 19;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(192, 0, 0);
            btnCerrar.DialogResult = DialogResult.Cancel;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(433, 388);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(146, 41);
            btnCerrar.TabIndex = 18;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnDesinscribir
            // 
            btnDesinscribir.BackColor = Color.Purple;
            btnDesinscribir.FlatStyle = FlatStyle.Flat;
            btnDesinscribir.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesinscribir.ForeColor = SystemColors.ButtonFace;
            btnDesinscribir.Location = new Point(281, 388);
            btnDesinscribir.Name = "btnDesinscribir";
            btnDesinscribir.Size = new Size(146, 41);
            btnDesinscribir.TabIndex = 17;
            btnDesinscribir.Text = "Desinscribir";
            btnDesinscribir.UseVisualStyleBackColor = false;
            btnDesinscribir.Click += btnDesinscribir_Click;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(70, 107);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(238, 33);
            txtDni.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 72);
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
            label1.Location = new Point(70, 19);
            label1.Name = "label1";
            label1.Size = new Size(509, 37);
            label1.TabIndex = 14;
            label1.Text = "Formulario Ver / Desiscribir de Actividad";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Green;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnConsultar.ForeColor = SystemColors.ButtonFace;
            btnConsultar.Location = new Point(342, 102);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(146, 41);
            btnConsultar.TabIndex = 21;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // FormDesiscribirActividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 450);
            Controls.Add(btnConsultar);
            Controls.Add(label3);
            Controls.Add(tabla);
            Controls.Add(btnCerrar);
            Controls.Add(btnDesinscribir);
            Controls.Add(txtDni);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDesiscribirActividad";
            Text = "Ver Actividad Socio / No Socio - Desiscribir Actividad";
            Load += FormDesiscribirActividad_Load;
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private DataGridView tabla;
        private Button btnCerrar;
        private Button btnDesinscribir;
        private TextBox txtDni;
        private Label label2;
        private Label label1;
        private Button btnConsultar;
    }
}