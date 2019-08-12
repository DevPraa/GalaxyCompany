using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AirPort.Module.BusinessObjects.Galaxy_db;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.ReportsV2;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
//using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using DevExpress.XtraReports.Extensions;//.v12.2.Extensions.dll
using DevExpress.XtraReports.UI;
using DevExpress.LookAndFeel;

namespace AirPort.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PilotViewController : ViewController
    {
        public PilotViewController()
        {
            //var t = View;
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            //SimpleAction action = new SimpleAction(this, "TestPrint", PredefinedCategory.Reports);
            //action.Execute += simpleReport_Execute;
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void ShowReportPilot_Action_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IObjectSpace objectSpace = ReportDataProvider.ReportObjectSpaceProvider.CreateObjectSpace(typeof(ReportDataV2));
            ReportDataV2 reportData = objectSpace.FindObject<ReportDataV2>(CriteriaOperator.Parse("[DisplayName] = 'Pilot Report'"));
            string handle = ReportDataProvider.ReportsStorage.GetReportContainerHandle(reportData);
            ReportServiceController controller = Frame.GetController<ReportServiceController>();
            if (controller != null)
            {
                controller.ShowPreview(handle);
            }
        }

        private void simpleReport_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            IReportDataV2 reportData = View.ObjectSpace.FindObject<ReportDataV2>(new BinaryOperator("DisplayName", "Pilot Report"));
            DevExpress.XtraReports.UI.XtraReport report = ReportDataProvider.ReportsStorage.LoadReport(reportData);
            IObjectSpace objectSpace = Application.CreateObjectSpace(typeof(rb_Pilot));
            List<rb_Pilot> list = new List<rb_Pilot>();
            list.Add(objectSpace.FindObject<rb_Pilot>(new BinaryOperator("Id", $"{(View.SelectedObjects[0] as rb_Pilot)?.Id ?? 0}")));
            report.DataSource = list;
            ReportsModuleV2.FindReportsModule(Application.Modules).ReportsDataSourceHelper.SetupBeforePrint(report);
            using(ReportPrintTool printTool = new ReportPrintTool(report)) {
                // Invoke the Print Preview form modally,  
                // and load the report document into it. 
                printTool.ShowPreviewDialog();

                // Invoke the Print Preview form 
                // with the specified look and feel setting. 
                //printTool.ShowPreviewDialog(UserLookAndFeel.Default);
            }

        }
    }
}
