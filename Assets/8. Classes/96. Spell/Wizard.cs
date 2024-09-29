using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public Spell[] spells;
    [Header("Wizard Info")]
    public int level;
    public int exp;

    private void Start() 
    {
       
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(var spell in spells)
            {
                if(spell.levelRequired == level)
                {
                    spell.Cast();
                    exp += spell.expGained;
                }
            }

        }
    }
}
