using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinesLogicLayer;
using DataAccessLayer;

namespace OOPstok
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDepartman> Deplist = BLLDepartman.BLLDepartmanListele();
            Repeater1.DataSource = Deplist;
            Repeater1.DataBind();

        }
    }
}