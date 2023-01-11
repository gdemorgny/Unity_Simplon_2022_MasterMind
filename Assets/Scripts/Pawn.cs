using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    [SerializeField] private AppManager _appManager;
    private int _actualColorNumber = -1;
    private Collider _collider;

    private void Start()
    {
        _collider = GetComponent<Collider>();

    }

    public void ActivatePawn()
    {
        _collider.enabled = true;
    }
    public void DesactivatePawn()
    {
        _collider.enabled = false;
    }

    public int GetColorNumber()
    {
        return _actualColorNumber;
    }
    public void ChangeColor()
    {

        if (_actualColorNumber == -1 || _actualColorNumber >= _appManager._answerColors.Length - 1)
        {
            _actualColorNumber = 0;
        } else
        {
            _actualColorNumber++;
        }
        GetComponent<MeshRenderer>().material.SetColor("_Color", _appManager._answerColors[_actualColorNumber]);
    }
    public void ChangeColor(int resultColorNumber)
    {
        GetComponent<MeshRenderer>().material.SetColor("_Color", _appManager._resultColors[resultColorNumber]);
    }

}
