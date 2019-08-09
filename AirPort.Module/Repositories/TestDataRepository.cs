using AirPort.Module.BusinessObjects.Galaxy_db;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.Module.Repositories
{
    internal class TestDataRepository 
    {
        private IDataLayer _DLA;
        private UnitOfWork uow;
        public TestDataRepository(IDataLayer DLA)
        {
            _DLA = DLA;
            uow = new UnitOfWork(_DLA);
        }


        public void GenerateData()
        {
            AddAircrafts();
            AddAirports();
            AddPilots();
            AddRelationship();
        }

        private void AddPilots()
        {
           var pilots = File.ReadAllLines(@"TestData\Pilots.txt");
            foreach (var item in pilots)
            {
                try
                {
                    Utils.TestDataParser.ParsePilots(item, out string FirstName, out string LastName);
                    AddPilot(FirstName, LastName);
                }
                catch (Exception e)
                {
                    Trace.WriteLine($"{nameof(e)}\n{e.Message}");
                }
            }
        }

        private void AddAircrafts()
        {
            var aircrafts = File.ReadAllLines(@"TestData\Aircrafts.txt");
            foreach (var item in aircrafts)
            {
                try
                {
                    AddAircraft(item);
                }
                catch (Exception e)
                {
                    Trace.WriteLine($"{nameof(e)}\n{e.Message}");
                }
            }
        }

        private void AddAirports()
        {
            var airports = File.ReadAllLines(@"TestData\Airports.txt");
            foreach (var item in airports)
            {
                try
                {
                    AddAirport(item);
                }
                catch (Exception e)
                {
                    Trace.WriteLine($"{nameof(e)}\n{e.Message}");
                }
            }
        }

        private void AddRelationship()
        {
            try
            {
                var Pilots = GetPilots();
                var Airports = GetAirports();
                var Aircrafts = GetAircrafts();
                Random rnd = new Random();
                if (Pilots.Count > 0 && Aircrafts.Count > 0)
                {
                    foreach (var item in Pilots)
                    {
                        #region Adding relationship between Pilots and Airports
                        if (item.Id_Airport == null)
                        {
                            item.Id_Airport = Airports[rnd.Next(Airports.Count)];
                            item.Save();
                            uow.CommitChanges();
                        }
                        #endregion
                        #region Adding relationship between Pilots and Aircrafts
                        int LenghtAricraft = rnd.Next(1, 11);
                        for (int i = 0; i < LenghtAricraft; i++)
                        {
                            var indexAircraft = rnd.Next(Aircrafts.Count);
                            var com_P_A = uow.FindObject<com_Pilot_Aircraft>(CriteriaOperator.Parse("Id_Pilot=? && Id_Aircraft=?", item, Aircrafts[indexAircraft]));
                            if (com_P_A == null)
                            {
                                com_Pilot_Aircraft cpa = new com_Pilot_Aircraft(uow);
                                cpa.Id_Pilot = item;
                                cpa.Id_Aircraft = Aircrafts[indexAircraft];
                                cpa.Save();
                                uow.CommitChanges();
                            }
                            else
                            {
                                i--;
                                Trace.WriteLine($"Pilots : {LenghtAricraft}\nNot Unique {item.FullName} - {Aircrafts[indexAircraft].Name}");
                            }
                        }
                        #endregion

                    }
                }

                #region Adding relation ship between Airports and Aircrafts
                if (Airports.Count > 0 && Aircrafts.Count > 0)
                {
                    foreach (var item in Airports)
                    {
                        int LenghtAricraft = rnd.Next(1, 11);
                        for (int i = 0; i < LenghtAricraft; i++)
                        {
                            var indexAircraft = rnd.Next(Aircrafts.Count);
                            var com_A_A = uow.FindObject<com_Airport_Aircraft>(CriteriaOperator.Parse("Id_Airport=? && Id_Aircraft=?", item, Aircrafts[indexAircraft]));
                            if (com_A_A == null)
                            {
                                com_Airport_Aircraft cpa = new com_Airport_Aircraft(uow);
                                cpa.Id_Airport = item;
                                cpa.Id_Aircraft = Aircrafts[indexAircraft];
                                cpa.Save();
                                uow.CommitChanges();
                            }
                            else
                            {
                                i--;
                                Trace.WriteLine($"Airports : {LenghtAricraft}\nNot Unique {item.Name} - {Aircrafts[indexAircraft].Name}");
                            }
                        }
                    }
                }
                #endregion
            }
            catch (Exception e)
            {
                Trace.WriteLine($"{nameof(e)}\n{e.Message}");
            }
        }

        private void AddPilot(string FirstName, string LastName)
        {
            rb_Pilot pilot = new rb_Pilot(uow);
            pilot.FirstName = FirstName;
            pilot.LastName = LastName;
            pilot.Save();
            uow.CommitChanges();
        }

        private void AddAirport(string Name)
        {
            rb_Airport airport = new rb_Airport(uow);
            airport.Name = Name;
            airport.Save();
            uow.CommitChanges();
        }

        private void AddAircraft(string Name)
        {
            rb_Aircraft aircraft = new rb_Aircraft(uow);
            aircraft.Name = Name;
            aircraft.Save();
            uow.CommitChanges();
        }

        private XPCollection<rb_Pilot> GetPilots()
        {
            return new XPCollection<rb_Pilot>(uow);
        }

        private XPCollection<rb_Airport> GetAirports()
        {
            return new XPCollection<rb_Airport>(uow);
        }

        private XPCollection<rb_Aircraft> GetAircrafts()
        {
                return new XPCollection<rb_Aircraft>(uow);
        }

        ~TestDataRepository()
        {
            if (uow != null)
            {
                uow.Disconnect();
                uow.Dispose();
                Trace.WriteLine("TestDataRepository destructor called");
            }
        } 
    }
}
