using System;
using System.Text;
using System.Linq;
namespace ConsoleApp39
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConvertingNameToInitials converting = new ConvertingNameToInitials("Irada Feyzullayeva");

            converting.ConvertToTheInitials(converting.FullName.Split(' '));
        }
    }

    public class ConvertingNameToInitials
    {
        public string FullName { get; set; }
        public string[] SeperatedWords { get; set; }
        public ConvertingNameToInitials(string fullName)
        {
            this.FullName = fullName;
        }
        public void ConvertToTheInitials(string[] words)
        {
            string ijn= "";
            foreach (string names in words)
            {
                
               
                ijn += names[0]+ ".";
                Console.Write(ijn);
                ijn = "";
                
                }
            
           
        }

    }
}

