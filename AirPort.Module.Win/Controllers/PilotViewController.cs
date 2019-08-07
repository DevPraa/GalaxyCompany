using System;
using System.Collections.Generic;
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

namespace AirPort.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PilotViewController : ObjectViewController<ListView, rb_Pilot>
    {
        public PilotViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
            this.Application.Model.Options.UseServerMode = true;

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
                    //gridView.Columns["Air Craft Count"].SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
                    //GridColumn AircraftCountColumn = gridView.Columns["AirCraftCount"];
                    //if (AircraftCountColumn !=null)
                    //{
                    //    //AircraftCountColumn.OptionsFilter.AllowFilter = true;
                    //    //AircraftCountColumn.OptionsFilter.AllowFilterModeChanging = DefaultBoolean.True;
                    //    ////AircraftCountColumn.OptionsColumn.allow
                    //    //AircraftCountColumn.OptionsColumn.AllowSort = DefaultBoolean.True;
                    //    //AircraftCountColumn.OptionsFilter.AllowFilter = true;
                    //}
                };
                gridView.CalcRowHeight += (s, e) =>
                {
                    e.RowHeight = 20;
                };
            }
            //XPCollection<rb_Aircraft> xpCollection1 = new XPCollection<rb_Aircraft>();
            //SortingCollection sorting = new SortingCollection();
            //sorting.Add(new SortProperty("AirCraftCount", DevExpress.Xpo.DB.SortingDirection.Ascending));
            //xpCollection1.Sorting = sorting;
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
