using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

// AUTHOR : MR. NABARUN SAMADDAR

/// <summary>
/// Summary description for CurrencyConverter
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class CurrencyConverter : System.Web.Services.WebService
{

    public CurrencyConverter()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string NabarunSamaddar()
    {
        return "Author : Mr. Nabarun Samaddar";
    }

    [WebMethod]
    public double AussieToRupees(double Aussie)
    {
        return (Aussie * 55);
    }

    [WebMethod]
    public double RupeesToAussie(double Rupees)
    {
        return (Rupees / 55);
    }

}
