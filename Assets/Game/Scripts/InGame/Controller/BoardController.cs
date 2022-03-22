using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    [SerializeField] GameObject[] cells;
    [SerializeField] int x = 8;

    [ContextMenu("Convert")]
    private void Convert()
    {
        for (int i = 0; i < cells.Length; i++)
        {
            cells[i].name = $"B_{i/x}{i%x}";
        }
    }
}
