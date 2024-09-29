using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Bank
{
    // Protected dipakai supaya class turunan bisa mengakses variabel ini, tetapi tidak untuk class lain
    protected string branchName;
    protected string location;
    protected int moneyInVault;

    protected void CheckBalance()
    {
        Debug.Log("Checking Balance: " + branchName);
    }

    protected void Withdraw(int amount)
    {
        moneyInVault -= amount;
        Debug.Log("Withdrawing: " + amount);
    }

    protected void Deposit(int amount)
    {
        moneyInVault += amount;
        Debug.Log("Depositing: " + amount);
    }
}
