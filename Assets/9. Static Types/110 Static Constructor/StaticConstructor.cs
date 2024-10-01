using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Employee
{
    public int employeeID;
    public string employeeName;
    public int salary;

    public static string companyName;

    public Employee()
    {
        Debug.Log("Instance Members Initialized");
    }

    static Employee()
    {
        // This static member is initialized first
        companyName = "Nilawarsa";
        Debug.Log("Static Members Initialized");
    }
}
public class StaticConstructor : MonoBehaviour
{
    private void Start() 
    {
        Employee e1 = new Employee();
        var e2 = new Employee();
        var e3 = new Employee();
        Employee e4 = new Employee();    
    }
}
