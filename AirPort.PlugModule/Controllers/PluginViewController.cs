using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using AirPort.Module.BusinessObjects.Galaxy_db;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Utils;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace AirPort.PlugModule.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PluginViewController : ObjectViewController<ListView,rb_Airport>
    {
        public PluginViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
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
            GridListEditor gridListEditor = View.Editor as GridListEditor;
            if (gridListEditor != null)
            {
                GridView gridView = gridListEditor.GridView;
                gridListEditor.Grid.HandleCreated += (s, e) =>
                {
                    gridView.OptionsView.ShowColumnHeaders = true;
                    gridView.OptionsView.ShowIndicator = false;
                    gridView.OptionsView.ShowVerticalLines = DefaultBoolean.False;
                };
                gridView.CalcRowHeight += (s, e) =>
                {
                    e.RowHeight = 20;
                };
                gridView.CustomDrawColumnHeader += (s, e) =>
                {
                    if (e.Column == null) return;
                    if (e.Column.AppearanceHeader.BackColor != Color.Empty)
                    {
                        e.Info.AllowColoring = true; 
                    }
                    e.Column.AppearanceHeader.Font = new Font(new FontFamily("Tahoma"), 10f, FontStyle.Bold);
                };
            }
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
