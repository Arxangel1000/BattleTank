using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private Image lineBar;
    [SerializeField]
    private HealthPlayer healthPlayer;

    public void ChangeLine(float damage)
    {
        if (healthPlayer._Health > 0)
        {
            var _XChange = (float)healthPlayer._Health / TankData.instance.tankParameters.Health;
            lineBar.transform.localScale = new Vector3(_XChange, 1, 1);
        }
    }
}
