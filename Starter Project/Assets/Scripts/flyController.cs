using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyController : MonoBehaviour
{
    public Sprite deathSprite;
    public bool isDead = false;
    public GameObject part;
    public GameObject swatter;
    private swatterController controller;
    public AudioSource audioSource;
    public AudioClip deathSound;

    // Start is called before the first frame update
    void Start()
    {
        Vector2 position = transform.position;
        position.x = (Random.Range(-7f, 7f));
        position.y = (Random.Range(-3.5f, 3.5f));
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Update is called when clicked on
    void OnMouseDown()
    {
        controller = swatter.GetComponent<swatterController>();
        if(!isDead)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = deathSprite;
            Instantiate(part, Camera.main.ScreenToWorldPoint(Input.mousePosition), Quaternion.identity);
            controller.score = controller.score + 1;
            audioSource.PlayOneShot(deathSound, 1);
            isDead = true;
        }
    }
}
