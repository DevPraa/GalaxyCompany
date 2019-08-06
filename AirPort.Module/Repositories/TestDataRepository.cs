using AirPort.Module.BusinessObjects.Galaxy_db;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.Module.Repositories
{
    internal class TestDataRepository
    {
        IDataLayer _DLA;
        public TestDataRepository(IDataLayer DLA)
        {
            _DLA = DLA;
        }

        public void AddPilots()
        {
           var pilots = File.ReadAllLines(@"TestData\Pilots.txt");
            foreach (var item in pilots)
            {
                try
                {
                    Utils.TestDataParser.ParsePilots(item, out string FirstName, out string LastName);
                    AddPilot(FirstName, LastName);
                }
                catch { }
            }
        }

        public void AddAircrafts()
        {
            var aircrafts = File.ReadAllLines(@"TestData\Aircrafts.txt");
            foreach (var item in aircrafts)
            {
                try
                {
                    AddAircraft(item);
                }
                catch { }
            }
        }

        public void AddAirports()
        {
            var airports = File.ReadAllLines(@"TestData\Airports.txt");
            foreach (var item in airports)
            {
                try
                {
                    AddAirport(item);
                }
                catch { }
            }
        }


        private void AddPilot(string FirstName, string LastName)
        {
            using (UnitOfWork uow = new UnitOfWork(_DLA))
            {
                rb_Pilot pilot = new rb_Pilot(uow);
                pilot.FirstName = FirstName;
                pilot.LastName = LastName;
                // p.Save(); when working with a Session 
                pilot.Save();
                // Save all the changes made 
                uow.CommitChanges();
            }
        }

        private void AddAirport(string Name)
        {
            using (UnitOfWork uow = new UnitOfWork(_DLA))
            {
                rb_Airport airport = new rb_Airport(uow);
                airport.Name = Name;
                airport.Save();
                uow.CommitChanges();
            }
        }

        private void AddAircraft(string Name)
        {
            using (UnitOfWork uow = new UnitOfWork(_DLA))
            {
                rb_Aircraft aircraft = new rb_Aircraft(uow);
                aircraft.Name = Name;
                aircraft.Save();
                uow.CommitChanges();
            }
        }

    }
}
