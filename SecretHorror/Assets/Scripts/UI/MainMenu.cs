using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{

    [SerializeField] GameObject optionsPanel;
    public void OnPlayButton (){
        SceneManager.LoadScene(1);
    }
    
    public void OnQuitButton (){
        Application.Quit();
    }
    public void ToggleOptions(){
        optionsPanel.SetActive(!optionsPanel.activeSelf);
    }
}
