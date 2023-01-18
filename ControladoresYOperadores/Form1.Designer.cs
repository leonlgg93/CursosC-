
namespace ControladoresYOperadores
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
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.ckbMusica = new System.Windows.Forms.CheckBox();
            this.rbGuitarra = new System.Windows.Forms.RadioButton();
            this.rbBajo = new System.Windows.Forms.RadioButton();
            this.rbBateria = new System.Windows.Forms.RadioButton();
            this.gbInstrumento = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnPersona = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.gbInstrumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersona.Location = new System.Drawing.Point(12, 9);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(184, 31);
            this.lblPersona.TabIndex = 0;
            this.lblPersona.Text = "Perfil Persona";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(129, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 85);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(111, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Location = new System.Drawing.Point(129, 78);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 1;
            // 
            // ckbMusica
            // 
            this.ckbMusica.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbMusica.AutoSize = true;
            this.ckbMusica.Location = new System.Drawing.Point(129, 113);
            this.ckbMusica.Name = "ckbMusica";
            this.ckbMusica.Size = new System.Drawing.Size(121, 17);
            this.ckbMusica.TabIndex = 2;
            this.ckbMusica.Text = "Te gusta la musica?";
            this.ckbMusica.UseVisualStyleBackColor = true;
            // 
            // rbGuitarra
            // 
            this.rbGuitarra.AutoSize = true;
            this.rbGuitarra.Location = new System.Drawing.Point(108, 44);
            this.rbGuitarra.Name = "rbGuitarra";
            this.rbGuitarra.Size = new System.Drawing.Size(62, 17);
            this.rbGuitarra.TabIndex = 0;
            this.rbGuitarra.TabStop = true;
            this.rbGuitarra.Text = "Guitarra";
            this.rbGuitarra.UseVisualStyleBackColor = true;
            // 
            // rbBajo
            // 
            this.rbBajo.AutoSize = true;
            this.rbBajo.Location = new System.Drawing.Point(243, 44);
            this.rbBajo.Name = "rbBajo";
            this.rbBajo.Size = new System.Drawing.Size(46, 17);
            this.rbBajo.TabIndex = 1;
            this.rbBajo.TabStop = true;
            this.rbBajo.Text = "Bajo";
            this.rbBajo.UseVisualStyleBackColor = true;
            // 
            // rbBateria
            // 
            this.rbBateria.AutoSize = true;
            this.rbBateria.Location = new System.Drawing.Point(357, 44);
            this.rbBateria.Name = "rbBateria";
            this.rbBateria.Size = new System.Drawing.Size(58, 17);
            this.rbBateria.TabIndex = 2;
            this.rbBateria.TabStop = true;
            this.rbBateria.Text = "Bateria";
            this.rbBateria.UseVisualStyleBackColor = true;
            // 
            // gbInstrumento
            // 
            this.gbInstrumento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbInstrumento.Controls.Add(this.rbBajo);
            this.gbInstrumento.Controls.Add(this.rbBateria);
            this.gbInstrumento.Controls.Add(this.rbGuitarra);
            this.gbInstrumento.Location = new System.Drawing.Point(15, 154);
            this.gbInstrumento.Name = "gbInstrumento";
            this.gbInstrumento.Size = new System.Drawing.Size(427, 100);
            this.gbInstrumento.TabIndex = 3;
            this.gbInstrumento.TabStop = false;
            this.gbInstrumento.Text = "Instrumento";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 368);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(178, 131);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnPersona
            // 
            this.btnPersona.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPersona.FlatAppearance.BorderSize = 2;
            this.btnPersona.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPersona.Location = new System.Drawing.Point(15, 325);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(112, 23);
            this.btnPersona.TabIndex = 5;
            this.btnPersona.Text = "Agregar persona:";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(15, 283);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(83, 13);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "Genero favorito:";
            // 
            // cbGenero
            // 
            this.cbGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(104, 280);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(225, 21);
            this.cbGenero.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(479, 527);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.btnPersona);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbInstrumento);
            this.Controls.Add(this.ckbMusica);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPersona);
            this.MaximumSize = new System.Drawing.Size(895, 677);
            this.MinimumSize = new System.Drawing.Size(495, 566);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInstrumento.ResumeLayout(false);
            this.gbInstrumento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox ckbMusica;
        private System.Windows.Forms.RadioButton rbGuitarra;
        private System.Windows.Forms.RadioButton rbBajo;
        private System.Windows.Forms.RadioButton rbBateria;
        private System.Windows.Forms.GroupBox gbInstrumento;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cbGenero;
    }
}

