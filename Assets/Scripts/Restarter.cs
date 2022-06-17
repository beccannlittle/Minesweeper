using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restarter : MonoBehaviour
{
    public UIController uiController;
    public float waitBeforeRestart = 1f;

    void OnEnable()
    {
        StartCoroutine(WaitThenRestart());
    }

    private IEnumerator WaitThenRestart()
    {
        yield return new WaitForSeconds(waitBeforeRestart);
        uiController.Restart();
        gameObject.SetActive(false);
    }
}
