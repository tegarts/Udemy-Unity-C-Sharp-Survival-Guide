using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum LevelSelector
    {
        Easy, // 0
        Medium, // 1
        Hard, // 2
        Expert // 3
    }

    public LevelSelector currentLevel;

    private void Start() 
    {
        switch(currentLevel)
        {
            case LevelSelector.Easy:
                Debug.Log("Easy");
                break;
            case LevelSelector.Medium:
                Debug.Log("Medium");
                break;
            case LevelSelector.Hard:
                Debug.Log("Hard");
                break;
            case LevelSelector.Expert:
                Debug.Log("Expert");
                break;
        }    
    }
}
