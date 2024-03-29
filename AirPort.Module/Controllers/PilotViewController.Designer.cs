﻿namespace AirPort.Module.Controllers
{
    partial class PilotViewController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowReportPilot_Action = new DevExpress.ExpressApp.Actions.SimpleAction();
            this.simpleReport = new DevExpress.ExpressApp.Actions.SimpleAction();
            // 
            // ShowReportPilot_Action
            // 
            this.ShowReportPilot_Action.Caption = "ShowReportPilot_Action";
            this.ShowReportPilot_Action.ConfirmationMessage = null;
            this.ShowReportPilot_Action.Id = "ShowReportPilot_Action";
            this.ShowReportPilot_Action.ImageName = "BO_Report";
            this.ShowReportPilot_Action.TargetObjectType = typeof(AirPort.Module.BusinessObjects.Galaxy_db.rb_Pilot);
            this.ShowReportPilot_Action.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.ShowReportPilot_Action.ToolTip = null;
            this.ShowReportPilot_Action.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.ShowReportPilot_Action.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ShowReportPilot_Action_Execute);
            // 
            // simpleReport
            // 
            this.simpleReport.Caption = "Simple Report";
            this.simpleReport.Category = "Reports";
            this.simpleReport.ConfirmationMessage = null;
            this.simpleReport.Id = "SimpleReport";
            this.simpleReport.TargetObjectType = typeof(AirPort.Module.BusinessObjects.Galaxy_db.rb_Pilot);
            this.simpleReport.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.simpleReport.ToolTip = null;
            this.simpleReport.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.simpleReport.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleReport_Execute);
            // 
            // PilotViewController
            // 
            this.Actions.Add(this.ShowReportPilot_Action);
            this.Actions.Add(this.simpleReport);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ShowReportPilot_Action;
        private DevExpress.ExpressApp.Actions.SimpleAction simpleReport;
    }
}
