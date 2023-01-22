using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class swatterController : MonoBehaviour
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        //move to mouse on click
        if (Input.GetMouseButtonDown(0))
        {
            position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = position;
        }

        if(score == 10)
        {
            SceneManager.LoadScene("win", LoadSceneMode.Single);
        }
    }
}
