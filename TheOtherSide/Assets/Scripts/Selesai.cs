﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selesai : MonoBehaviour
{
    Animator  anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    public void munculSelesai(){
        anim.SetBool("selesai", true);
        Time.timeScale = 0f;
    }

    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
