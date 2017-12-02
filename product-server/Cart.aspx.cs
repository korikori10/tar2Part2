using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Cart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MyCart"] != null)
        {
            List<Product> newList =  (List<Product>)(Session["MyCart"]);
            foreach (var item in newList)
            {
             
                    HtmlGenericControl myDiv2 = new HtmlGenericControl("div");

                    myDiv2.Attributes["class"] = "myClass";
                    item.Price = item.Price * 0.5;
                    Image img = new Image();
                    img.ImageUrl = item.ImagePath;
                    Label l1 = new Label();
                    l1.Text = "</br> Product Number: " + item.Id.ToString() +
                    "</br> Product Name: " + item.Title.ToString() +
                    "</br> Product Category: " + item.category.Name +
                    "</br> Product Price: " + item.Price.ToString();
                    myDiv2.Controls.Add(img);
                    myDiv2.Controls.Add(l1);
                    cartPH.Controls.Add(myDiv2);
                }

            

            
        }
    }
}