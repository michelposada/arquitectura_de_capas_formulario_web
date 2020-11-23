﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidades
{
   public class CEcitas
    {
        private string cod_cita;
        private string fecha;
        private string hora;
        private string id_paciente;
        private string id_medico;
        private int valor;
        private string diagnostico;
        private string nom_acompañante;
        private byte activo;

        public string Cod_cita { get => cod_cita; set => cod_cita = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Id_paciente { get => id_paciente; set => id_paciente = value; }
        public string Id_medico { get => id_medico; set => id_medico = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Nom_acompañante { get => nom_acompañante; set => nom_acompañante = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
