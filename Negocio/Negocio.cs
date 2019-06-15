using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseDatos;
using Dominio;

namespace Negocio
{
    public class Funciones
    {
        Magos magos;
        Hechizos hechizos;
        //Listar Magos
        public List<string> MagosListarNombre()
        {
            AccesoDatos conexion = new AccesoDatos();
            List<string> nombre = new List<string>();

            try
            {
                conexion.abrirConexion();
                conexion.setearConsulta("Select NOMBRE from Magos");
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    string aux;//inicializa la variable

                    aux = conexion.Lector.GetString(0);

                    nombre.Add(aux);
                }
                return nombre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
        //Listar Magos
        public List<Magos> MagosListar()
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Magos> lista = new List<Magos>();

            try
            {
                conexion.abrirConexion();
                conexion.setearConsulta("Select M.ID, M.NOMBRE, C.DESCRIPCION FROM MAGOS M, CASAS C WHERE C.ID = M.IDCASA");
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    magos = new Magos();//inicializa la variable

                    magos.ID = conexion.Lector.GetInt32(0);
                    magos.Nombre = conexion.Lector.GetString(1);

                    magos.casas = new Casas();//instancio la variable para poder utilizar un elemento de la clase
                    magos.casas.Descripcion = conexion.Lector.GetString(2);

                    lista.Add(magos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        //Listar Magos por Nombre
        public List<Magos> MagosListar(string nombre)
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Magos> lista = new List<Magos>();

            try
            {
                conexion.abrirConexion();
                conexion.setearConsulta("Select M.ID, M.NOMBRE, C.DESCRIPCION FROM MAGOS M, CASAS C WHERE C.ID = M.IDCASA AND M.NOMBRE like '%" + nombre + "%'");
                conexion.ejecutarConsulta();

                while (conexion.Lector.Read())
                {
                    magos = new Magos();//inicializa la variable

                    magos.ID = conexion.Lector.GetInt32(0);
                    magos.Nombre = conexion.Lector.GetString(1);

                    magos.casas = new Casas();//instancio la variable para poder utilizar un elemento de la clase
                    magos.casas.Descripcion = conexion.Lector.GetString(2);

                    lista.Add(magos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        //Listar Hechizos
        public List<Hechizos> HechizosListar()
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Hechizos> lista = new List<Hechizos>();

            try
            {
                conexion.abrirConexion();
                conexion.setearConsulta("SELECT ID, NOMBRE FROM HECHIZOS");
                conexion.ejecutarConsulta();
                while (conexion.Lector.Read())
                {
                    hechizos = new Hechizos();

                    hechizos.ID = conexion.Lector.GetInt32(0);
                    hechizos.Nombre = conexion.Lector.GetString(1);

                    lista.Add(hechizos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        //Listar Hechizos
        public List<Hechizos> HechizosListar(int ID)
        {
            AccesoDatos conexion = new AccesoDatos();
            List<Hechizos> lista = new List<Hechizos>();

            try
            {
                conexion.abrirConexion();
                conexion.setearConsulta("SELECT H.ID, H.NOMBRE FROM HECHIZOS AS H INNER JOIN HECHIZOSMAGOS AS HXM ON HXM.IDHECHIZO = H.Id INNER JOIN MAGOS AS M ON M.ID = HXM.IdMago WHERE M.Id=" + ID.ToString());
                conexion.ejecutarConsulta();
                while (conexion.Lector.Read())
                {
                    hechizos = new Hechizos();

                    hechizos.ID = conexion.Lector.GetInt32(0);
                    hechizos.Nombre = conexion.Lector.GetString(1);

                    lista.Add(hechizos);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }

        //Listar Hechizos
        public void HechizosAgregar(Magos mago, Hechizos hechizo)
        {

            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearConsulta("insert into HECHIZOSMAGOS values(@IdMago, @IdHechizo)");
                conexion.Comando.Parameters.Clear();
                conexion.Comando.Parameters.AddWithValue("@IdMago", mago.ID);
                conexion.Comando.Parameters.AddWithValue("@IdHechizo", hechizo.ID);

                conexion.abrirConexion();
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarConexion();
                conexion = null;
            }
        }
    }
}
    //public void PacienteModificar(Paciente modificar)//Modificar Paciente
    //{
    //    AccesoDatos conexion = new AccesoDatos();
    //    try
    //    {
    //        conexion.setearConsulta("update PACIENTES Set Apellido=@Apellido, Nombre=@Nombre, DNI=@DNI, FechaNac=@FechaNac, Tel=@Tel, Email=@Email, Genero=@Genero, Direccion=@Direccion, ID_Cobertura=@Id_Cobertura  Where Id=" + modificar.ID.ToString());
    //        conexion.Comando.Parameters.Clear();
    //        conexion.Comando.Parameters.AddWithValue("@Apellido", modificar.APELLIDO);
    //        conexion.Comando.Parameters.AddWithValue("@Nombre", modificar.NOMBRE);
    //        conexion.Comando.Parameters.AddWithValue("@DNI", modificar.DNI);
    //        conexion.Comando.Parameters.AddWithValue("@FechaNac", modificar.FECHANAC);
    //        conexion.Comando.Parameters.AddWithValue("@Tel", modificar.TEL);
    //        conexion.Comando.Parameters.AddWithValue("@Email", modificar.EMAIL);
    //        conexion.Comando.Parameters.AddWithValue("@Genero", modificar.GENERO);
    //        conexion.Comando.Parameters.AddWithValue("@Direccion", modificar.DIRECCION);
    //        conexion.Comando.Parameters.AddWithValue("@Id_Cobertura", modificar.COBERTURA.ID);

    //        conexion.abrirConexion();
    //        conexion.ejecutarAccion();
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //    finally
    //    {
    //        conexion.cerrarConexion();
    //        conexion = null;
    //    }
    //}

    //public void PacienteAgregar(Paciente agregar)//Agrega Paciente
    //{
    //    AccesoDatos conexion = new AccesoDatos();
    //    try
    //    {
    //        conexion.setearConsulta("insert into PACIENTES values(@Apellido, @Nombre, @DNI, @FechaNac, @Tel, @Email, @Genero, @Direccion, @Estado, @Id_Cobertura)");
    //        conexion.Comando.Parameters.Clear();
    //        conexion.Comando.Parameters.AddWithValue("@Apellido", agregar.APELLIDO);
    //        conexion.Comando.Parameters.AddWithValue("@Nombre", agregar.NOMBRE);
    //        conexion.Comando.Parameters.AddWithValue("@DNI", agregar.DNI);
    //        conexion.Comando.Parameters.AddWithValue("@FechaNac", agregar.FECHANAC);
    //        conexion.Comando.Parameters.AddWithValue("@Tel", agregar.TEL);
    //        conexion.Comando.Parameters.AddWithValue("@Email", agregar.EMAIL);
    //        conexion.Comando.Parameters.AddWithValue("@Genero", agregar.GENERO);
    //        conexion.Comando.Parameters.AddWithValue("@Direccion", agregar.DIRECCION);
    //        conexion.Comando.Parameters.AddWithValue("@Estado", 1);
    //        conexion.Comando.Parameters.AddWithValue("@Id_Cobertura", agregar.COBERTURA.ID);

    //        conexion.abrirConexion();
    //        conexion.ejecutarAccion();
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //    finally
    //    {
    //        conexion.cerrarConexion();
    //        conexion = null;
    //    }
    //}

    //public void PacienteEliminar(int id)//Eliminar Paciente
    //{
    //    AccesoDatos conexion = new AccesoDatos();
    //    try
    //    {
    //        conexion.setearConsulta("update PACIENTES Set Estado=0  Where Id=" + id.ToString());

    //        conexion.abrirConexion();
    //        conexion.ejecutarAccion();
    //    }
    //    catch (Exception ex)
    //    {
    //        throw ex;
    //    }
    //    finally
    //    {
    //        conexion.cerrarConexion();
    //        conexion = null;
    //    }
    //}
