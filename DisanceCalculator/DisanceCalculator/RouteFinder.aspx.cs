using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisanceCalculator
{
    public partial class RouteFinder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Routes_Click(object sender, EventArgs e)
        {
            Navigator _navigator = new Navigator();
            _navigator.CurrentLocation("chennai");
            _navigator.SetDestination("vellore");
            RouteDetails.DataSource = _navigator.GetRoute();
            RouteDetails.DataBind();

        }
    }
}