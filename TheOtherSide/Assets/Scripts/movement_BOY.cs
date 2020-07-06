using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_BOY : MonoBehaviour
{
    public int moveSpeed, kekuatanLompat;
    Rigidbody2D lompat;
    bool balik;
    int pindah;
    public int darah;

    public bool isGrounded = false;
    public bool tanah;
    public LayerMask targetLayer;
    public Transform deteksiTanah1;
    public Transform deteksiTanah2;
    public float jangkauan;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        lompat = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        darah = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(tanah == true)
        {
            anim.SetBool("lompat", false);
            
        } else
        {
            anim.SetBool("lompat", true);
        }
     
        tanah = Physics2D.OverlapCircle(deteksiTanah1.position, jangkauan, targetLayer);
        tanah = Physics2D.OverlapCircle(deteksiTanah2.position, jangkauan, targetLayer);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            pindah = -1;
            anim.SetBool("jalan", true);
        } else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * -moveSpeed * Time.deltaTime);
            pindah = 1;
            anim.SetBool("jalan", true);
        }
        else
        {
            anim.SetBool("jalan", false);
        }

        if ((Input.GetKey(KeyCode.W)) && tanah == true)
        {
            //lompat.AddForce(new Vector2(0, kekuatanLompat));
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 5f), ForceMode2D.Impulse);
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * kekuatanLompat);
        }

        if (pindah>0 && !balik)
        {
            balikBadan();
        } else if (pindah<0 && balik)
        {
            balikBadan();
        }
    }

    void balikBadan()
    {
        balik = !balik;
        Vector3 karakter = transform.localScale;
        karakter.x *= -1;
        transform.localScale = karakter;
    }
    
}
