using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UrlTest
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RouteData.Values["id"] != null)
            {
                Response.Write("<h1>" + RouteData.Values["id"].ToString() + "</h1>");
            }
        }
    }
}