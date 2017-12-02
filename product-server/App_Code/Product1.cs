using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for Poduct
/// </summary>
public class Product1
{
    //string name;
    //string description;
    //string price;
    //string category;
    List<Product> newList = new List<Product>();
    Product p = new Product();
    //public Product1(string name, string price, string category, string description)
    //{
    //    this.name = name;
    //    double P1 = (Convert.ToDouble(price)) * 1.17;
    //    this.price = P1.ToString();
    //    this.category = category;
    //    this.description = description;

    //}

    public void listProducts(List<Product> pl, PlaceHolder ph, bool cbst)
    {
        int i = 0;
        foreach (var item in pl)
        {


            HtmlGenericControl myDiv = new HtmlGenericControl("div");
            myDiv.ID = "myDiv" + i;
            myDiv.Attributes["class"] = "myClass";

            Image img = new Image();
            img.ImageUrl = item.ImagePath;
            Label l1 = new Label();
            l1.Text = "</br> Product Number: " + item.Id.ToString() +
            "</br> Product Name: " + item.Title.ToString() +
            "</br> Product Category: " + item.category.Name +
            "</br> Product Price: " + item.Price.ToString() +
            "</br> Product Invetory: " + item.Inventory.ToString();
            CheckBox cb = new CheckBox();
            cb.ID = item.Id.ToString();
            cb.CheckedChanged += new EventHandler(this.cb_CheckedChanged); //cb_CheckedChanged;
            if (item.Inventory == 0)
            {
                cb.Enabled = cbst;
            }

            myDiv.Controls.Add(img);
            myDiv.Controls.Add(l1);
            myDiv.Controls.Add(cb);
            ph.Controls.Add(myDiv);
            i++;


        }

    }

    private void cb_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox Cbox = ((CheckBox)sender);
        int cbid = Convert.ToInt32(Cbox.ID);
        if (Cbox.Checked)
        {
            foreach (var item in p.getProducts())
            {


                if (cbid == item.Id)
                {
                    newList.Add(item);
                }
            }
        }
        else
        {
            foreach (var item in newList)
            {
                if (cbid == item.Id)
                {
                    newList.Remove(item);
                }
            }
        }
    }
    //public string GetInfo()
    //{
        
    //    return "A new product got in! "+ "<br />"+" Name: " + name +"<br />" + "Cost:" + price + " shekels" + "<br />" + "Under the category of:" + category + "<br />"+"Description: " +description+ ".";
    //}
}