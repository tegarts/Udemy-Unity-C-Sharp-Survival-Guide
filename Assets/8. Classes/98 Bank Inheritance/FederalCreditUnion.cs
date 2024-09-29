using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FederalCreditUnion : Bank
{
    public int moneyToLend;

    public void LendingMoney(int amount)
    {
        moneyToLend -= amount;
        Debug.Log("Lending Money: " + amount);
    }
}
