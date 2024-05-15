namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstMedicos = new ListBox();
            lstPacientes = new ListBox();
            richTextBox1 = new RichTextBox();
            lblMedicos = new Label();
            lblPacientes = new Label();
            btnSalir = new Button();
            btnAtender = new Button();
            SuspendLayout();
            // 
            // lstMedicos
            // 
            lstMedicos.FormattingEnabled = true;
            lstMedicos.ItemHeight = 15;
            lstMedicos.Location = new Point(12, 42);
            lstMedicos.Name = "lstMedicos";
            lstMedicos.Size = new Size(294, 184);
            lstMedicos.TabIndex = 0;
            // 
            // lstPacientes
            // 
            lstPacientes.FormattingEnabled = true;
            lstPacientes.ItemHeight = 15;
            lstPacientes.Location = new Point(358, 42);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(290, 184);
            lstPacientes.TabIndex = 1;
            lstPacientes.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 243);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(636, 195);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // lblMedicos
            // 
            lblMedicos.AutoSize = true;
            lblMedicos.Location = new Point(12, 24);
            lblMedicos.Name = "lblMedicos";
            lblMedicos.Size = new Size(95, 15);
            lblMedicos.TabIndex = 3;
            lblMedicos.Text = "Personal Médico";
            // 
            // lblPacientes
            // 
            lblPacientes.AutoSize = true;
            lblPacientes.Location = new Point(358, 24);
            lblPacientes.Name = "lblPacientes";
            lblPacientes.Size = new Size(57, 15);
            lblPacientes.TabIndex = 4;
            lblPacientes.Text = "Pacientes";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(654, 361);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(134, 77);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(654, 42);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(134, 63);
            btnAtender.TabIndex = 6;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            btnAtender.Click += btnAtender_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAtender);
            Controls.Add(btnSalir);
            Controls.Add(lblPacientes);
            Controls.Add(lblMedicos);
            Controls.Add(richTextBox1);
            Controls.Add(lstPacientes);
            Controls.Add(lstMedicos);
            Name = "Form1";
            Text = "Atencion de pacientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMedicos;
        private ListBox lstPacientes;
        private RichTextBox richTextBox1;
        private Label lblMedicos;
        private Label lblPacientes;
        private Button btnSalir;
        private Button btnAtender;
    }
}