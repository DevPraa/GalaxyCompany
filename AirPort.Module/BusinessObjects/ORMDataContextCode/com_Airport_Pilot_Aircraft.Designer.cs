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

    [Persistent(@"com_Airport_Pilot_Aircraft")]
    public partial class com_Airport_Aircraft : XPLiteObject
    {
        int _Id;
        [Key(true)]
        [Browsable(false)]
        public int Id
        {
            get { return _Id; }
            set { SetPropertyValue<int>("Id", ref _Id, value); }
        }
        rb_Airport _Id_Airport;
        [Association(@"com_Airport_Pilot_AircraftReferencesrb_Airport")]
        public rb_Airport Id_Airport
        {
            get { return _Id_Airport; }
            set { SetPropertyValue<rb_Airport>("Id_Airport", ref _Id_Airport, value); }
        }
        rb_Aircraft _Id_Aircraft;
        [Association(@"com_Airport_Pilot_AircraftReferencesrb_Aircraft")]
        public rb_Aircraft Id_Aircraft
        {
            get { return _Id_Aircraft; }
            set { SetPropertyValue<rb_Aircraft>("Id_Aircraft", ref _Id_Aircraft, value); }
        }
    }

}
