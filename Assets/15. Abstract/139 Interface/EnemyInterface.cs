using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInterface : MonoBehaviour, IDamageable<float>, IShootable
{
    public int Health { get; set; }

    public void TakeDamage(float damage)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Shoot()
    {
        
    }
}
