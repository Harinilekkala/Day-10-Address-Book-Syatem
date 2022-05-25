// See https://aka.ms/new-console-template for more information

using AddressBookSystem;

internal class program
{

    

    public static void Main(string[] args)
    {
        AddressBookSystem.person ab = new AddressBookSystem.person();
        ab.createcontacts();
        ab.displaycontacts();
        ab.editcontacts();

    }
}
