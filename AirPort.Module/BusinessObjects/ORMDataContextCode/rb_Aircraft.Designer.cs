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
using DevExpress.ExpressApp.ConditionalAppearance;
using System.Drawing;

namespace AirPort.Module.BusinessObjects.Galaxy_db
{

    public partial class rb_Aircraft : XPLiteObject
    {
        int _Id;
        [Key(true)]
        [Browsable(false)]
        public int Id
        {
            get { return _Id; }
            set { SetPropertyValue<int>("Id", ref _Id, value); }
        }
        string _Name;
        [Size(199)]
        [DevExpress.Persistent.Validation.RuleRequiredField]
        [Appearance("Completed1", TargetItems = "Name", Criteria = "Name like '%A%'", FontStyle = FontStyle.Bold, FontColor = "ForestGreen")]
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>("Name", ref _Name, value); }
        }
        [Association(@"com_Airport_AircraftReferencesrb_Aircraft")]
        public XPCollection<com_Airport_Aircraft> com_Airport_Aircrafts { get { return GetCollection<com_Airport_Aircraft>("com_Airport_Aircrafts"); } }
        [Association(@"com_Pilot_AircraftReferencesrb_Aircraft")]
        public XPCollection<com_Pilot_Aircraft> com_Pilot_Aircrafts { get { return GetCollection<com_Pilot_Aircraft>("com_Pilot_Aircrafts"); } }
    }

}
