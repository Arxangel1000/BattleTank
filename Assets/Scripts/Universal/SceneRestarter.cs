using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestarter : MonoBehaviour
{
    [SerializeField]
    private float _time;

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(_time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
