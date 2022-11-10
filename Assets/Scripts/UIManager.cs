using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject PausaPanel;
    public GameObject PanelScore;
    public GameObject PanelMessage;
    public Transform Player;
    private bool pause;

    void Awake()
    {
        PausaPanel.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PanelScore.SetActive(!PanelScore.activeSelf);
            PanelMessage.SetActive(!PanelMessage.activeSelf);
            PausaPanel.SetActive(!PausaPanel.activeSelf);
            pause = !pause;
        }

        if(pause)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
            GameObject.FindGameObjectWithTag("Player").GetComponent<StarterAssets.ThirdPersonController>().LockCameraPosition = true;
        } 
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            Time.timeScale = 1f;
            GameObject.FindGameObjectWithTag("Player").GetComponent<StarterAssets.ThirdPersonController>().LockCameraPosition = false;
        }
    }

    public void Back(string Scene)
    {
        SceneManager.LoadScene(Scene);
        pause = !pause;
    }

    public void Play()
    {
        pause = !pause;
        PanelScore.SetActive(!PanelScore.activeSelf);
        PanelMessage.SetActive(!PanelMessage.activeSelf);
        PausaPanel.SetActive(!PausaPanel.activeSelf);
    }
}
