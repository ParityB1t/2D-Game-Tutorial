using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour {

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
}
