//// See https://aka.ms/new-console-template for more information

////declaration variable;

//int nb = int.Parse(Console.ReadLine());

//for (int i = 0; i < nb; i++)
//{
//    string chaine = null;
//    float? age = null;
//    //do {
//    while (age <= 0)
//    {
//        try
//        {
//            age = float.Parse(Console.ReadLine());
//        }
//        catch
//        {
//            Console.WriteLine("Erreur");
//        }
//    }
//    //} while (age<=0);

//    Console.WriteLine("Hello " + chaine + " Age =" + (age + 1));
//}

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Service;
using System.Collections;
Personne personne = new Personne();
personne.Id = 0;
personne.Nom = "foulen";
personne.Prenom = "foulen";
personne.Email = "email@gmail.com";
personne.Password = "123456";
personne.DateNaissance = DateTime.Now;

Etudiant personne1 = new Etudiant() ;
Personne personne2 = new Personne() { Nom = "nom1", Prenom = "prenom", Email = "mail" };

personne.GetMyType();
personne1.GetMyType();
Passenger passenger = new Passenger();
passenger.PassengerType();

Console.WriteLine();

Passenger staff = new Staff();
staff.PassengerType();




ServiceFlight sf = new ServiceFlight();

sf.Flights = TestData.listFlights;


foreach (var item in sf.GetFlightDates("Madrid"))
Console.WriteLine(item);

sf.GetFlights("Destination", "Paris");




