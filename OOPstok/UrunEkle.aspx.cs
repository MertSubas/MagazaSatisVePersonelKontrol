using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinesLogicLayer;
using EntityLayer;

namespace OOPstok
{
    public partial class UrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntitUrun ent = new EntitUrun();
            ent.Urunad = TextBox1.Text;
            ent.Urunfiyat = decimal.Parse(TextBox2.Text);
            ent.Urunadet = int.Parse(TextBox3.Text);
            BLLUrun.BLLUrunEkle(ent);

            ScriptManager.RegisterClientScriptBlock(this,this.GetType(),"alertMessage","alert('Ürün Ekleme İşlemi Başarılı')",true);
            Response.Redirect("Urunler.Aspx");
        }
    }

}