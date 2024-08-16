using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeScene("Game");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            ChangeScene("Menu");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            ChangeScene("Credits");
        }

    }

    public void ChangeScene(string escene)
    {
        SceneManager.LoadScene(escene);
    }
}
