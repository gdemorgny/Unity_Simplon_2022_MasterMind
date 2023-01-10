using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _winMessage;
    [SerializeField] private GameObject _looseMessage;
    //Variable qui permettra d'acceder à l'event version Unity
    [SerializeField] private Board _board;

    private void OnEnable()
    {
        //UnityEvent : On inscrit la fonction WinMessage à l'event OnWin.
        //On a absolument besoin de l'acces à l'objet _board instancié à partir de la classe Board
        _board.OnWin.AddListener(WinMessage);

        //C# : on inscrit la fonction LooseMessage à l'event OnLoose.
        //grace à la propriété static nous devons juste trouver la classe Board
        Board.OnLoose += LooseMessage;
    }
    private void OnDisable()
    {
        // dans les deux cas on se déinscrit de l'event
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
