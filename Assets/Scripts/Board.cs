using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Board : MonoBehaviour
{
    //Unity Event on déclare l'évent
    public UnityEvent OnWin;

    //Version C# on relie l'appel du delegate à l'event. 
    // La définition du delegate va déterminer quelles informations seront disponibles. 
    // ATTENTION la signature du delegate doit être respectée par les fonctions qui écoutent.
    public delegate void MessageEvent();
    public static event MessageEvent OnLoose;

    public void CheckActualRow()
    {
        Debug.Log("J'ai appuyé sur le bouton !");
        // Unity Event : invocation de l'évent, le ? vérifie si l'évent n'est pas déjà en cours.
        //OnWin?.Invoke();

        //C# : on invoke l'event. Cette synthaxe correspond à la synthaxe avec le ?. Cela revient au même, vous risquez de trouver les deux
        if(OnLoose != null)
        {
            OnLoose.Invoke();
        }
    }
}
