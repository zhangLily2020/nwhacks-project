using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //    if (Input.GetKeyDown(KeyCode.Space))
    //     {
    //         startInterview();
    //     }
    // }

    public void startInterview()
    {
        // Debug.Log("Hi");
        SceneManager.LoadScene(1);

    }

    public void backToWaitingRoom()
    {
        SceneManager.LoadScene(0);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
