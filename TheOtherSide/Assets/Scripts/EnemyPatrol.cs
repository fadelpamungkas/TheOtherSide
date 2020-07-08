using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingRight = true;

    public Transform groundDetection;

    Health boy;
    GameOver selesai;

    void Start(){
        boy = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        selesai = GameObject.Find("Game Over").GetComponent<GameOver>();

    }
    
    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if(other.transform.tag == "Player" && boy.health > 1){
            Destroy(gameObject);
            boy.health--;
        } else{
            boy.hearts[0].enabled = false;
            selesai.GameOverMuncul();

        }
    }
}
