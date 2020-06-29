using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInformer : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private TextMeshProUGUI healthUI;
    [SerializeField]
    private TextMeshProUGUI protectUI;
    private EnemyHealth enemyHealth;

    void Start()
    {
       canvas.worldCamera = Camera.main;
       enemyHealth = GetComponent<EnemyHealth>();
    }

    void Update()
    {
        healthUI.text = enemyHealth._Health.ToString();
        protectUI.text = enemyHealth.Protection.ToString();
        if(Camera.main.transform != null)
        canvas.transform.LookAt(Camera.main.transform);
    }
}
