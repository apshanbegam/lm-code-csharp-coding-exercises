using System;
namespace Exercises
{
    public class Exercise003
    {
        
        public string[] IceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };
       
        public int IceCreamCode(string iceCreamFlavour) => Array.FindIndex(IceCreamFlavours, flavour => flavour == iceCreamFlavour); 
    }
}
