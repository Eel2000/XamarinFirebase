using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFirebase.Models
{
    public class Parent
    {
        public string Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public IEnumerable<Enfant> Enfants { get; set; }
    }
}
