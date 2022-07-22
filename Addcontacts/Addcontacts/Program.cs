Console.WriteLine("Welcome to Address Book Program in Address Book Main class on Master Branch");
Console.WriteLine("Enter the number of contacts needed to add");
int n = Convert.ToInt32(Console.ReadLine());
Address obj = new Address();
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Enter the details to create a contact");
    obj.create();
}
Console.WriteLine("These are the contacts stored");
obj.display();