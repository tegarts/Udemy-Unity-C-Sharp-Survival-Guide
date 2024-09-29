using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour
{
    Customer customer1;
    Customer customer2;
    public Customer[] customers;

    private void Start() 
    {
        customer1 =  new Customer("John", "Marston", 38, "Male", "Lumberjack");
        
        customer2 = CreateCustomer("Arthur", "Morgan", 40, "Male", "Farmer");
    }

    public Customer CreateCustomer(string firstName, string lastName, int age, string gender, string occupation)
    {
        var customer = new Customer(firstName, lastName, age, gender, occupation);

        return customer;
    }

}
