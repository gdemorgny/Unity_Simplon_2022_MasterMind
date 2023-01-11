using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Row : MonoBehaviour
{
    [SerializeField] private Pawn[] _answerPawns;
    [SerializeField] private Pawn[] _resultPawns;

    public void ActivateLine()
    {
        for (int i = 0; i < _answerPawns.Length; i++)
        {
            _answerPawns[i].ActivatePawn();
        } 
    }

    public void DesactivateLine()
    {
        for(int i = 0; i < _answerPawns.Length; i++)
        {
            _answerPawns[i].DesactivatePawn();
        }
    }

    public int[] GetRowColors()
    {
        int[] rowColors = new int[_answerPawns.Length];
        for (int i = 0; i < _answerPawns.Length; i++)
        {
            rowColors[i] = _answerPawns[i].GetColorNumber();
        }
        return rowColors;
    }

    public void ApplyResult(int[] results)
    {
        for (int i = 0; i < _resultPawns.Length; i++)
        {
            _resultPawns[i].ChangeColor(results[i]);
        }
    }
}
