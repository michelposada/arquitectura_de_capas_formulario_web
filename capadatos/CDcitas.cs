using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaentidades;



namespace capadatos
{
    public class CDcitas
    {
        CConexion oconexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_cita(CEcitas ocitas)// de CECitas recibe la información para guardar citas.
        {
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "actualizar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                ocmd.Parameters.Add("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add("@hora", ocitas.Hora);
                ocmd.Parameters.Add("@id_paciente", ocitas.Id_paciente);
                ocmd.Parameters.Add("@id_medico", ocitas.Id_medico);
                ocmd.Parameters.Add("@valor", ocitas.Valor);
                ocmd.Parameters.Add("@diagnostico ", ocitas.Diagnostico);
                ocmd.Parameters.Add("@nom_acompañante", ocitas.Nom_acompañante);
                ocmd.Parameters.Add("@activo", ocitas.Activo);

                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }


        public bool Anular_cita(CEcitas ocitas)// de CECitas recibe la información para guardar citas.
        {
            
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "anula_cita";
                ocmd.Parameters.Add("@pcod_cita", ocitas.Cod_cita);
                ocmd.ExecuteNonQuery();
                return true;

            }


            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
    

        public DataSet Consultar_cita(CEcitas ocitas)
        { 
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "consultar_citas";
                ocmd.Parameters.Add("@Cod_cita", ocitas.Cod_cita);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

    }
}








