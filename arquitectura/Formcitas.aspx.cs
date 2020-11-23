using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using capaentidades;
using System.Data;
using capanegocio;

namespace arquitectura
{
    public partial class Formcitas : System.Web.UI.Page
    {
        CNcitas ONcitas = new CNcitas();
        CEcitas OEcitas = new CEcitas();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btconsultar_cita_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEcitas.Cod_cita = txtcod_cita.Text;
            ds = ONcitas.consultar_cita(OEcitas);
            if(ds.Tables[0].Rows.Count==0)
            {
                lblresultado.Text = "Cita no encontrada";
            }
            else
            {
                txtfecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
            }

        }

        protected void btguardar_Click(object sender, EventArgs e)
        {
            OEcitas.Cod_cita = txtcod_cita.Text;
            OEcitas.Fecha = txtfecha.Text;
            OEcitas.Hora = txthora.Text;
            OEcitas.Valor = Convert.ToInt32(txtvalor.Text);
            OEcitas.Id_paciente = txtid_paciente.Text;
            OEcitas.Id_medico = txtid_medico.Text;
            OEcitas.Diagnostico = txtdiagnostico.Text;
            OEcitas.Nom_acompañante = txtnom_acompañante.Text;
            if(ONcitas.guardar_cita(OEcitas))
            {
                lblresultado.Text = "cita guardada";

            }
            else
            {
                lblresultado.Text = "error al guardar la cita";
            }
        }
    }
}