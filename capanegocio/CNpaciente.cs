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
    public class CNpaciente
    {
        CDpaciente odatpaciente = new CDpaciente();
        public bool guardar_paciente(CEpaciente oentpaciente)
        {
            return odatpaciente.Guardar_paciente(oentpaciente);
        }
        public bool anular_paciente(CEpaciente oentpaciente)
        {
            return odatpaciente.Anular_paciente(oentpaciente);
        }
        public DataSet consultar_paciente(CEpaciente oentpaciente)
        {
            return odatpaciente.Consultar_paciente(oentpaciente);
        }
    }
}
