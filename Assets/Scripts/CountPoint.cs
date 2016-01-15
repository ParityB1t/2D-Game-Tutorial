using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountPoint : MonoBehaviour
{

    public int points;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        SceneManager.LoadScene(1);
    }
    
}
