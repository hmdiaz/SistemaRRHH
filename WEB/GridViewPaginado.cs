using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace SistemaRRHH
{
    public class GridViewPaginado : GridView
    {
        public GridViewPaginado()
            : base()
        {
        }

        private Nullable<int> totalRecords;
        /// <summary>
        /// Gets or Sets the Total Records for pagination, its important to set the value of Total 
        /// Records BEFORE binding the data to the grid. 
        /// </summary>
        public int TotalRecords
        {
            get
            {
                if (totalRecords == null)
                {
                    if (ViewState["TotalRecords"] == null)
                        TotalRecords = PageIndex;
                    else
                    {
                        TotalRecords = (int)ViewState["TotalRecords"];
                    }
                }
                return totalRecords.Value;
            }
            set
            {
                totalRecords = value;
                ViewState["TotalRecords"] = value;
            }
        }
        private Nullable<int> customPageIndex;
        /// <summary>
        /// Use CustomPageIndex instead of PageIndex for Pagination out of the grid
        /// </summary>
        public int CustomPageIndex
        {
            get
            {
                if (customPageIndex == null)
                {
                    if (ViewState["CustomPageIndex"] == null)
                        CustomPageIndex = PageIndex;
                    else
                    {
                        CustomPageIndex = (int)ViewState["CustomPageIndex"];
                    }
                }
                return customPageIndex.Value;
            }
            set
            {
                customPageIndex = value;
                ViewState["CustomPageIndex"] = value;
            }
        }
        /// <summary>
        /// Override it in order to set the value of VirtualCount and CurrentPageIndex
        /// </summary>
        /// <param name="row"></param>
        /// <param name="columnSpan"></param>
        /// <param name="pagedDataSource"></param>
        protected override void InitializePager(GridViewRow row, int columnSpan, PagedDataSource pagedDataSource)
        {
            if (pagedDataSource.IsPagingEnabled && (TotalRecords != pagedDataSource.VirtualCount))
            {
                pagedDataSource.AllowCustomPaging = true;

                pagedDataSource.VirtualCount = TotalRecords;
                pagedDataSource.CurrentPageIndex = CustomPageIndex;
            }

            base.InitializePager(row, columnSpan, pagedDataSource);
        }
        /// <summary>
        /// Override it to avoid the popup message of not handling this event and 
        /// to reset the selected index again.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPageIndexChanging(GridViewPageEventArgs e)
        {
            base.OnPageIndexChanging(e);
            this.CustomPageIndex = e.NewPageIndex;
            this.SelectedIndex = e.NewPageIndex;
        }
    }
}