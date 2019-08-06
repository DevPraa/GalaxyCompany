using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AirPort.Module.BusinessObjects.Galaxy_db
{

    public partial class com_Pilot_Aircraft
    {
        public com_Pilot_Aircraft(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
