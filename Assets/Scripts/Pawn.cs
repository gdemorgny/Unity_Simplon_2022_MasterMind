using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    private void OnEnable()
    {
        AppManager.OnMouseClic += OnClic;
    }

    private void OnClic(Pawn pawn)
    {
        if(pawn == this)
        {
            Debug.Log("find this pawn : "+gameObject.name);
        }

    }
}
