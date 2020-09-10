using System;
using System.Collections.Generic;
using System.Text;

namespace FastFood
{
    public class Request
    {
        public Request()
        {
            Products = new List<IProduct>();
        }
        public List<IProduct> Products { get; set; }
        public double TotalRequest()
        {
            double total = 0;
            Products.ForEach(prod =>
            {
                total += prod.Price();
            });
            return total;
        }
        public static Request TranslateRequest(string RequestString)
        {
            Request Request = new Request();
            // valid objects have in request
            bool hasMeat = RequestString.Contains("carne");
            bool hasChicken = RequestString.Contains("frango");
            bool hasSalad = RequestString.Contains("com salada");
            bool noHasSalad = RequestString.Contains("sem salada");
            bool hasFries = RequestString.Contains("batata");
            bool hasMayonnaise = RequestString.Contains("com maionese");
            bool noHasMayonnaise = RequestString.Contains("sem maionese");
            bool hasSoda = RequestString.Contains("refrigerante");

            // add products on request
            if (hasMeat || hasChicken)
            {
                int snackQtd = int.Parse(RequestString.Substring(0, 1));
                if (hasMeat) Request.Products.Add(new ProductMeat(snackQtd));
                if (hasChicken) Request.Products.Add(new ProductChicken(snackQtd));
                if (hasSalad) Request.Products.Add(new ProductSalad(snackQtd));
                if (noHasSalad) Request.Products.Remove(Request.Products.Find(p => p.Name == "Salada"));
            }

            if (hasFries)
            {
                int friesQtd = int.Parse(RequestString.Substring(RequestString.IndexOf(" batatas") - 1, 1));
                Request.Products.Add(new ProductFries(friesQtd));
                if (hasMayonnaise) Request.Products.Add(new ProductMayonnaise(friesQtd));
                if (noHasMayonnaise) Request.Products.Remove(Request.Products.Find(p => p.Name == "Maionese"));
            }
            if (hasSoda)
            {
                int sodaQtd = int.Parse(RequestString.Substring(RequestString.IndexOf(" refrigerante") - 1, 1));
                Request.Products.Add(new ProductSoda(sodaQtd));
            }
            return Request;
        }
    }
}
