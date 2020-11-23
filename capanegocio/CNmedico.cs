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
    public class CNmedico
    {
        CDmedico odatmedico = new CDmedico();
        public bool guardar_medico(CEmedico oentmedico)
        {
            return odatmedico.Guardar_medico(oentmedico);
        }
        public bool anular_medico(CEmedico oentmedico)
        {
            return odatmedico.Anular_medico(oentmedico);
        }
        public DataSet consultar_medico(CEmedico oentmedico)
        {
            return odatmedico.Consultar_medico(oentmedico);
        }
    }
}
