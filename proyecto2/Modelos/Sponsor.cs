namespace proyecto2.Modelos
{
    public class Sponsor
    {
        public int SponsorID { get; set; }
        public string Nombre { get; set; }
        public string Industria { get; set; }
        public decimal Inversion { get; set; }
        public int? EquipoID { get; set; }
    }
}