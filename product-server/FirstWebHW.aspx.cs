using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FirstWebHW : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
       
        Product1 p = new Product1(name1.Text, price1.Text, Categor1.Text, Description1.Text);
        string ans = p.GetInfo(); 
        Response.Write(ans);
    }

   
}