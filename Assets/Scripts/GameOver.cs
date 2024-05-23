using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(gameOver.activeSelf)
       {
            Debug.Log("bool check!");
            if(Input.GetAxisRaw("Cancel") == 1)
            {
                Debug.Log("Quitting check");
                Application.Quit();
            }
            
       }
    }
}
