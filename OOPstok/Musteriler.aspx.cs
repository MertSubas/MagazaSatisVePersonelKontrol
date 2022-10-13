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
    public partial class Musteriler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityMusteri> Muslis = BLLMusteri.BLLMusteriListesi();
            Repeater1.DataSource=Muslis;
            Repeater1.DataBind();

        }
    }
}