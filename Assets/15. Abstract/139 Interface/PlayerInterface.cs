using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInterface : MonoBehaviour, IDamageable<int>, IShootable
{
    public int Health { get; set; }

    public void TakeDamage(int damage)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Shoot()
    {

    }
}
