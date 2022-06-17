using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Cell : MonoBehaviour
{
    public GameObject flagIcon;
    public GameObject bombIcon;
    public TextMeshProUGUI countText;
    public Button button;

    [HideInInspector]
    public CellsController cellsController;
    [HideInInspector]
    public int mineCount = 0;

    public enum CellState { Unopened, Opened, Flagged };
    public CellState currentState = CellState.Unopened;

    public void HandleLeftClick()
    {
        if (currentState == CellState.Unopened)
        {
            if (mineCount < 0)
            {
                bombIcon.SetActive(true);
                cellsController.LoseGame();
            }
            else
            {
                currentState = CellState.Opened;
                button.interactable = false;
                countText.text = mineCount.ToString();
                countText.gameObject.SetActive(true);
                cellsController.CheckWin();
            }
        }
    }

    public void HandleRightClick()
    {
        Debug.Log(currentState);
        if (currentState == CellState.Unopened)
        {
            currentState = CellState.Flagged;
            flagIcon.SetActive(true);
            cellsController.UpdateFlagCount(-1);
        }
        else if (currentState == CellState.Flagged)
        {
            currentState = CellState.Unopened;
            flagIcon.SetActive(false);
            cellsController.UpdateFlagCount(1);
        }
    }
    public void HandleMiddleClick()
    {
        Debug.Log("Middle click ");
    }

}
