using FIA_System.Models;
using proyecto2.modelo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace proyecto2.Modelos
{
    public class Equipo
    {
        public int EquipoID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Pais { get; set; } = string.Empty;
        public DateTime Fundacion { get; set; }

        public List<Piloto> Pilotos { get; } = new();
        public List<Auto> Autos { get; } = new();

        public Sponsor? SponsorPrincipal { get; set; }
        public int? SponsorID { get; set; }

        public bool AgregarPiloto(Piloto piloto)
        {
            if (piloto == null || Pilotos.Count >= 4 || Pilotos.Contains(piloto))
                return false;

            Pilotos.Add(piloto);
            return true;
        }

        public bool RemoverPiloto(Piloto piloto)
        {
            return Pilotos.Remove(piloto);
        }

        public bool AgregarAuto(Auto auto)
        {
            if (auto == null || Autos.Count >= 2 || Autos.Contains(auto))
                return false;

            Autos.Add(auto);
            return true;
        }

        public bool RemoverAuto(Auto auto)
        {
            return Autos.Remove(auto);
        }

        public string ListarPilotos() =>
            Pilotos.Any()
                ? string.Join("\n", Pilotos.Select(p => p.Nombre))
                : "Sin pilotos asignados.";

        public string ListarAutos() =>
            Autos.Any()
                ? string.Join("\n", Autos.Select(a => a.DescripcionCompleta))
                : "Sin autos asignados.";
    }
}