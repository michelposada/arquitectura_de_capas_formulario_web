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
    public class CDpaciente
    {
        CConexion oconexion = new CConexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_paciente(CEpaciente opaciente)// de CEpaciente recibe la información para guardar paciente.
        {
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "actualizar_paciente";
                ocmd.Parameters.Add("@id_paciente", opaciente.Id_paciente);
                ocmd.Parameters.Add("@tip_doc", opaciente.Tip_doc);
                ocmd.Parameters.Add("@nom_paciente", opaciente.Nom_paciente);
                ocmd.Parameters.Add("@dir_paciente", opaciente.Dir_paciente);
                ocmd.Parameters.Add("@tel_paciente", opaciente.Tel_paciente);
                ocmd.Parameters.Add("@cel_paciente ", opaciente.Cel_paciente);
                ocmd.Parameters.Add("@activo", opaciente.Activo);

                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
        public bool Anular_paciente(CEpaciente opaciente)// de CEpaciente recibe la información para anular paciente.
        {
            
            //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento
            try  // desactiva la recoleccion automatica de errores
            {

                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar
                ocmd.CommandText = "anula_paciente";
                ocmd.Parameters.Add("@id_paciente", opaciente.Id_paciente);
                ocmd.ExecuteNonQuery();
                return true;

            }


            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
        public DataSet Consultar_paciente(CEpaciente opaciente)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "consultar_paciente";
                ocmd.Parameters.Add("@id_paciente", opaciente.Id_paciente);
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
