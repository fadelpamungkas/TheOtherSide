using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDetector : MonoBehaviour
{
    public Transform spawn;
    public movement_BOY boy;
    // Start is called before the first frame update
    void Start()
    {
        boy = GameObject.FindGameObjectWithTag("Player").GetComponent<movement_BOY>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player" && boy.darah > 1)
        {
            boy.darah--;
            other.transform.position = spawn.position;
        } 
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
