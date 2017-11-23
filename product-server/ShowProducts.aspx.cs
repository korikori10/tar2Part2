using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class ShowProducts : System.Web.UI.Page
{
    CheckBox cb;
    Product p = new Product();
    Category c = new Category();
    List<Product> newList = new List<Product>();

    
    protected void Page_Load(object sender, EventArgs e)
    {
        int i = 0;
        foreach (var item in p.getProducts())
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
            cb = new CheckBox();
            cb.ID= item.Id.ToString();
            cb.CheckedChanged += new EventHandler(this.cb_CheckedChanged); //cb_CheckedChanged;
            if (item.Inventory == 0)
            {
                cb.Enabled = false;
            }
 
            myDiv.Controls.Add(img);
            myDiv.Controls.Add(l1);
            myDiv.Controls.Add(cb);
            productsPH.Controls.Add(myDiv);
            i++;


        }


    }

    void cb_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox Cbox= ((CheckBox)sender);
        
        foreach (var item in p.getProducts())
        {
            
            int cbid =Convert.ToInt32(Cbox.ID);
            if ( cbid== item.Id)
            {
                newList.Add(item);
            }
        }
 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "</br>List: </br>";

        foreach (var item in newList)
        {
            Label1.Text += item.Title + "</br>";
        }
    }


}