using System;
namespace CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dal d = new Dal();
            Console.WriteLine("\n1. Insert\n2. View\n3. Update\n4. Delete\n5. Exit");
            Console.WriteLine("enter your choice :");
            int choice = int.Parse(Console.ReadLine());
            while(true)
            {
                switch(choice)
                {
                    case 1:
                        Model m = new Model();
                        Console.WriteLine("enter name");
                        m.Productname = Console.ReadLine();
                        Console.WriteLine("enter Catergory");
                        m.Category = Console.ReadLine();
                        Console.WriteLine("enter price");
                        m.Price = int.Parse(Console.ReadLine());
                        d.inspro(m);
                        Console.WriteLine("Inserted suceesfully");
                       break;
                    case 3:
                        Model up = new Model();
                        Console.WriteLine("Enter id");
                        up.Productid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter new name");
                        up.Productname = Console.ReadLine();
                        Console.WriteLine("Enter new Category");
                        up.Category = Console.ReadLine();
                        Console.WriteLine("Enter new price");
                        up.Price = decimal.Parse(Console.ReadLine());
                        d.uppro(up);
                        Console.WriteLine("Updated successfully");
                        break;
                    case 2:
                        var Model = d.getAll();
                        foreach(var i in Model)
                        {
                            Console.WriteLine($"{i.Productid} | {i.Productname} | {i.Category} | {i.Price}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("enter id to delete");
                        int id = int.Parse(Console.ReadLine());
                        d.del(id);
                        Console.WriteLine("Deleted sucessfully");
                        break;
                }
            }
        }
    }
}
