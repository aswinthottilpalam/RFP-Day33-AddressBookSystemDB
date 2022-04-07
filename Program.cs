using System;

namespace ADO.NetAddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book System (ADO.Net)!");
            Console.WriteLine("AddressBook_Using_Ado.Net ");
            AddressBookRepo abrepo = new AddressBookRepo();
            AddressBookModel abmodel = new AddressBookModel();

            while (true)
            {
                Console.WriteLine("\nEnter Choice \n1.AddContact");
                int choice = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            abmodel.First_Name = "Aswin";
                            abmodel.Last_Name = "Thottilpalam";
                            abmodel.Address = "Kozhikode";
                            abmodel.City = "Calicut";
                            abmodel.State = "Kerala";
                            abmodel.Zip = "665544";
                            abmodel.Phone_Number = "9988774455";
                            abmodel.Email = "abc@gmail.com";
                            bool result = abrepo.AddContact(abmodel);
                            if (result)
                                Console.WriteLine("Record added successfully...");
                            else
                                Console.WriteLine("Some problem is there...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }

        }
    }
}
