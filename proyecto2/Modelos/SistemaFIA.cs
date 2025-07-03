using FIA_System.Models;
using proyecto2.modelo;
using proyecto2.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace proyecto2.Modelos
{
    public class SistemaFIA
    {
        public List<Equipo> Equipos { get; } = new();
        public List<Piloto> Pilotos { get; } = new();
        public List<Auto> Autos { get; } = new();
        public List<Sponsor> Sponsors { get; } = new();

        private int _nextEquipoID = 1;
        private int _nextPilotoID = 1;
        private int _nextAutoID = 1;
        private int _nextSponsorID = 1;

        // ------------------ EQUIPOS ------------------
        public Equipo AgregarEquipo(string nombre, string pais, DateTime fundacion)
        {
            var equipo = new Equipo
            {
                EquipoID = _nextEquipoID++,
                Nombre = nombre,
                Pais = pais,
                Fundacion = fundacion
            };
            Equipos.Add(equipo);
            return equipo;
        }

        public bool EliminarEquipo(int equipoID)
        {
            var equipo = Equipos.FirstOrDefault(e => e.EquipoID == equipoID);
            if (equipo == null) return false;

            if (equipo.SponsorPrincipal != null)
            {
                equipo.SponsorPrincipal.EquipoID = null;
                equipo.SponsorPrincipal = null;
            }

            foreach (var piloto in equipo.Pilotos.ToList())
            {
                piloto.EquipoID = null;
                equipo.RemoverPiloto(piloto);
            }

            foreach (var auto in equipo.Autos.ToList())
            {
                auto.EquipoID = null;
                equipo.RemoverAuto(auto);
            }

            return Equipos.Remove(equipo);
        }

        // ------------------ PILOTOS ------------------
        public Piloto AgregarPiloto(string nombre, int edad, string numeroLicencia, DateTime? superLicencia)
        {
            var piloto = new Piloto
            {
                PilotoID = _nextPilotoID++,
                Nombre = nombre,
                Edad = edad,
                NumeroLicencia = numeroLicencia,
                SuperLicenciaF1 = superLicencia
            };
            Pilotos.Add(piloto);
            return piloto;
        }

        // ------------------ AUTOS ------------------
         public Auto AgregarAuto(string modelo, CategoriaAuto categoria, string unidadPotencia,
                        DRSType drs, bool tieneHALO)
        {
            var auto = new Auto
            {
                AutoID = _nextAutoID++,
                Modelo = modelo,
                Categoria = (modelo.CategoriaAuto)categoria, // corregido: no hace falta castear
                UnidadPotencia = (modelo.UnidadPotencia)Enum.Parse(typeof(UnidadPotencia), unidadPotencia),
                DRS = (modelo.DRSType)(int)drs, // me costo horror y dudo que este bien pero asi entro jajjaja 
                TieneHALO = tieneHALO
            };
            Autos.Add(auto);
            return auto;
        
        }

        // ------------------ SPONSORS ------------------
        public Sponsor AgregarSponsor(string nombre, string industria, decimal inversion)
        {
            var sponsor = new Sponsor
            {
                SponsorID = _nextSponsorID++,
                Nombre = nombre,
                Industria = industria,
                Inversion = inversion
            };
            Sponsors.Add(sponsor);
            return sponsor;
        }

        // ------------------ ASIGNACIONES ------------------
        public bool AsignarPilotoAEquipo(int pilotoID, int equipoID)
        {
            var piloto = Pilotos.FirstOrDefault(p => p.PilotoID == pilotoID);
            var equipo = Equipos.FirstOrDefault(e => e.EquipoID == equipoID);

            if (piloto == null || equipo == null || piloto.EquipoID.HasValue)
                return false;

            if (equipo.AgregarPiloto(piloto))
            {
                piloto.EquipoID = equipoID;
                return true;
            }

            return false;
        }

        public bool AsignarAutoAEquipo(int autoID, int equipoID)
        {
            var auto = Autos.FirstOrDefault(a => a.AutoID == autoID);
            var equipo = Equipos.FirstOrDefault(e => e.EquipoID == equipoID);

            if (auto == null)
                return false;

            if (equipo == null)
                return false;

            if (auto.EquipoID.HasValue)
                return false; // Ya está asignado a un equipo

            bool agregado = equipo.AgregarAuto(auto);
            if (!agregado)
                return false;

            auto.EquipoID = equipoID;
            return true;
        }

        public bool AsignarSponsorAEquipo(int sponsorID, int equipoID)
        {
            var sponsor = Sponsors.FirstOrDefault(s => s.SponsorID == sponsorID);
            var equipo = Equipos.FirstOrDefault(e => e.EquipoID == equipoID);

            if (sponsor == null || equipo == null || sponsor.EquipoID.HasValue)
                return false;

            if (equipo.SponsorPrincipal != null)
                equipo.SponsorPrincipal.EquipoID = null;

            sponsor.EquipoID = equipoID;
            equipo.SponsorPrincipal = sponsor;
            equipo.SponsorID = sponsorID;

            return true;
        }

        // ------------------ REPORTES ------------------
        public decimal PorcentajeAutosSinAsignar()
        {
            if (Autos.Count == 0) return 0;
            int asignados = Equipos.Sum(e => e.Autos.Count);
            return (Autos.Count - asignados) * 100m / Autos.Count;
        }

        public Dictionary<string, int> AutosPorEquipo()
        {
            return Equipos.ToDictionary(
                e => e.Nombre,
                e => e.Autos.Count
            );
        }

        // ------------------ DATOS DE PRUEBA ------------------
        public void CargarDatosPrueba()
        {
            var mercedes = AgregarEquipo("Mercedes AMG Petronas", "Alemania", new DateTime(1954, 1, 1));
            var ferrari = AgregarEquipo("Scuderia Ferrari", "Italia", new DateTime(1929, 1, 1));
            var redbull = AgregarEquipo("Red Bull Racing", "Austria", new DateTime(2005, 1, 1));

            var hamilton = AgregarPiloto("Lewis Hamilton", 38, "FIA001", DateTime.Now.AddYears(1));
            var russell = AgregarPiloto("George Russell", 25, "FIA002", DateTime.Now.AddYears(1));
            var leclerc = AgregarPiloto("Charles Leclerc", 25, "FIA003", DateTime.Now.AddYears(1));
            var sainz = AgregarPiloto("Carlos Sainz", 28, "FIA004", DateTime.Now.AddYears(1));
            var verstappen = AgregarPiloto("Max Verstappen", 25, "FIA005", DateTime.Now.AddYears(1));
            var perez = AgregarPiloto("Sergio Pérez", 33, "FIA006", DateTime.Now.AddYears(1));
            var pilotofe = AgregarPiloto("Piloto FE", 28, "FIA007", null);

            var mercedesW14 = AgregarAuto("W14", CategoriaAuto.F1, "MGU2", DRSType.DRSXA, true);
            var ferrariSF23 = AgregarAuto("SF-23", CategoriaAuto.F1, "MGU2", DRSType.DRSXB, true);
            var redbullRB19 = AgregarAuto("RB19", CategoriaAuto.F1, "MGU1", DRSType.DRSXA, true);
            var autoFE = AgregarAuto("Gen3", CategoriaAuto.FormulaE, "UPGen3_470", DRSType.Ninguno, false);
            var autoF2 = AgregarAuto("F2 2023", CategoriaAuto.F2, "MGU1", DRSType.Ninguno, false);

            var petronas = AgregarSponsor("Petronas", "Energía", 5000000);
            var shell = AgregarSponsor("Shell", "Combustibles", 4000000);
            var puma = AgregarSponsor("Puma", "Deportes", 3000000);

            AsignarPilotoAEquipo(hamilton.PilotoID, mercedes.EquipoID);
            AsignarPilotoAEquipo(russell.PilotoID, mercedes.EquipoID);
            AsignarPilotoAEquipo(leclerc.PilotoID, ferrari.EquipoID);
            AsignarPilotoAEquipo(sainz.PilotoID, ferrari.EquipoID);
            AsignarPilotoAEquipo(verstappen.PilotoID, redbull.EquipoID);
            AsignarPilotoAEquipo(perez.PilotoID, redbull.EquipoID);
            AsignarPilotoAEquipo(pilotofe.PilotoID, mercedes.EquipoID);

            AsignarAutoAEquipo(mercedesW14.AutoID, mercedes.EquipoID);
            AsignarAutoAEquipo(ferrariSF23.AutoID, ferrari.EquipoID);
            AsignarAutoAEquipo(redbullRB19.AutoID, redbull.EquipoID);

            AsignarSponsorAEquipo(petronas.SponsorID, mercedes.EquipoID);
            AsignarSponsorAEquipo(shell.SponsorID, ferrari.EquipoID);
            AsignarSponsorAEquipo(puma.SponsorID, redbull.EquipoID);
        }
    }
}