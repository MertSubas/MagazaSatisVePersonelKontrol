using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinesLogicLayer;


namespace OOPstok
{
    public partial class Urunler : System.Web.UI.Page
    {
       
            protected void Page_Load(object sender, EventArgs e)
            {
                List<EntitUrun> UrLis = BLLUrun.BLLUrunListesi();
               Repeater1.DataSource=UrLis;
            Repeater1.DataBind();

            }
        
    }
}