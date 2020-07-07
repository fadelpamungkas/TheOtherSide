using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health = 3;
    public Image[] hearts;
    public Sprite heart;
    bool awal =  true;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health){
                hearts[i].enabled = true;
            } else{
                hearts[i].enabled = false;
            }
        }

        if(health == 0){
            hearts[0].enabled = false;
        }
    }
}
