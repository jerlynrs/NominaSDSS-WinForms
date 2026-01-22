namespace NominaSDSS
{
    partial class FrmNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNomina));
            btnGenerarTxt = new Button();
            btnLeerTxt = new Button();
            dataGridNomina = new DataGridView();
            label1 = new Label();
            lblDescripcion = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridNomina).BeginInit();
            SuspendLayout();
            // 
            // btnGenerarTxt
            // 
            btnGenerarTxt.Location = new Point(47, 43);
            btnGenerarTxt.Name = "btnGenerarTxt";
            btnGenerarTxt.Size = new Size(149, 23);
            btnGenerarTxt.TabIndex = 0;
            btnGenerarTxt.Text = "Generar Archivo (PUSH)";
            btnGenerarTxt.UseVisualStyleBackColor = true;
            btnGenerarTxt.Click += btnGenerarTxt_Click;
            // 
            // btnLeerTxt
            // 
            btnLeerTxt.Location = new Point(265, 43);
            btnLeerTxt.Name = "btnLeerTxt";
            btnLeerTxt.Size = new Size(155, 23);
            btnLeerTxt.TabIndex = 1;
            btnLeerTxt.Text = "Leer Archivo (PULL)";
            btnLeerTxt.UseVisualStyleBackColor = true;
            btnLeerTxt.Click += btnLeerTxt_Click_1;
            // 
            // dataGridNomina
            // 
            dataGridNomina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNomina.Location = new Point(47, 102);
            dataGridNomina.Name = "dataGridNomina";
            dataGridNomina.Size = new Size(469, 278);
            dataGridNomina.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 84);
            label1.Name = "label1";
            label1.Size = new Size(234, 15);
            label1.TabIndex = 3;
            label1.Text = "Listado de Empleados Ferretería Americana";
            label1.Click += label1_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.BackColor = SystemColors.ActiveCaption;
            lblDescripcion.BorderStyle = BorderStyle.FixedSingle;
            lblDescripcion.Location = new Point(541, 102);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(180, 165);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = resources.GetString("lblDescripcion.Text");
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            lblDescripcion.Click += lblDescripcion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 396);
            label2.Name = "label2";
            label2.Size = new Size(155, 45);
            label2.TabIndex = 5;
            label2.Text = "Creado por Jerlyn Rodriguez\r\nISO 810\r\nMaestro Juan Pablo";
            // 
            // FrmNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lblDescripcion);
            Controls.Add(label1);
            Controls.Add(dataGridNomina);
            Controls.Add(btnLeerTxt);
            Controls.Add(btnGenerarTxt);
            Name = "FrmNomina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Nómina SDSS";
            Load += FrmNomina_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridNomina).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarTxt;
        private Button btnLeerTxt;
        private DataGridView dataGridNomina;
        private Label label1;
        private Label lblDescripcion;
        private Label label2;
    }
}
