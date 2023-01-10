using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _winMessage;
    [SerializeField] private GameObject _looseMessage;
    //Variable qui permettra d'acceder � l'event version Unity
    [SerializeField] private Board _board;

    private void OnEnable()
    {
        //UnityEvent : On inscrit la fonction WinMessage � l'event OnWin.
        //On a absolument besoin de l'acces � l'objet _board instanci� � partir de la classe Board
        _board.OnWin.AddListener(WinMessage);

        //C# : on inscrit la fonction LooseMessage � l'event OnLoose.
        //grace � la propri�t� static nous devons juste trouver la classe Board
        Board.OnLoose += LooseMessage;
    }
    private void OnDisable()
    {
        // dans les deux cas on se d�inscrit de l'event
        _board.OnWin.RemoveListener(WinMessage);
        Board.OnLoose -= LooseMessage;

    }
    private void WinMessage()
    {
        _winMessage.SetActive(true);
    }
    private void LooseMessage()
    {
        _looseMessage.SetActive(true);

    }
}
