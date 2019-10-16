using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
            Main.life = 3;
            Score.score = 0;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Exit the game");
            Application.Quit();
        }

    }

    void Awake()
    {
        Screen.SetResolution(1080, 1920, false);
    }
}
