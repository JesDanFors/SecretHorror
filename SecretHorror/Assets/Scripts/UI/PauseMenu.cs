using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour{
    [SerializeField] GameObject optionsPanel;
    public void OnResumeGameButton(){
        Time.timeScale = 1;
        FindObjectOfType<FirstPersonCamera>().PauseCamera(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        gameObject.SetActive(!gameObject.activeSelf);
    }
    public void ToggleOptions(){
        optionsPanel.SetActive(!optionsPanel.activeSelf);
    }
    public void OnMainMenuButton(){
        SceneManager.LoadScene(0);
    }
    public void OnQuitButton (){
        Application.Quit();
    }
}
