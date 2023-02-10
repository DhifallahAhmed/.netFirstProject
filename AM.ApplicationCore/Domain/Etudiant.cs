using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Etudiant : Personne
    {
        public Etudiant()
        {
        }

        public Etudiant(int matricule, string specialite)
        {
            Matricule = matricule;
            Specialite = specialite;
        }


        public int Matricule { get; set; }
        public string Specialite { get; set; }
        public override void GetMyType()
        {
            Console.WriteLine("I am a Student");
        }

    }
   

}
