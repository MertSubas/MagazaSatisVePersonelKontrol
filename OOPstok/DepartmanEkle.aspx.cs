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
    public partial class DepartmanEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           EntityDepartman ent=new EntityDepartman();
            ent.Departmanad = TextBox1.Text;
            BLLDepartman.BLLDepartmanEkle(ent);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Departman Ekleme İşlemi Başarılı')", true);
            Response.Redirect("WebForm1.Aspx");

        }
    }
}