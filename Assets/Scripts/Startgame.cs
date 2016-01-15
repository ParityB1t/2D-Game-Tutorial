using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour {

    public void startGame()
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<CountPoint>().points = 0;
        SceneManager.LoadScene(2);
    }
}
