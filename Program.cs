using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Example
{
    class PetShop
    {
        private string strPetShopName;
        private string strAddress;
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
        public PetShop(string strPetShopName, string strAddress)
        {
            this.strPetShopName = strPetShopName;
            this.strAddress = strAddress;
        }
        public string PetShopInfo()
        {
            return ("Pet Shop Name: " +
                  strPetShopName + "Address: " + strAddress);
        }
        public virtual string Sound()
        {
            return ("The animal makes a sound");
        }
    }
    class Dog : PetShop
    {
        private string strName;
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }
        public Dog(string strPetShopName, string strAddress,
                string strName) : base(strPetShopName, strAddress)
        {
            this.strName = strName;
            //this.strPetShopName = strPetShopName; cannot do this
        }
        public override string Sound()
        {
            return ("My dog barks");
        }
    }
    class Cat : PetShop
    {
        private string strName;

        public Cat(string strPetShopName, string strAddress,
              string strName) : base(strPetShopName, strAddress)
        {
            this.strName = strName;
            //this.strPetShopName = strPetShopName; cannot do this
        }
        public override string Sound()
        {
            return ("My cat meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of the dog: ");
            string MyBestPet = Console.ReadLine();
            Console.Write("Enter the name of the pet shop: ");
            string ILovePet = Console.ReadLine();
            Console.Write("Enter the address: ");
            string PetShopAddres = Console.ReadLine();


            Dog objDog = new Dog(ILovePet, PetShopAddres, MyBestPet);
            Console.WriteLine("Pet Shope Name: {0}, Address: {1}", objDog.Name,
             objDog.Address);
            Console.WriteLine("The animal makes a sound {0}", objDog.Sound());
        }
    }
}