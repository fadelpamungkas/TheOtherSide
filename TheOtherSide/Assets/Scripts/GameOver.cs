using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    Health boy;
    Animator anim;
    movement_BOY boys;

    void Start()
    {
        anim = GetComponent<Animator>();
        boy = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        boys = GameObject.FindGameObjectWithTag("Player").GetComponent<movement_BOY>();

    }

    void Update()
    {
        // if(boy.health < 1){
        //     Time.timeScale = 0f;
        //     GameOverMuncul();
        // }
    }

    public void BacToMainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void GameOverMuncul(){
        boys.DestroyBoy();
        gameObject.SetActive(true);
        anim.SetBool("gameOver",  true);
        Time.timeScale = 0f;
    }
}
