namespace simulacro_parcial_1
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
            this.comboBoxDepartamentos = new System.Windows.Forms.ComboBox();
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.textBoxTemperatura = new System.Windows.Forms.TextBox();
            this.buttonMostrarDatos = new System.Windows.Forms.Button();
            this.buttonOrdenar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPromedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDepartamentos
            // 
            this.comboBoxDepartamentos.FormattingEnabled = true;
            this.comboBoxDepartamentos.Location = new System.Drawing.Point(53, 48);
            this.comboBoxDepartamentos.Name = "comboBoxDepartamentos";
            this.comboBoxDepartamentos.Size = new System.Drawing.Size(240, 24);
            this.comboBoxDepartamentos.TabIndex = 0;
            this.comboBoxDepartamentos.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamentos_SelectedIndexChanged);
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Location = new System.Drawing.Point(53, 174);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
            this.buttonIngresar.TabIndex = 1;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Location = new System.Drawing.Point(456, 48);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.RowHeadersWidth = 51;
            this.dataGridViewDatos.RowTemplate.Height = 24;
            this.dataGridViewDatos.Size = new System.Drawing.Size(662, 236);
            this.dataGridViewDatos.TabIndex = 2;
            // 
            // textBoxTemperatura
            // 
            this.textBoxTemperatura.Location = new System.Drawing.Point(53, 113);
            this.textBoxTemperatura.Name = "textBoxTemperatura";
            this.textBoxTemperatura.Size = new System.Drawing.Size(100, 22);
            this.textBoxTemperatura.TabIndex = 3;
            // 
            // buttonMostrarDatos
            // 
            this.buttonMostrarDatos.Location = new System.Drawing.Point(456, 317);
            this.buttonMostrarDatos.Name = "buttonMostrarDatos";
            this.buttonMostrarDatos.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrarDatos.TabIndex = 4;
            this.buttonMostrarDatos.Text = "Mostrar";
            this.buttonMostrarDatos.UseVisualStyleBackColor = true;
            this.buttonMostrarDatos.Click += new System.EventHandler(this.buttonMostrarDatos_Click);
            // 
            // buttonOrdenar
            // 
            this.buttonOrdenar.Location = new System.Drawing.Point(566, 316);
            this.buttonOrdenar.Name = "buttonOrdenar";
            this.buttonOrdenar.Size = new System.Drawing.Size(75, 23);
            this.buttonOrdenar.TabIndex = 5;
            this.buttonOrdenar.Text = "Ordenar";
            this.buttonOrdenar.UseVisualStyleBackColor = true;
            this.buttonOrdenar.Click += new System.EventHandler(this.buttonOrdenar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(749, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Promedio Temperaturas";
            // 
            // labelPromedio
            // 
            this.labelPromedio.AutoSize = true;
            this.labelPromedio.Location = new System.Drawing.Point(752, 337);
            this.labelPromedio.Name = "labelPromedio";
            this.labelPromedio.Size = new System.Drawing.Size(44, 16);
            this.labelPromedio.TabIndex = 7;
            this.labelPromedio.Text = "label2";
            this.labelPromedio.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 477);
            this.Controls.Add(this.labelPromedio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOrdenar);
            this.Controls.Add(this.buttonMostrarDatos);
            this.Controls.Add(this.textBoxTemperatura);
            this.Controls.Add(this.dataGridViewDatos);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.comboBoxDepartamentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartamentos;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.TextBox textBoxTemperatura;
        private System.Windows.Forms.Button buttonMostrarDatos;
        private System.Windows.Forms.Button buttonOrdenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPromedio;
    }
}

