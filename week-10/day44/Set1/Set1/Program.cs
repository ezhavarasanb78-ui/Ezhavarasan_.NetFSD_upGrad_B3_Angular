using Set1.Models;
using Set1.Services;

namespace Set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new ContactService();

            while (true)
            {
                Console.WriteLine("\n Contact Management ");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Update Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. View All Contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");

                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            AddContact(service);
                            break;

                        case "2":
                            UpdateContact(service);
                            break;

                        case "3":
                            DeleteContact(service);
                            break;

                        case "4":
                            ViewContacts(service);
                            break;

                        case "5":
                            return;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            static void AddContact(ContactService service)
            {
                var contact = new Contact();

                Console.Write("Name: ");
                contact.Name = Console.ReadLine() ?? "";

                Console.Write("Email: ");
                contact.Email = Console.ReadLine() ?? "";

                Console.Write("Phone: ");
                contact.Phone = Console.ReadLine() ?? "";

                service.AddContact(contact);

                Console.WriteLine("Contact added successfully.");
            }

            static void UpdateContact(ContactService service)
            {
                Console.Write("Enter Id: ");
                int id = int.Parse(Console.ReadLine() ?? "0");

                var contact = new Contact();

                Console.Write("New Name: ");
                contact.Name = Console.ReadLine() ?? "";

                Console.Write("New Email: ");
                contact.Email = Console.ReadLine() ?? "";

                Console.Write("New Phone: ");
                contact.Phone = Console.ReadLine() ?? "";

                service.UpdateContact(id, contact);

                Console.WriteLine("Contact updated successfully.");
            }

            static void DeleteContact(ContactService service)
            {
                Console.Write("Enter Id: ");
                int id = int.Parse(Console.ReadLine() ?? "0");

                service.DeleteContact(id);

                Console.WriteLine("Contact deleted successfully.");
            }

            static void ViewContacts(ContactService service)
            {
                var contacts = service.GetAllContacts();

                Console.WriteLine("\n Contacts ");

                foreach (var c in contacts)
                {
                    Console.WriteLine($"Id: {c.Id}, Name: {c.Name}, Email: {c.Email}, Phone: {c.Phone}");
                }
            }
        }
    }
}
