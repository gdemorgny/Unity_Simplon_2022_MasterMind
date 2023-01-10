using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Board : MonoBehaviour
{
    //Unity Event on d�clare l'�vent
    public UnityEvent OnWin;

    //Version C# on relie l'appel du delegate � l'event. 
    // La d�finition du delegate va d�terminer quelles informations seront disponibles. 
    // ATTENTION la signature du delegate doit �tre respect�e par les fonctions qui �coutent.
    public delegate void MessageEvent();
    public static event MessageEvent OnLoose;

    public void CheckActualRow()
    {
        Debug.Log("J'ai appuy� sur le bouton !");
        // Unity Event : invocation de l'�vent, le ? v�rifie si l'�vent n'est pas d�j� en cours.
        //OnWin?.Invoke();

        //C# : on invoke l'event. Cette synthaxe correspond � la synthaxe avec le ?. Cela revient au m�me, vous risquez de trouver les deux
        if(OnLoose != null)
        {
            OnLoose.Invoke();
        }
    }
}
