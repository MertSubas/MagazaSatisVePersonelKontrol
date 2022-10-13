using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BusinesLogicLayer;
using DataAccessLayer;
using EntityLayer;

namespace OOPstok
{
    public partial class SatısEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select *from TBLURUN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownUrun.DataValueField = "URUNID";
                DropDownUrun.DataTextField = "URUNAD";
                
                DropDownUrun.DataSource = dt;
                DropDownUrun.DataBind();

                SqlCommand komut2 = new SqlCommand("Select PERSONELID,(PERSONELAD+' '+ PERSONELSOYAD) AS 'PERSONELADSOYAD' FROM TBLPERSONEL", Baglanti.bgl);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DropDownPerso.DataValueField = "PERSONELID";
                DropDownPerso.DataTextField = "PERSONELADSOYAD";

                DropDownPerso.DataSource = dt2;
                DropDownPerso.DataBind();

                SqlCommand komut3 = new SqlCommand("Select MUSTERIID,(MUSTERIAD+ ' '+ MUSTERISOYAD) AS 'MUSTERIADSOYAD' FROM TBLMUSTERI", Baglanti.bgl);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                DropDownMusterı.DataValueField = "MUSTERIID";
                DropDownMusterı.DataTextField = "MUSTERIADSOYAD";

                DropDownMusterı.DataSource = dt3;
                DropDownMusterı.DataBind();
                


            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
                EntitySatis ent2 = new EntitySatis();
                
                ent2.Fiyat = decimal.Parse(TextBox1.Text);

            ent2.Personel = int.Parse(DropDownPerso.SelectedValue);
            ent2.Musteri =  int.Parse(DropDownMusterı.SelectedValue);
            ent2.Urun = int.Parse(DropDownUrun.SelectedValue);
               
                


            BLLSatıs.BLLSatıslEkle(ent2);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Satış İşlemi Başarılı')", true);
                Response.Redirect("Satıs.Aspx");
            
        }
    }
}