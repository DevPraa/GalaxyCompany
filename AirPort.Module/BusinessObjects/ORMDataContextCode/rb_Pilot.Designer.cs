﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AirPort.Module.BusinessObjects.Galaxy_db
{

    public partial class rb_Pilot : XPLiteObject
    {
        int _Id;
        [Key(true)]
        [Browsable(false)]
        public int Id
        {
            get { return _Id; }
            set { SetPropertyValue<int>("Id", ref _Id, value); }
        }
        string _FirstName;
        [DevExpress.Persistent.Validation.RuleRequiredField]
        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue<string>("FirstName", ref _FirstName, value); }
        }
        string _LastName;
        [DevExpress.Persistent.Validation.RuleRequiredField]
        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue<string>("LastName", ref _LastName, value); }
        }
        [DevExpress.Xpo.DisplayName(@"Full Name")]
        [PersistentAlias("[LastName] + ' ' + [FirstName]")]
        public string FullName
        {
            get { return (string)(EvaluateAlias("FullName")); }
        }
        rb_Airport _Id_Airport;
        [Association(@"rb_PilotReferencesrb_Airport")]
        public rb_Airport Id_Airport
        {
            get { return _Id_Airport; }
            set { SetPropertyValue<rb_Airport>("Id_Airport", ref _Id_Airport, value); }
        }

        public int AirCraftCount
        {
            get { return com_Pilot_Aircrafts?.Count ?? 0; }
        }

        [Association(@"com_Pilot_AircraftReferencesrb_Pilot")]
        public XPCollection<com_Pilot_Aircraft> com_Pilot_Aircrafts { get { return GetCollection<com_Pilot_Aircraft>("com_Pilot_Aircrafts"); } }
    }

}
