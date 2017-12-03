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
    string name;
    string description;
    string price;
    string category;
<<<<<<< HEAD
    List<Product> newList = new List<Product>();
    Product p = new Product();
    public Product1(string name, string price, string category, string description)
    {
        this.name = name;
        double P1 = (Convert.ToDouble(price)) * 1.17;
        this.price = P1.ToString();
        this.category = category;
        this.description = description;

    }

    public void listProducts(List<Product> pl, PlaceHolder ph, bool cbst)
=======
    
    public Product1(string name, string price, string category, string description)
>>>>>>> 2780d9261174085923ed67cbf84294ed12d24728
    {
        this.name = name;
        double P1 = (Convert.ToDouble(price)) * 1.17;
        this.price = P1.ToString();
        this.category = category;
        this.description = description;

    }

    
    public string GetInfo()
    {

        return "A new product got in! " + "<br />" + " Name: " + name + "<br />" + "Cost:" + price + " shekels" + "<br />" + "Under the category of:" + category + "<br />" + "Description: " + description + ".";
    }
<<<<<<< HEAD
    public string GetInfo()
    {

        return "A new product got in! " + "<br />" + " Name: " + name + "<br />" + "Cost:" + price + " shekels" + "<br />" + "Under the category of:" + category + "<br />" + "Description: " + description + ".";
    }
=======
>>>>>>> 2780d9261174085923ed67cbf84294ed12d24728
}