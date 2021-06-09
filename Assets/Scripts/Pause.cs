using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textoPause;

    // Update is called once per frame
    void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Time.timeScale == 1)
            {
                textoPause.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
                textoPause.SetActive(false);
            }
        }
    }
}
