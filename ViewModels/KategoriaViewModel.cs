using System;

namespace Forum.ViewModels
{
    public class KategoriaViewModel { 
        public int Id { get; set; }
        public string Nazwa { get; set; }

        public DateTime DataUtworzenia { get; set; }

        public int IloscWatkow { get; set; }
    }
}