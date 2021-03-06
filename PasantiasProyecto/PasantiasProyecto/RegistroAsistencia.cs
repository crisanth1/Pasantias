﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasantiasProyecto
{
    class RegistroAsistencia
    {
        private int idRegistroAsistencia;
        private float horasRealizadas;
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private string periodoAcademico;
        private Practicante practicante;
        private List<Actividad> actividades;

        public int IdRegistroAsistencia { get => idRegistroAsistencia; set => idRegistroAsistencia = value; }
        public float HorasRealizadas { get => horasRealizadas; set => horasRealizadas = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string PeriodoAcademico { get => periodoAcademico; set => periodoAcademico = value; }
        internal Practicante Practicante { get => practicante; set => practicante = value; }
        internal List<Actividad> Actividades { get => actividades; set => actividades = value; }

        public RegistroAsistencia(int idRegistroAsistencia, float horasRealizadas, DateTime fechaFin, DateTime fechaInicio, string periodoAcademico, Practicante practicante, List<Actividad> actividades)
        {
            this.idRegistroAsistencia = idRegistroAsistencia;
            this.horasRealizadas = horasRealizadas;
            this.fechaFin = fechaFin;
            this.fechaInicio = fechaInicio;
            this.periodoAcademico = periodoAcademico;
            this.practicante = practicante;
            this.actividades = actividades;
        }

        public RegistroAsistencia()
        {
        }

        public override string ToString()
        {
            return this.IdRegistroAsistencia+"";
        }
    }
}
