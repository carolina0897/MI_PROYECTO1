namespace MI_PROYECTO1
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
            this.btnprocesar = new System.Windows.Forms.Button();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.optSuma = new System.Windows.Forms.RadioButton();
            this.optResta = new System.Windows.Forms.RadioButton();
            this.optMiltuplicacion = new System.Windows.Forms.RadioButton();
            this.optDivicion = new System.Windows.Forms.RadioButton();
            this.grbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(78, 180);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(75, 32);
            this.btnprocesar.TabIndex = 0;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(28, 48);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(41, 13);
            this.lblnum1.TabIndex = 1;
            this.lblnum1.Text = "Num 1:";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(28, 85);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(41, 13);
            this.lblnum2.TabIndex = 2;
            this.lblnum2.Text = "Num 2:";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(108, 110);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(70, 13);
            this.lblrespuesta.TabIndex = 3;
            this.lblrespuesta.Text = "Respuesta: ?";
            this.lblrespuesta.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(78, 41);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(44, 20);
            this.txtnum1.TabIndex = 4;
            this.txtnum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(78, 80);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(44, 20);
            this.txtnum2.TabIndex = 5;
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.Controls.Add(this.optDivicion);
            this.grbOperaciones.Controls.Add(this.optMiltuplicacion);
            this.grbOperaciones.Controls.Add(this.optResta);
            this.grbOperaciones.Controls.Add(this.optSuma);
            this.grbOperaciones.Location = new System.Drawing.Point(213, 24);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(88, 154);
            this.grbOperaciones.TabIndex = 6;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "Operaciones";
            // 
            // optSuma
            // 
            this.optSuma.AutoSize = true;
            this.optSuma.Checked = true;
            this.optSuma.Location = new System.Drawing.Point(7, 24);
            this.optSuma.Name = "optSuma";
            this.optSuma.Size = new System.Drawing.Size(52, 17);
            this.optSuma.TabIndex = 0;
            this.optSuma.TabStop = true;
            this.optSuma.Text = "Suma";
            this.optSuma.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            this.optResta.AutoSize = true;
            this.optResta.Location = new System.Drawing.Point(7, 56);
            this.optResta.Name = "optResta";
            this.optResta.Size = new System.Drawing.Size(53, 17);
            this.optResta.TabIndex = 1;
            this.optResta.Text = "Resta";
            this.optResta.UseVisualStyleBackColor = true;
            // 
            // optMiltuplicacion
            // 
            this.optMiltuplicacion.AutoSize = true;
            this.optMiltuplicacion.Location = new System.Drawing.Point(6, 86);
            this.optMiltuplicacion.Name = "optMiltuplicacion";
            this.optMiltuplicacion.Size = new System.Drawing.Size(72, 17);
            this.optMiltuplicacion.TabIndex = 2;
            this.optMiltuplicacion.Text = "Multiplicar";
            this.optMiltuplicacion.UseVisualStyleBackColor = true;
            // 
            // optDivicion
            // 
            this.optDivicion.AutoSize = true;
            this.optDivicion.Location = new System.Drawing.Point(7, 121);
            this.optDivicion.Name = "optDivicion";
            this.optDivicion.Size = new System.Drawing.Size(54, 17);
            this.optDivicion.TabIndex = 3;
            this.optDivicion.Text = "Dividir";
            this.optDivicion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 236);
            this.Controls.Add(this.grbOperaciones);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.btnprocesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbOperaciones.ResumeLayout(false);
            this.grbOperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.GroupBox grbOperaciones;
        private System.Windows.Forms.RadioButton optDivicion;
        private System.Windows.Forms.RadioButton optMiltuplicacion;
        private System.Windows.Forms.RadioButton optResta;
        private System.Windows.Forms.RadioButton optSuma;
    }
}

