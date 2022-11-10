using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string Scene;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void CambiarAJuego(string juego)
    {
        SceneManager.LoadScene(juego);
    }
    
    public void Salir()
    {
        Application.Quit();
    }
}
