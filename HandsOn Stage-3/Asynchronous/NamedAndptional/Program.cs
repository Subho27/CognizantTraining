using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedAndptional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COHORT DETAILS");
            
            GetCohortDetails("DF002", "22", "OBL", "DOTNET","Advanced Learnig");
            GetCohortDetails("DF002", "OBL", "22" ,"DOTNET", "Advanced Learnig");
            GetCohortDetails(CohortName:"DF002", mode:"OBL",currentModule: "Advanced Learnig", GencCount: "22", track:"DOTNET");

            Console.WriteLine("ORDER DETAILS");
            OrderDetails(seller:"SOME SELLER",product:"SOME PRODUCT");

            Console.ReadKey();
        }

        public static void GetCohortDetails(string CohortName,string GencCount,string mode,string track,string currentModule)
        {
            Console.WriteLine($"It is {CohortName} with {GencCount} GenCs undergoing training for {track} thru {mode}. The current module of training is {currentModule}");
        }
        public static void OrderDetails(string seller,string product,int quantity=10,bool isReturnable=true)
        {
            Console.WriteLine($"Here is the order detail – {quantity} number of {product} by {seller} is ordered. It’s returnable status is {isReturnable}");
        }
    }
}
