using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public enum Diffuculty
    {
        Easy,
        Normal,
        Hard
    }

    public Diffuculty currentDiffuculty;

    private void Start() {
        SceneManager.LoadScene((int)currentDiffuculty);
    }
}
