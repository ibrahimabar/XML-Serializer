using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["Galeries"] == null)
            {
                Response.Redirect("AddGalery.aspx");
            }
            else
            {
                Galeries galeries = (Galeries)Session["Galeries"];
                foreach (var item in galeries.ListGaleries)
                {
                    ddlGaleries.Items.Add(new ListItem(item.GaleryName, item.GaleryName));
                }
            }
        }
    }
    protected void btnSave_Click(object sender, EventArgs e)
    {
        Galeries galeries = (Galeries)Session["Galeries"];
        var carList = galeries.ListGaleries.Where(x => x.GaleryName == ddlGaleries.SelectedItem.Text).FirstOrDefault().CarList;

        Car newCar = new Car();
        
        newCar.CarBrand = txtCarBrand.Text;
        newCar.CarColor = txtCarColor.Text;
        newCar.CarModel = txtCarModel.Text;
        newCar.CarPrice = Decimal.Parse(txtCarPrice.Text);

        if (carList == null)
        {
            
            newCar.CarId = 1;
            galeries.ListGaleries.Where(x => x.GaleryName == ddlGaleries.SelectedItem.Text).FirstOrDefault().CarList = new List<Car>();
            galeries.ListGaleries.Where(x => x.GaleryName == ddlGaleries.SelectedItem.Text).FirstOrDefault().CarList.Add(newCar);
        }
        else
        {
            newCar.CarId = carList.Count+1;
            carList.Add(newCar);
            
           // galeries.ListGaleries.Where(x => x.GaleryName == ddlGaleries.SelectedItem.Text).FirstOrDefault().CarList.Add(newCar);
        }

        System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Galeries));

        System.IO.StreamWriter wr = new System.IO.StreamWriter(Server.MapPath("Galeries.xml"));
        writer.Serialize(wr, galeries);
        wr.Close();
    }
}