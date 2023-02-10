using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public Passenger()
        {
        }

        public Passenger(string firstName, string lastName, string emailAddress, int passportNumber, int telNumber, DateTime birthDate, ICollection<Flight> flights)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PassportNumber = passportNumber;
            TelNumber = telNumber;
            BirthDate = birthDate;
            Flights = flights;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int PassportNumber { get; set; }
        public int TelNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return $"BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, FirstName: {FirstName}, LastName: {LastName}, TelNumber: {TelNumber},Flights: {Flights}";
        }
        public bool CheckProfile(string firstName, string lastName)
        {
            // Vérification du profil en utilisant seulement le nom et le prénom
            // ...
            if(firstName == FirstName && lastName == LastName)

            return true;
            else return false ;
        }

        public bool CheckProfile(string firstName, string lastName, string email)
        {
            // Vérification du profil en utilisant le nom, le prénom et l'email
            // ...
            if (firstName == FirstName && lastName == LastName && email==EmailAddress)
                return true;
            else return false ;
        }

        public bool CheckProfilee(string firstName, string lastName, string email = null)
        {
            if (email == null)
            {
                // Vérification du profil en utilisant seulement le nom et le prénom
                // ...
                if (firstName == FirstName && lastName == LastName)
                    return true;
                else return false;
            }
            else
            {
                // Vérification du profil en utilisant le nom, le prénom et l'email
                // ...
                if (firstName == FirstName && lastName == LastName && email == EmailAddress)
                    return true;
                else return false;
            }
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }
    }
}
