using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace Testprojekt
{

    class StoreStructure
    {
        
      //  private List<StoreStructure> assortmentMaxi;

        //public StoreStructure(string[] storeAttributes)
        //{
        //    Category = storeAttributes[0];
        //    Item = storeAttributes[1];
        //}
        public string Category { get; set; }
        public string Item { get; set; }
        private List<StoreStructure> assortment;
        public  List<StoreStructure> ReadAssortment()
        {
           
             assortment = new List<StoreStructure>();
            string[] lines = File.ReadAllLines("Products.txt");

            foreach (string line in lines)
            {
                try
                {
                    string[] parts = line.Split(',');
                    string category = parts[0];
                    string item = parts[1];
                    StoreStructure product = new StoreStructure
                    {
                        Category = category,
                        Item = item
                    };
                    assortment.Add(product);
                }
                catch
                {
                    Console.WriteLine("Invalid line in product file");
                }
            }
            return assortment;
            //CreateMaxiSortimentOrder(assortment);
        }

        //public  List<StoreStructure> CreateAssortmentInStore()
        //{
        //  var assortment = new List<StoreStructure>();
        //    var lines = ReadAllItemsInSortiment();
        //    foreach (string l in lines)
        //    {
        //        string[] items = l.Split(',');
        //        assortment.Add(CreateProduct(items));
        //    }
        //    return assortment;
        //   // CreateMaxiSortimentOrder();
        //}

        //public static string[] ReadAllItemsInSortiment()
        //{
        //    try
        //    {
        //        string[] lines = File.ReadAllLines("Products.txt");
        //        return lines;
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Something went wrong, check textfile.");
        //        throw new ArgumentException();
        //    }
        //}

        //private static StoreStructure CreateProduct(string category)
        //{
        //    if (category == "Drycker" || category == "Bröd" || category == "Mejeri_Ägg_Ost" || category == "Kött_Chark" ||
        //        category == "Städ" || category == "Kryddor_Smaksättning" || category == "Hygien" || category == "Färdigmat" ||
        //       category == "Frukt_Grönt" || category == "Skafferi" || category == "Godis_Snacks")
        //    {
        //        return category;
        //    }
        //    else
        //    {
        //        throw new ArgumentException(storeAttributes[0] + " is not a category.");
        //    }
        //}

        //private static StoreStructure CreateProduct(string[] storeAttributes)
        //{
        //    if (storeAttributes[0] == "Drycker" || storeAttributes[0] == "Bröd" || storeAttributes[0] == "Mejeri_Ägg_Ost" || storeAttributes[0] == "Kött_Chark" ||
        //        storeAttributes[0] == "Städ" || storeAttributes[0] == "Kryddor_Smaksättning" || storeAttributes[0] == "Hygien" || storeAttributes[0] == "Färdigmat" ||
        //       storeAttributes[0] == "Frukt_Grönt" || storeAttributes[0] == "Skafferi" || storeAttributes[0] == "Godis_Snacks")
        //    {
        //        return new StoreStructure(storeAttributes);
        //    }
        //    else
        //    {
        //        throw new ArgumentException(storeAttributes[0] + " is not a category.");
        //    }
        //}
        public static List<string> CreateMaxiSortimentOrder(List<StoreStructure> assortment)
        {
            
            List<string> assortmentMaxi = new List<string>();
            string[] maxiOrder = new string[] {"Hygien", "Hem_Hushåll","Bröd", "Drycker","Frukt_Grönt", "Godis_Snacks", "Kryddor_Smaksättning","Kött_Chark"
            ,"Mejeri_Ägg_Ost","Skafferi","Färdigmat","Städ"};
            foreach (string m in maxiOrder)
            {
                foreach (StoreStructure l in assortment)  //objekts fel
                {
                    if (l.Category == m)
                    {
                        assortmentMaxi.Add(l.Item);
                    }
                }
            }
            return assortmentMaxi; 
        }
        public static List<string> CreateWillysSortimentOrder(List<StoreStructure> assortment)
        {

            List<string> assortmentWillys = new List<string>();
            string[] willysOrder = new string[] {"Frukt_Grönt","Bröd","Skafferi","Kryddor_Smaksättning","Kött_Chark","Mejeri_Ägg_Ost","Drycker","Godis_Snacks", "Hygien","Städ", "Hem_Hushåll",  
            "Färdigmat"};
            foreach (string m in willysOrder)
            {
                foreach (StoreStructure l in assortment)  
                {
                    if (l.Category == m)
                    {
                        assortmentWillys.Add(l.Item);
                    }
                }
            }
            return assortmentWillys;
        }
        public static List<string> CreateCityGrossSortimentOrder(List<StoreStructure> assortment)
        {

            List<string> assortmentCityGross = new List<string>();
            string[] cityOrder = new string[] {"Hygien","Kryddor_Smaksättning","Frukt_Grönt","Kött_Chark","Bröd","Skafferi","Mejeri_Ägg_Ost","Städ", "Drycker", "Godis_Snacks" 
            ,"Färdigmat", "Hem_Hushåll"};
            foreach (string m in cityOrder)
            {
                foreach (StoreStructure l in assortment)  
                {
                    if (l.Category == m)
                    {
                        assortmentCityGross.Add(l.Item);
                    }
                }
            }
            return assortmentCityGross;
        }
    }
}
