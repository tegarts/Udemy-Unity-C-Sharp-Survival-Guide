using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainInterface : MonoBehaviour
{
    private void Update() 
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            // if(Physics.Raycast(rayOrigin, out hitInfo))
            // {
            //     if(hitInfo.collider.name == "Player Interface")
            //     {
            //         hitInfo.collider.GetComponent<PlayerInterface>().TakeDamage(100);
            //     }
            //     else if(hitInfo.collider.name == "Enemy Interface")
            //     {
            //         hitInfo.collider.GetComponent<EnemyInterface>().TakeDamage(100);
            //     }
            // }

            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                IDamageable<int> damageableObject = hitInfo.collider.GetComponent<IDamageable<int>>();

                if(damageableObject != null)
                {
                    damageableObject.TakeDamage(100);
                }
            }
        }    
    }
}
