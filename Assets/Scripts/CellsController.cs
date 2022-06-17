using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CellsController : MonoBehaviour
{
    public UIController uiController;
    public GameObject cellPrefab;

    private const int columns = 10;
    private const int rows = 8;
    private const int mineCount = 10;

    private int flagCount = mineCount;
    private Cell[] cells = new Cell[columns * rows];

    void Start()
    {
        SetUpBoard();
        uiController.SetFlagCount(flagCount);
    }

    public void SetUpBoard()
    {
        foreach (Transform child in gameObject.transform) 
        {
            GameObject.Destroy(child.gameObject);
        }

        for (int i = 0; i < columns * rows; i++)
        {
            Cell cell = Instantiate(cellPrefab, gameObject.transform).GetComponent<Cell>();
            cell.cellsController = this;
            cells[i] = cell;
        }
        int[] mineCoordinates = RandomList(0, columns * rows, mineCount);
        for (int i = 0; i < columns * rows; i++)
        {
            if (Array.IndexOf(mineCoordinates, i) > -1)
            {
                cells[i].mineCount = -1;
                int[] neighbors = new int[] {
                    i - 1, i - columns - 1, i - columns, i - columns + 1, i + 1, i + columns + 1, i + columns, i + columns - 1
                };
                foreach(int neighbor in neighbors)
                {
                    Debug.Log(neighbor);
                    if (neighbor >= 0 && neighbor < (columns * rows) && Array.IndexOf(mineCoordinates, neighbor) < 0)
                    {
                        cells[neighbor].mineCount += 1;
                    }
                }
            }
        }
    }

    public void UpdateFlagCount(int delta) {
        flagCount += delta;
        uiController.SetFlagCount(flagCount);
    }

    // Shamelessly stolen from https://forum.unity.com/threads/random-number-without-repeat.497923/
    public int[] RandomList(int fromInclusive, int toExclusive, int count)
    {
        List<int> available = new List<int>();
        List<int> result = new List<int>();
        for (int i = 0;i < count;i++)
        {
            if (available.Count == 0)
            {
                for (int index = fromInclusive;index < toExclusive;index++) available.Add(index);
            }
            int selected = available[UnityEngine.Random.Range(0, available.Count)];
            available.Remove(selected);
            result.Add(selected);
        }
        return result.ToArray();
    }
}
