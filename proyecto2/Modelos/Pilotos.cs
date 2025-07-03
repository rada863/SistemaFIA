using System;

namespace FIA_System.Models
{
    public class Piloto
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public DateTime? SuperLicenciaF1 { get; set; }  
        public int? EquipoID { get; set; }
        public int PilotoID{ get; set; }
        public string? NumeroLicencia { get; set; }


        public bool PuedeCompetirEnF1 =>
            SuperLicenciaF1.HasValue && SuperLicenciaF1.Value > DateTime.Now;

        public string LicenciaInfo =>
            PuedeCompetirEnF1
                ? $"SuperLicencia F1 (Vence: {SuperLicenciaF1.Value.ToShortDateString()})"
                : "No habilitado para F1";
        
        


    }
}