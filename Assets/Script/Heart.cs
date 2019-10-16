using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Main.life <= 2)
        {
            Destroy(heart1);

        }

        if (Main.life <= 1)
        {
            Destroy(heart2);
        }

        if (Main.life <= 0)
        {
            Destroy(heart3);
        }
    }
}
