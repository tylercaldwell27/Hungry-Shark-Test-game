using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public Button play;
    bool start = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            play.onClick.AddListener(StartGame);
            if (start == true)
            {
               
                SceneManager.LoadScene(0);
            }
        }
    }
    void StartGame()
    {
        start = true;
    }
}
