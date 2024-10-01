using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private UIManager _ui;
    private void OnEnable() {
        EnemySpawner.enemyCount++;
        _ui = GameObject.Find("UIManager").GetComponent<UIManager>();
        _ui.UpdateEnemyCount();
        Die();
    }

    private void OnDisable() {
        EnemySpawner.enemyCount--;
        _ui.UpdateEnemyCount();
    }

    private void Die()
    {
        Destroy(this.gameObject, Random.Range(2, 6));
    }
}
