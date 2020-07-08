using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeluarAlamGaib : MonoBehaviour
{
    Selesai selesai;
    BendaMistis bendaMistis;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        bendaMistis = GameObject.FindGameObjectWithTag("Player").GetComponent<BendaMistis>();
        selesai = GameObject.Find("Selesai").GetComponent<Selesai>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player"){
            for (int i = 0; i < bendaMistis.isFull.Length; i++){
                if(bendaMistis.isFull[i] == true){
                    count++;
                }
            }
        }

        if(count == 5){
            // SceneManager.LoadScene("MainMenu");
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            selesai.munculSelesai();
        }
    }
}
