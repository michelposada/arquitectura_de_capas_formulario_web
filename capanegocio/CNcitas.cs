using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capadatos;
using capaentidades;
using System.Data;

namespace capanegocio
{
    public class CNcitas
    {
        CDcitas odcitas = new CDcitas();
        public bool guardar_cita(CEcitas oecitas)
        {
            return odcitas.Guardar_cita(oecitas);
        }
        public bool anular_cita(CEcitas oecitas)
        {
            return odcitas.Anular_cita(oecitas);
        }
        public DataSet consultar_cita(CEcitas oecitas)
        {
            return odcitas.Consultar_cita(oecitas);
        }

    }
}
