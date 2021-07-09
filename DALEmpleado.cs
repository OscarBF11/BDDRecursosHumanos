using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDDRecursosHumanos
{
    class DALEmpleado
    {
        DbConnect cnx;

        // CRUD
        public DALEmpleado()
        {
            cnx = new DbConnect();
        }

        public void InsertEmpleado(Empleado emp)
        {
            try
            {
                string sql = @"INSERT INTO Empleado 
                    (Nombre, Apellidos, Cargo, FechaNac, Salario, RIdDepartamento1)
                    VALUES (@pNombre,
                        @pApellidos,
                        @pCargo,
                        @pFechaNac,
                         @pSalario, null)";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);

                SqlParameter pFechaNac = new SqlParameter("@pFechaNac", emp.FechaNac);
                SqlParameter pSalario = new SqlParameter("@pSalario", emp.Salario);

                SqlParameter pNombre = new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 50);
                pNombre.Value = emp.Nombre;
                SqlParameter pApellidos = new SqlParameter("@pApellidos", System.Data.SqlDbType.NVarChar, 100);
                pApellidos.Value = emp.Apellidos;
                SqlParameter pCargo = new SqlParameter("@pCargo", System.Data.SqlDbType.NVarChar, 30);
                pCargo.Value = emp.Cargo;

                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pApellidos);
                cmd.Parameters.Add(pCargo);
                cmd.Parameters.Add(pFechaNac);
                cmd.Parameters.Add(pSalario);

                int numFiles = cmd.ExecuteNonQuery();
                Console.WriteLine("Num filas afectadas " + numFiles);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error en Insert: " + ex.Message);
            }
        }

        public Empleado SelectEmpleadoById(int id)
        {
            Empleado emp=null;

            try
            {
                string sql = "SELECT * FROM Empleado WHERE IdEmpleado=@pId";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlParameter pId = new SqlParameter("@pId", id);
                cmd.Parameters.Add(pId);
                
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emp = new Empleado();
                    emp.Nombre = (string)dr["Nombre"];
                    emp.Apellidos = (string)dr["Apellidos"];
                    emp.Cargo = (string)GestionarNulos(dr["Cargo"]);
                    emp.FechaNac = (DateTime?)GestionarNulos(dr["FechaNac"]);
                    emp.Salario = (decimal?)GestionarNulos(dr["Salario"]);
                    emp.RIdDepartamento1 = (int?)GestionarNulos(dr["RIdDepartamento1"]);
                    emp.idEmpleado = (int)dr["idEmpleado"];

                    //emp.Depto = (string)dr["Depto"];
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error en Insert: " + ex.Message);
            }

            return emp;
        }

        public List<Empleado> SelectEmpleados()
        {
            List<Empleado> emps = new List<Empleado>();
            Empleado emp;

            try
            {
                string sql = "SELECT * FROM Empleado" +
                    " ORDER BY Nombre, Apellidos";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emp = new Empleado();
                    emp.Nombre = (string)dr["Nombre"];
                    emp.Apellidos = (string)dr["Apellidos"];
                    emp.Cargo = (string)GestionarNulos(dr["Cargo"]);
                    emp.FechaNac = (DateTime?)GestionarNulos(dr["FechaNac"]);
                   // emp.Salario = (decimal?)GestionarNulos(dr["Salario"]);
                    emp.RIdDepartamento1 = (int?)GestionarNulos(dr["RIdDepartamento1"]);

                  /*  object valor1 = dr["Salario"];
                    if (valor1 == System.DBNull.Value)
                        emp.Salario = null;
                    else
                        emp.Salario = (decimal?)valor1;*/

                    //object valor = dr["RIdDepartamento1"];
                    //if (valor == System.DBNull.Value)
                    //    emp.RIdDepartamento1 = null;
                    //else
                    //    emp.RIdDepartamento1 = (int?)valor;

                    //emp.idEmpleado = (int)dr["idEmpleado"];
                    //emp.Depto = (string)dr["Depto"];

                    emps.Add(emp);
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error en Insert: " + ex.Message);
            }

            return emps;
        }

        public object GestionarNulos(object valOriginal)
        {
            if (valOriginal == System.DBNull.Value)
                return null;
            else
                return valOriginal;
        }

        public void UpdateEmpleado(Empleado emp)
        {
            try
            {
                string sql = @"UPDATE Empleado 
                SET Nombre = @pNombre,
                    Apellidos = @pApellidos,
                    Cargo = @pCargo,
                    FechaNac = @pFechaNac,
                    Salario = @pSalario
                    WHERE IdEmpleado = @pId";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);

                SqlParameter pId = new SqlParameter("@pId", emp.idEmpleado);
                SqlParameter pNombre = new SqlParameter("@pNombre", System.Data.SqlDbType.NVarChar, 50);
                SqlParameter pApellidos = new SqlParameter("@pApellidos", System.Data.SqlDbType.NVarChar, 100);
                SqlParameter pCargo = new SqlParameter("@pCargo", System.Data.SqlDbType.NVarChar, 30);
                SqlParameter pFechaNac = new SqlParameter("@pFechaNac", System.Data.SqlDbType.Date);
                SqlParameter pSalario = new SqlParameter("@pSalario", System.Data.SqlDbType.Decimal);
                cmd.Parameters.Add(pId);
                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pApellidos);
                cmd.Parameters.Add(pCargo);
                cmd.Parameters.Add(pFechaNac);
                cmd.Parameters.Add(pSalario);
                pSalario.IsNullable = true;
                pFechaNac.IsNullable = true;
                pCargo.IsNullable = true;

                pNombre.Value = emp.Nombre;
                pApellidos.Value = emp.Apellidos;
                pCargo.Value = emp.Cargo==null ? System.DBNull.Value : emp.Cargo;
                pFechaNac.Value = emp.FechaNac == null ? System.DBNull.Value : emp.FechaNac;
                pSalario.Value = emp.Salario == null ? System.DBNull.Value : emp.Salario;
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error en Insert: " + ex.Message);
            }
        }

        public void DeleteEmpleado(int id)
        {
            try
            {
                string sql = "DELETE FROM Empleado WHERE IdEmpleado = @pId";
                SqlCommand cmd = new SqlCommand(sql, cnx.MiCnx);

                SqlParameter pId = new SqlParameter("@pId", id);
                cmd.Parameters.Add(pId);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error en Insert: " + ex.Message);
            }

        }
    }
}
