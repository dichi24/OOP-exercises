class CustomerDatabase
{
    public Customer[] customers;

    public CustomerDatabase()
    {
        customers = new Customer[10];
    }

    public void AddCustomer(Customer customer)
    {
      for (int i = 0; i < customers.Length; i++)
      {
    
        if (customers[i] == null)
        {
            customers[i] = customer;
            return;
        }

       else 
       {
        Console.WriteLine("Arrayet er fuldt. Kan ikke tilføje flere kunder.");
       }

      }
    }
public void RemoveCustomerById(int id)
{
    for (int i = 0; i < customers.Length; i++)
    {
    if (customers[i] != null && customers[i].id == id)
    {
        customers[i]= null;
        Console.WriteLine($"Customer with Id {id} has been removed.");
        return;
    }
    
    else 
    {
        Console.WriteLine($"No customer with ID {id} was found");
    }
    }
}

}


