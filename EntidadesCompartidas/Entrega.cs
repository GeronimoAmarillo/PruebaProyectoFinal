namespace EntidadesCompartidas
{
    using System;
    using System.Collections.Generic;

    public partial class Entrega
    {
        public int Codigo { get; set; }
        
        public DateTime Fecha { get; set; }
        
        public string NombreReceptor { get; set; }

        public long ClienteReceptor { get; set; }

        public long ClienteEmisor { get; set; }

        public int LocalReceptor { get; set; }

        public int LocalEmisor { get; set; }
        
        public string Turno { get; set; }

        public Cliente Clientes { get; set; }

        public Cliente Clientes1 { get; set; }
        
        public List<Paquete> Paquetes { get; set; }

        public Local Locales { get; set; }

        public Local Locales1 { get; set; }

        public Turno Turnos { get; set; }
        
        public List<Paquete> Paquetes1 { get; set; }
    }
}
