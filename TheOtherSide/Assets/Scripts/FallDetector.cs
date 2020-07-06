using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour
{
    public Transform spawn;
    Health boy;
    // public GameObject gameOver;
    GameOver selesai;
    // Start is called before the first frame update
    void Start()
    {
        boy = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        selesai = GameObject.Find("Game Over").GetComponent<GameOver>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && boy.health > 1)
        {
            boy.health--;
            other.transform.position = spawn.position;
        } 
        else
        {
            selesai.GameOverMuncul();
        }
    }
}
