namespace Registro_en_txt
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
            this.LabelNombre = new System.Windows.Forms.Label();
            this.TextboxName = new System.Windows.Forms.TextBox();
            this.Textboxapellidos = new System.Windows.Forms.TextBox();
            this.textBoxtelefono = new System.Windows.Forms.TextBox();
            this.textBoxEstatura = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.labelapellidos = new System.Windows.Forms.Label();
            this.labeltelefono = new System.Windows.Forms.Label();
            this.labelEstatura = new System.Windows.Forms.Label();
            this.LabelEdad = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.ButtonCancelar = new System.Windows.Forms.Button();
            this.Labelsexo = new System.Windows.Forms.Label();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonMujer = new System.Windows.Forms.RadioButton();
            this.Siempre = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(45, 21);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(56, 16);
            this.LabelNombre.TabIndex = 0;
            this.LabelNombre.Text = "Nombre";
            // 
            // TextboxName
            // 
            this.TextboxName.Location = new System.Drawing.Point(250, 21);
            this.TextboxName.Name = "TextboxName";
            this.TextboxName.Size = new System.Drawing.Size(100, 22);
            this.TextboxName.TabIndex = 1;
            // 
            // Textboxapellidos
            // 
            this.Textboxapellidos.Location = new System.Drawing.Point(250, 65);
            this.Textboxapellidos.Name = "Textboxapellidos";
            this.Textboxapellidos.Size = new System.Drawing.Size(100, 22);
            this.Textboxapellidos.TabIndex = 2;
            // 
            // textBoxtelefono
            // 
            this.textBoxtelefono.Location = new System.Drawing.Point(250, 116);
            this.textBoxtelefono.Name = "textBoxtelefono";
            this.textBoxtelefono.Size = new System.Drawing.Size(100, 22);
            this.textBoxtelefono.TabIndex = 3;
            // 
            // textBoxEstatura
            // 
            this.textBoxEstatura.Location = new System.Drawing.Point(250, 166);
            this.textBoxEstatura.Name = "textBoxEstatura";
            this.textBoxEstatura.Size = new System.Drawing.Size(100, 22);
            this.textBoxEstatura.TabIndex = 4;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(250, 219);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 22);
            this.textBoxEdad.TabIndex = 5;
            // 
            // labelapellidos
            // 
            this.labelapellidos.AutoSize = true;
            this.labelapellidos.Location = new System.Drawing.Point(45, 65);
            this.labelapellidos.Name = "labelapellidos";
            this.labelapellidos.Size = new System.Drawing.Size(64, 16);
            this.labelapellidos.TabIndex = 6;
            this.labelapellidos.Text = "Apellidos";
            // 
            // labeltelefono
            // 
            this.labeltelefono.AutoSize = true;
            this.labeltelefono.Location = new System.Drawing.Point(45, 116);
            this.labeltelefono.Name = "labeltelefono";
            this.labeltelefono.Size = new System.Drawing.Size(61, 16);
            this.labeltelefono.TabIndex = 7;
            this.labeltelefono.Text = "Telefono";
            // 
            // labelEstatura
            // 
            this.labelEstatura.AutoSize = true;
            this.labelEstatura.Location = new System.Drawing.Point(45, 166);
            this.labelEstatura.Name = "labelEstatura";
            this.labelEstatura.Size = new System.Drawing.Size(56, 16);
            this.labelEstatura.TabIndex = 8;
            this.labelEstatura.Text = "Estatura";
            // 
            // LabelEdad
            // 
            this.LabelEdad.AutoSize = true;
            this.LabelEdad.Location = new System.Drawing.Point(45, 219);
            this.LabelEdad.Name = "LabelEdad";
            this.LabelEdad.Size = new System.Drawing.Size(40, 16);
            this.LabelEdad.TabIndex = 9;
            this.LabelEdad.Text = "Edad";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(62, 339);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(235, 68);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ButtonCancelar
            // 
            this.ButtonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancelar.Location = new System.Drawing.Point(62, 430);
            this.ButtonCancelar.Name = "ButtonCancelar";
            this.ButtonCancelar.Size = new System.Drawing.Size(235, 68);
            this.ButtonCancelar.TabIndex = 11;
            this.ButtonCancelar.Text = "Cancelar";
            this.ButtonCancelar.UseVisualStyleBackColor = true;
            this.ButtonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // Labelsexo
            // 
            this.Labelsexo.AutoSize = true;
            this.Labelsexo.Location = new System.Drawing.Point(160, 270);
            this.Labelsexo.Name = "Labelsexo";
            this.Labelsexo.Size = new System.Drawing.Size(38, 16);
            this.Labelsexo.TabIndex = 12;
            this.Labelsexo.Text = "Sexo";
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(62, 303);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(77, 20);
            this.radioButtonMasculino.TabIndex = 13;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Hombre";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMujer
            // 
            this.radioButtonMujer.AutoSize = true;
            this.radioButtonMujer.Location = new System.Drawing.Point(236, 303);
            this.radioButtonMujer.Name = "radioButtonMujer";
            this.radioButtonMujer.Size = new System.Drawing.Size(61, 20);
            this.radioButtonMujer.TabIndex = 14;
            this.radioButtonMujer.TabStop = true;
            this.radioButtonMujer.Text = "Mujer";
            this.radioButtonMujer.UseVisualStyleBackColor = true;
            // 
            // Siempre
            // 
            this.Siempre.AutoSize = true;
            this.Siempre.Location = new System.Drawing.Point(145, 313);
            this.Siempre.Name = "Siempre";
            this.Siempre.Size = new System.Drawing.Size(79, 20);
            this.Siempre.TabIndex = 15;
            this.Siempre.TabStop = true;
            this.Siempre.Text = "Siempre";
            this.Siempre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 550);
            this.Controls.Add(this.Siempre);
            this.Controls.Add(this.radioButtonMujer);
            this.Controls.Add(this.radioButtonMasculino);
            this.Controls.Add(this.Labelsexo);
            this.Controls.Add(this.ButtonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.LabelEdad);
            this.Controls.Add(this.labelEstatura);
            this.Controls.Add(this.labeltelefono);
            this.Controls.Add(this.labelapellidos);
            this.Controls.Add(this.textBoxEdad);
            this.Controls.Add(this.textBoxEstatura);
            this.Controls.Add(this.textBoxtelefono);
            this.Controls.Add(this.Textboxapellidos);
            this.Controls.Add(this.TextboxName);
            this.Controls.Add(this.LabelNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.TextBox TextboxName;
        private System.Windows.Forms.TextBox Textboxapellidos;
        private System.Windows.Forms.TextBox textBoxtelefono;
        private System.Windows.Forms.TextBox textBoxEstatura;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label labelapellidos;
        private System.Windows.Forms.Label labeltelefono;
        private System.Windows.Forms.Label labelEstatura;
        private System.Windows.Forms.Label LabelEdad;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button ButtonCancelar;
        private System.Windows.Forms.Label Labelsexo;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.RadioButton radioButtonMujer;
        private System.Windows.Forms.RadioButton Siempre;
    }
}

