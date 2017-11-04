using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AddGalery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Check if xml file exits
        if (System.IO.File.Exists(Server.MapPath("Galeries.xml")))
        {
            //Open xml file
            System.IO.FileStream fs = new System.IO.FileStream(Server.MapPath("Galeries.xml"),System.IO.FileMode.Open);
            
            //Read File by XML Reader
            System.Xml.XmlReader xrd = System.Xml.XmlReader.Create(fs);

            //Create a serializer of type Galeries
            System.Xml.Serialization.XmlSerializer serial = new System.Xml.Serialization.XmlSerializer(typeof(Galeries));
            
            //Create an instance
            Galeries gal = (Galeries)serial.Deserialize(xrd);

            //Close xml file
            fs.Close();

            //Add to Session Galeries or create a new one
            if (Session["Galeries"] == null)
            {
                Session.Add("Galeries",gal);
            }
            else
            {
                Session["Galeries"] = gal;
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        //Create new instance of Galery
        Galery newGalery = new Galery();
        newGalery.GaleryCity = txtCity.Text;
        newGalery.GaleryDistrict = txtDistrict.Text;
        newGalery.GaleryName= txtName.Text;

        if (Session["Galeries"] == null)
        {
            //When session is not exist
            //Create new instance of Galeries and new list
            Galeries galeries = new Galeries();
            galeries.ListGaleries = new List<Galery>();
            galeries.ListGaleries.Add(newGalery);
            Session.Add("Galeries", galeries);
            Response.Write(galeries.ListGaleries.Count);
        }
        else
        {
            //When session exists
            //Add to current to session
            Galeries galeries = (Galeries)Session["Galeries"];
            galeries.ListGaleries.Add(newGalery);
            //Session["Galeries"] = galeries;
            Response.Write("else" + galeries.ListGaleries.Count);
        }
    }
    protected void btnGotoCar_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddCar.aspx");
    }
}