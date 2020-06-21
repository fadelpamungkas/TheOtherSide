using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKunti : MonoBehaviour
{
    private SpriteRenderer spriteR;

    // Start is called before the first frame update
    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        spriteR.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            spriteR.enabled = true;
            Destroy(gameObject, 3f);
        }
    }
}
