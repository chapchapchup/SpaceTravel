using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public float speed;
    public static int life = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }


        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0f) pos.x = 0f;
        if (pos.x > 1f) pos.x = 1f;
        if (pos.y < 0f) pos.y = 0f;
        if (pos.y > 1f) pos.y = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);


        if(life <= 0)
        {
            GameOver();
        }

    }

    void Awake()
    {
        Screen.SetResolution(1080, 1920, false);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "planet")
        {
            AudioSource hit = GetComponent<AudioSource>();
            hit.Play();
            life--;
            Debug.Log(life);
        }
    }


    void GameOver()
    {
        Debug.Log("you died");
        SceneManager.LoadScene("GameOver");
    }

}

