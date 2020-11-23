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
    public class CDmedico
    {
        CConexion oconexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_medico(CEmedico omedico)// de CECmedico recibe la información para guardar medico.
        {
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "actualizar_medico";
                ocmd.Parameters.Add("@id_medico", omedico.Id_medico);
                ocmd.Parameters.Add("@nom_medico", omedico.Nom_medico);
                ocmd.Parameters.Add("@especialidad", omedico.Especialidad);
                ocmd.Parameters.Add("@tel_medico", omedico.Tel_medico);
                ocmd.Parameters.Add("@activo", omedico.Activo);

                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
        public bool Anular_medico(CEmedico omedico)// de CEmedico recibe la información para guardar medico.
        {
           
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "anula_medico";
                ocmd.Parameters.Add("@id_medico", omedico.Id_medico);
                ocmd.ExecuteNonQuery();
                return true;

            }


            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
        public DataSet Consultar_medico(CEmedico omedico)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "consultar_medico";
                ocmd.Parameters.Add("@id_medico", omedico.Id_medico);
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
