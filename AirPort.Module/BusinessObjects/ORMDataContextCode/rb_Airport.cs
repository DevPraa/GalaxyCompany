using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace AirPort.Module.BusinessObjects.Galaxy_db
{
    [NavigationItem("Main")]
    [DefaultClassOptions]
    [DefaultProperty("Name")]
    public partial class rb_Airport
    {
        public rb_Airport(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
