﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirPort.Module.BusinessObjects.Galaxy_db;
using AirPort.Module.Repositories;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo.DB;

namespace AirPort.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
    public partial class DataGeneratorController : WindowController
    {
        public DataGeneratorController()
        {
            InitializeComponent();
            // Target required Windows (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target Window.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void DGC_Generate_Action_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            TestDataRepository testData = new TestDataRepository(ConnectionHelper.GetDataLayer(AutoCreateOption.None));
            testData.GenerateData();
        }
    }
}
