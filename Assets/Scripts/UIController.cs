using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private CellsController cellsController;
    [SerializeField]
    private TextMeshProUGUI flagField;
    [SerializeField]
    private TextMeshProUGUI timeField;

    private float currentTime = 0f;

    void Update()
    {
        UpdateTime(currentTime + Time.deltaTime);
    }

    public void Restart()
    {
        cellsController.SetUpBoard();
        UpdateTime(0f);
    }

    public void SetFlagCount(int newCount)
    {
        flagField.text = newCount.ToString();
    }

    private void UpdateTime(float newTime)
    {
        currentTime = newTime;
        timeField.text = Mathf.Round(currentTime).ToString();
    }
}
