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
                Console.WriteLine("\nEnter Choice  \n1.AddContact \n2.EditContact \n3.DeleteContact \n4.RetriveStateorCity" +
                                  "\n5.SizeofBook\n6.SortPersonNameByCity\n7.identifyEachAddressbook\n8.CountByBookType\n9.Exit ");
                int choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            //AddressBookModel abmodel = new AddressBookModel();
                            abmodel.First_Name = "Pooja";
                            abmodel.Last_Name = "Reddy";
                            abmodel.Address = "Rag";
                            abmodel.City = "Shimoga";
                            abmodel.State = "Karnataka";
                            abmodel.Zip = "577201";
                            abmodel.Phone_Number = "9087654321";
                            abmodel.Email = "pooreddy@gmail.com";
                            abmodel.BookName = "Reddy";
                            abmodel.AddressbookType = "family";
                            bool result = abrepo.AddContact(abmodel);

                            if (result)
                                Console.WriteLine("Record added successfully...");
                            else
                                Console.WriteLine("Some problem is there...");
                            Console.ReadKey();
                            break;
                        case 2:
                            // Update recods
                            //AddressBookModel abmodel1 = new AddressBookModel();
                            abmodel1.First_Name = "Shobha";
                            abmodel1.Last_Name = "Reddy";
                            abmodel1.City = "shant";
                            abmodel1.State = "karnataka";
                            abmodel1.Email = "st@gmail.com";
                            abmodel1.BookName = "Reddy1";
                            abmodel1.AddressbookType = "Friends";
                            abrepo.EditContactUsingFirstName(abmodel1);
                            Console.ReadKey();
                            break;
                        case 3:
                            delmodel.First_Name = "Pooja";
                            abrepo.DeleteContactUsingName(delmodel);
                            Console.ReadKey();
                            break;
                        case 4:
                            abrepo.RetrieveContactFromPerticularCityOrState();
                            Console.ReadKey();
                            break;
                        case 5:
                            abrepo.AddressBookSizeByCityANDState();
                            Console.ReadKey();
                            break;
                        case 6:
                            abrepo.SortPersonNameByCity();
                            Console.ReadKey();
                            break;
                        case 7:
                            abrepo.identifyEachAddressbooktype();
                            Console.ReadKey();
                            break;
                        case 8:
                            abrepo.GetNumberOfContactsCountByBookType();
                            Console.ReadKey();
                            break;

                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
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
