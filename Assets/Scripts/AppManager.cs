using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    public delegate void CustomPawnClic(Pawn pawn);
    public static event CustomPawnClic OnMouseClic;

    private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.GetComponent<Pawn>() != null && Input.GetMouseButtonDown(0))
            {
                if (OnMouseClic != null)
                {
                    OnMouseClic.Invoke(hit.collider.GetComponent<Pawn>());
                }

            }
        }
    }

}
