using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Payment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (Calendar1.SelectedDate == null || Calendar1.SelectedDate == new DateTime(0001, 1, 1, 0, 0, 0))// not click any date
            args.IsValid = false;
        else
            args.IsValid = true;
    }
    protected void ChBCredit_CheckedChanged(object sender, EventArgs e)
    {
        CHbPhone.Checked = false;//only one can be checked

        if (ChBCredit.Checked == true)
        {


            Label LBL1 = new Label();
            LBL1.Text = "Number Of Payments:";
            PH.Controls.Add(LBL1);
            DropDownList DDL = new DropDownList();
            DDL.EnableViewState = false;
            DDL.ID = "DDL";
            for (int i = 1; i <= 12; i++)
            {
                ListItem li = new ListItem();
                li.Value = i.ToString();

                DDL.Items.Add(li);
            }

            PH.Controls.Add(DDL);
            var validator = new RequiredFieldValidator();
            validator.ControlToValidate = "DDL";
            validator.Text = "Must Choose Number Of Payments";
            PH.Controls.Add(validator);

            Label LBL = new Label();
            LBL.Text = "Credit Card Number:";
            PH.Controls.Add(LBL);
            TextBox TB = new TextBox();
            TB.ID = "CCTb";
            TB.EnableViewState = false;
            PH.Controls.Add(TB);
            validator.ControlToValidate = "CCTb";
            validator.Text = "Must Enter Credit Card Number";
            PH.Controls.Add(validator);

            Label LBL2 = new Label();
            LBL2.Text = "T.Z";
            PH.Controls.Add(LBL2);
            TextBox TB2 = new TextBox();
            TB2.ID = "TZTB2";
            TB2.EnableViewState = false;
            PH.Controls.Add(TB2);
            var Cvalidator = new CustomValidator();
            Cvalidator.ClientValidationFunction = "TZvalidation";
            validator.ControlToValidate = "TZTB2";
            validator.ErrorMessage = "";

            PH.Controls.Add(validator);

            Label LBL3 = new Label();
            LBL3.Text = "Credit Type";
            PH.Controls.Add(LBL3);
            TextBox TB3 = new TextBox();
            TB3.ID = "CtTB3";
           TB3.EnableViewState = false;
            PH.Controls.Add(TB3);
            validator.ControlToValidate = "CtTB3";
            validator.Text = "Must Enter Credit Type";
            PH.Controls.Add(validator);




        }
        else
        {
            PH.Controls.Clear();
        }
    }

    protected void TZvalidation(object sender, ServerValidateEventArgs args) {
     
        int[] tznum = new int[9];
        int sum = 0;
        int tz = Convert.ToInt32(args.Value);
        if ((tz <= 999999999)||  (tz >= 100000000))
        {
            
            while (tz>1)
            {
                int i = 0;
                tznum[i] = (tz % 10);
                tz = tz / 10;
                i++;
            }
            for (int i = 0; i < tznum.Length ; i++)
            {
                sum += tznum[i];    
            }
            if (sum % 7 == tznum[0])
            {
                args.IsValid = true;
                
            }
            else
            {
                args.IsValid = false;
                
            }
        }

    }
    protected void CHbPhone_CheckedChanged(object sender, EventArgs e)
    {
        ChBCredit.Checked = false;//only one can be checked

        if (CHbPhone.Checked == true)
        {

        
        Label LBL1 = new Label();
        LBL1.Text = "Phone Number:";
        PH.Controls.Add(LBL1);
        TextBox TXB = new TextBox();
           TXB.EnableViewState = false;

            PH.Controls.Add(TXB);
        }
        else
        {
            PH.Controls.Clear();
        }
    }


}