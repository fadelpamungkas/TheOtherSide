using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BendaMistisTrigger : MonoBehaviour
{
    BendaMistis bendaMistis;
    public GameObject benda;
    // Start is called before the first frame update
    void Start()
    {
        bendaMistis = GameObject.FindGameObjectWithTag("Player").GetComponent<BendaMistis>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        for (int i = 0; i < bendaMistis.slots.Length; i++)
        {
            if(bendaMistis.isFull[i] == false){
                bendaMistis.isFull[i] = true;   
                Instantiate(benda, bendaMistis.slots[i].transform, false);
                Destroy(gameObject);          
                break;
            }
        }
    }
}
