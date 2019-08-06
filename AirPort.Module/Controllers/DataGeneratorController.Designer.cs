namespace AirPort.Module.Controllers
{
    partial class DataGeneratorController
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
            this.DGC_Generate_Action = new DevExpress.ExpressApp.Actions.SimpleAction();
            // 
            // DGC_Generate_Action
            // 
            this.DGC_Generate_Action.Caption = "DGC_Generate_Action_Id";
            this.DGC_Generate_Action.ConfirmationMessage = null;
            this.DGC_Generate_Action.Id = "DGC_Generate_Action_Id";
            this.DGC_Generate_Action.ToolTip = null;
            this.DGC_Generate_Action.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.DGC_Generate_Action_Execute);
            // 
            // DataGeneratorController
            // 
            this.Actions.Add(this.DGC_Generate_Action);
            this.TargetWindowType = DevExpress.ExpressApp.WindowType.Main;

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction DGC_Generate_Action;
    }
}
