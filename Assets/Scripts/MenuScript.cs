using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    // two buttons: single player and multiplayer
    public void changeScene(int sceneIndex) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIndex);
    }
    public void QuitGame() {
        Application.Quit();
    }
}
