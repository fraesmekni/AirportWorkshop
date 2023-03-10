using AM.ApplicationCore;
using AM.ApplicationCore.Domaine;
using AM.ApplicationCore.Services;
using System.Collections;
using System.Collections.Generic;

namespace AM.UI.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            plane.MyPlaneType = PlaneType.Airbus;
            plane.Capacity = 200;
            plane.ManufactureDate = new DateTime(2018, 11, 10);


            Plane p2 = new Plane(PlaneType.Boing, 300, DateTime.Now);
            System.Console.WriteLine(p2);
            Plane p = new Plane
            {
                MyPlaneType = PlaneType.Airbus,
                Capacity = 150,
                ManufactureDate = new DateTime(2015, 02, 03)
            };
            Boolean x;

            System.Console.WriteLine(p);
            Passenger passenger = new Passenger();
            x = passenger.CheckProfile("Fares", "Mekni", "medfares.mekni@esprit.tn");
            System.Console.WriteLine(x);
            passenger.GetPassengerType();

            Staff staff = new Staff();
            staff.GetPassengerType();
            Traveller traveller = new Traveller();
            traveller.GetPassengerType();


            System.Console.WriteLine(passenger.GetPassengerType());
            System.Console.WriteLine(staff.GetPassengerType());
            System.Console.WriteLine(traveller.GetPassengerType());

            /*ArrayList list= new ArrayList();
            list.Add(10);
            list.Add("ABC");
            list.Add('t');

            for (int i = 0; i < list.Count ; i++)
            {
                System.Console.WriteLine(list[i]);
            }


            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }

            List<Passenger> list2= new List<Passenger>();
            list2.Add(new Passenger() { BirthDate = DateTime.Now, FirstName="Foulen",LastName="Fouleni" });

            List<Passenger> list3= new List<Passenger>()
            {
                new () {BirthDate = DateTime.Now, FirstName="Foulen",LastName="Fouleni"},
                new Passenger() {BirthDate = DateTime.Now, FirstName="Foulen2",LastName="Fouleni2"}
            };

            List<Traveller> list4= new List<Traveller>()
            {
                new () {BirthDate = DateTime.Now, Nationality="TN"}
            };
            List<Staff> list5= new List<Staff>()
            {
                new () {BirthDate = DateTime.Now, PasseportNumber="78946413TN"}
            };

            //list3.AddRange(list4);

            list3 = new List<Passenger>(list4);*/

            ServiceFlight serviceFlight = new ServiceFlight();

            serviceFlight.Flights = TestData.Flights;



        }
    }
}