
namespace BDDRecursosHumanos
{
    partial class GuiRRHH
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
            this.butLeerEmpleados = new System.Windows.Forms.Button();
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkSalarioNulo = new System.Windows.Forms.CheckBox();
            this.labelIdEmpleado = new System.Windows.Forms.Label();
            this.butBorrar = new System.Windows.Forms.Button();
            this.numSalario = new System.Windows.Forms.NumericUpDown();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.butUpdate = new System.Windows.Forms.Button();
            this.butInsert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // butLeerEmpleados
            // 
            this.butLeerEmpleados.Location = new System.Drawing.Point(43, 38);
            this.butLeerEmpleados.Name = "butLeerEmpleados";
            this.butLeerEmpleados.Size = new System.Drawing.Size(225, 23);
            this.butLeerEmpleados.TabIndex = 0;
            this.butLeerEmpleados.Text = "Leer empleados";
            this.butLeerEmpleados.UseVisualStyleBackColor = true;
            this.butLeerEmpleados.Click += new System.EventHandler(this.butLeerEmpleados_Click);
            // 
            // listEmpleados
            // 
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 15;
            this.listEmpleados.Location = new System.Drawing.Point(43, 102);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(225, 229);
            this.listEmpleados.TabIndex = 1;
            this.listEmpleados.DoubleClick += new System.EventHandler(this.listEmpleados_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkSalarioNulo);
            this.panel1.Controls.Add(this.labelIdEmpleado);
            this.panel1.Controls.Add(this.butBorrar);
            this.panel1.Controls.Add(this.numSalario);
            this.panel1.Controls.Add(this.dateFecha);
            this.panel1.Controls.Add(this.butUpdate);
            this.panel1.Controls.Add(this.butInsert);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textCargo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textApellidos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(357, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 229);
            this.panel1.TabIndex = 2;
            // 
            // chkSalarioNulo
            // 
            this.chkSalarioNulo.AutoSize = true;
            this.chkSalarioNulo.Location = new System.Drawing.Point(79, 151);
            this.chkSalarioNulo.Name = "chkSalarioNulo";
            this.chkSalarioNulo.Size = new System.Drawing.Size(15, 14);
            this.chkSalarioNulo.TabIndex = 11;
            this.chkSalarioNulo.UseVisualStyleBackColor = true;
            this.chkSalarioNulo.CheckedChanged += new System.EventHandler(this.chkSalarioNulo_CheckedChanged);
            // 
            // labelIdEmpleado
            // 
            this.labelIdEmpleado.Location = new System.Drawing.Point(99, 10);
            this.labelIdEmpleado.Name = "labelIdEmpleado";
            this.labelIdEmpleado.Size = new System.Drawing.Size(100, 18);
            this.labelIdEmpleado.TabIndex = 10;
            this.labelIdEmpleado.Visible = false;
            // 
            // butBorrar
            // 
            this.butBorrar.Location = new System.Drawing.Point(21, 176);
            this.butBorrar.Name = "butBorrar";
            this.butBorrar.Size = new System.Drawing.Size(51, 40);
            this.butBorrar.TabIndex = 9;
            this.butBorrar.Text = "Borrar";
            this.butBorrar.UseVisualStyleBackColor = true;
            this.butBorrar.Click += new System.EventHandler(this.butBorrar_Click);
            // 
            // numSalario
            // 
            this.numSalario.DecimalPlaces = 2;
            this.numSalario.Location = new System.Drawing.Point(106, 148);
            this.numSalario.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numSalario.Name = "numSalario";
            this.numSalario.Size = new System.Drawing.Size(156, 23);
            this.numSalario.TabIndex = 5;
            this.numSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSalario.ThousandsSeparator = true;
            // 
            // dateFecha
            // 
            this.dateFecha.Checked = false;
            this.dateFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha.Location = new System.Drawing.Point(79, 118);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.ShowCheckBox = true;
            this.dateFecha.Size = new System.Drawing.Size(183, 23);
            this.dateFecha.TabIndex = 4;
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(79, 176);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(87, 40);
            this.butUpdate.TabIndex = 6;
            this.butUpdate.Text = "Modificar empleado";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Visible = false;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // butInsert
            // 
            this.butInsert.Location = new System.Drawing.Point(172, 176);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(90, 40);
            this.butInsert.TabIndex = 6;
            this.butInsert.Text = "Añadir empleado";
            this.butInsert.UseVisualStyleBackColor = true;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha:";
            // 
            // textCargo
            // 
            this.textCargo.Location = new System.Drawing.Point(79, 89);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(183, 23);
            this.textCargo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cargo";
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(79, 60);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(183, 23);
            this.textApellidos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(79, 31);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(183, 23);
            this.textNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // GuiRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 431);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.butLeerEmpleados);
            this.Name = "GuiRRHH";
            this.Text = "Empleados y departamentos con capas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLeerEmpleados;
        private System.Windows.Forms.ListBox listEmpleados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numSalario;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.Button butBorrar;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Label labelIdEmpleado;
        private System.Windows.Forms.CheckBox chkSalarioNulo;
    }
}

