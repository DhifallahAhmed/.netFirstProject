using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {
        public Personne(string nom, string prenom, string email, string password, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
            DateNaissance = dateNaissance;
        }
        public Personne()
        {

        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateNaissance { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"[{Id},{Nom};{Prenom},{Email},{Password},{DateNaissance}]";
        }
        //public bool Login(string nom, string password)
        //{
        //    return nom== Nom && password==Password;
        //}
        //public bool Login(string nom, string password,string email)
        //{
        //    return nom == Nom && password == Password && email==Email;
        //}
        public bool Login(string nom, string password, string email=null)
        {
            if (email != null)
                return nom == Nom && password == Password && email == Email;
            else
                return nom == Nom && password == Password;
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("I am a Person");
        }

    }
}
