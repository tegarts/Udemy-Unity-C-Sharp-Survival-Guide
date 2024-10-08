using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EmployeeAbstract : MonoBehaviour
{
    public string companyName;
    public string employeeName;

    public abstract void CalculateMonthlySalary();
}

public class FullTime : EmployeeAbstract
{
    public int salary;

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}

public class PartTime : EmployeeAbstract
{
    public int hoursWorked;
    public int hourlyRate;

    public override void CalculateMonthlySalary()
    {
        throw new System.NotImplementedException();
    }
}
