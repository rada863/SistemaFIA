using System;

namespace proyecto2.modelo
{
    


    public enum CategoriaAuto { FormulaE, F2, F1 }
    public enum UnidadPotencia { UPGen3_350, UPGen3_470, MGU1, MGU2 }
    public enum DRSType { Ninguno, DRSXA, DRSXB,
        Activado,
        Desactivado
    }

    public class Auto
    {
        public int AutoID { get; set; }

        public string Modelo { get; set; } = string.Empty;

        public CategoriaAuto Categoria { get; set; }

        public UnidadPotencia UnidadPotencia { get; set; }

        public DRSType DRS { get; set; }

        public bool TieneHALO { get; set; }

        public int? EquipoID { get; set; }
        
        public  string Equipo { get; set; }
        



        public string DescripcionCompleta =>
            $"{Modelo} ({Categoria}) - UP: {UnidadPotencia}" +
            (Categoria == CategoriaAuto.F1 ? $" - DRS: {DRS} - HALO: {(TieneHALO ? "Sí" : "No")}" : "");

        public bool ValidarUnidadPotencia()
        {
            return Categoria switch
            {
                CategoriaAuto.FormulaE => UnidadPotencia == UnidadPotencia.UPGen3_350 || UnidadPotencia == UnidadPotencia.UPGen3_470,
                CategoriaAuto.F2 or CategoriaAuto.F1 => UnidadPotencia == UnidadPotencia.MGU1 || UnidadPotencia == UnidadPotencia.MGU2,
                _ => false
            };
        }

       
    }
}