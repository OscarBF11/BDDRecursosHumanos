using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDDRecursosHumanos
{
    public partial class GuiRRHH : Form
    {
        Hashtable listOfIds = new Hashtable();

        public GuiRRHH()
        {
            InitializeComponent();
        }

        private void butLeerEmpleados_Click(object sender, EventArgs e)
        {
            DALEmpleado dalEmp = new DALEmpleado();
            List<Empleado> emps = dalEmp.SelectEmpleados();

            listEmpleados.Items.Clear();
            listOfIds.Clear();

            foreach (Empleado emp in emps)
            {
                int n = listEmpleados.Items.Add(emp);
                listOfIds[n] = emp.idEmpleado;
            }
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            Empleado emp = WriteToObject();

            DALEmpleado dalEmp = new DALEmpleado();
            dalEmp.InsertEmpleado(emp);

            listEmpleados.Items.Insert(0, emp);
        }
        private void butBorrar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }
        private void BorrarCampos()
        {
            textNombre.Text = "";
            textApellidos.Text = "";
            textCargo.Text = "";
            dateFecha.Checked = false;
            chkSalarioNulo.Checked = false;
            numSalario.Value = 0.0M;

            butInsert.Visible = true;
            butUpdate.Visible = false;
        }
        private void butUpdate_Click(object sender, EventArgs e)
        {
            Empleado emp = WriteToObject();

            DALEmpleado dalEmp = new DALEmpleado();
            dalEmp.UpdateEmpleado(emp);

            butInsert.Visible = true;
            butUpdate.Visible = false;
            BorrarCampos();
        }
        private void listEmpleados_DoubleClick(object sender, EventArgs e)
        {
            int id = (int)listOfIds[listEmpleados.SelectedIndex];
            Empleado emp = (Empleado)listEmpleados.SelectedItem;
            DALEmpleado dalEmp = new DALEmpleado();
            emp = dalEmp.SelectEmpleadoById(emp.idEmpleado);

            ReadFromObject(emp);

            butInsert.Visible = false;
            butUpdate.Visible = true;
        }

        private void ReadFromObject(Empleado emp)
        {
            textNombre.Text = emp.Nombre;
            textApellidos.Text = emp.Apellidos;
            textCargo.Text = emp.Cargo;

            dateFecha.Value = (emp.FechaNac.HasValue ? emp.FechaNac.Value : DateTime.Now);
            dateFecha.Checked = emp.FechaNac.HasValue;

            chkSalarioNulo.Checked = emp.Salario.HasValue;
            numSalario.Value = (emp.Salario.HasValue ? emp.Salario.Value : 0.0M);
            labelIdEmpleado.Text = emp.idEmpleado.ToString();
        }

        private Empleado WriteToObject()
        {
            int id = 0;
            bool ok = Int32.TryParse(labelIdEmpleado.Text, out id);

            Empleado emp = new Empleado()
            {
                Nombre = textNombre.Text,
                Apellidos = textApellidos.Text,
                Cargo = textCargo.Text,
                FechaNac = dateFecha.Checked ? dateFecha.Value : null,
                Salario = chkSalarioNulo.Checked ? numSalario.Value : null,
                idEmpleado = id
            };

            return emp;
        }

        private void chkSalarioNulo_CheckedChanged(object sender, EventArgs e)
        {
            numSalario.Enabled = chkSalarioNulo.Checked;
        }
    }
}
