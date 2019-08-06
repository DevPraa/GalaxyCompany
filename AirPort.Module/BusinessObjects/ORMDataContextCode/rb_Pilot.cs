using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace AirPort.Module.BusinessObjects.Galaxy_db
{

    [NavigationItem("Main")]
    [DefaultClassOptions,ImageName("BO_Customer")]
    [DefaultProperty("FullName")]
    public partial class rb_Pilot
    {
        public rb_Pilot(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
