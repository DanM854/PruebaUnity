using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
   public void NewGame()
    {
        Debug.Log("Inicio el juego");
    }

    public void Continue()
    {
        Debug.Log("Continuar partida");
    }

    public void Options()
    {
        Debug.Log("Abrir ajustes");
    }

    public void ExitGame()
    {
        Debug.Log("Salir del juego");
    }

}
