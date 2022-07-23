using System;
namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId{get;private set;}
        public string Nombre {get;set;}
        public TiposJornada Jornada { get; internal set; }

        public Curso() => UniqueId = UniqueId = Guid.NewGuid().ToString();
        
    }
}