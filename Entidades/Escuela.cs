namespace CoreEscuela.Entidades
{
    class Escuela
    {
        string nombre;
        
        // Encapsular variable nombre
        public string Nombre
        {
            get{ return nombre; }
            set{ nombre = value.ToUpper();}
        }

        public int AñoDeCreacion{ get; set;}

        public string Pais { get; set; }

        public string Ciudad { get; set; }

        public TiposEscuela TipoEscuela {get; set;}

        // public Escuela(string nombre, int año)
        // {
        //     this.nombre = nombre;
        //     this.AñoDeCreacion = año;
        // }

        public Escuela(string nombre, int año, string pais, string ciudad) => (Nombre, AñoDeCreacion, Pais, Ciudad) = (nombre, año, pais, ciudad);
        public Escuela(string nombre, 
                        int año, 
                        TiposEscuela tiposEscuela,
                        string pais = "", 
                        string ciudad = "")
                        {
                            (Nombre, AñoDeCreacion, Pais, Ciudad, TipoEscuela) = (nombre, año, pais, ciudad, tiposEscuela);
                        }

        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine} Pais: {Pais}, Ciudad:{Ciudad}";
        }
    }
}