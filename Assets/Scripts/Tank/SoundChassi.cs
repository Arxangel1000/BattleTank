using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundChassi : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioChassi;

    private void Update()
    {
        SoundChassis();
    }

    private void SoundChassis()
    {
        if (Input.GetAxis("Vertical") != 0)
            _audioChassi.enabled = true;
        else { _audioChassi.enabled = false; }
    }
}
