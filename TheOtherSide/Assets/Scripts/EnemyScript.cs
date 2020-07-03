using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    public float k;

    public float speed;
    public float distance;
    private bool movingRight = true;
    public bool patrol = true;
    public bool kejarPlayer;
    public Transform groundDetection;

    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //distance to player
        float distToPlayer = Vector2.Distance(transform.position, player.position);

        //enemy patrol
        if (patrol == true)
        {
            RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
            transform.Translate(Vector2.right * speed * Time.deltaTime);
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

        if ((distToPlayer < agroRange) && kejarPlayer == true)
        {
            patrol = false;
            //code to chase player
            ChasePlayer();
        }
        else
        {
            //stop chasing player
            StopChasingPlayer();
            patrol = true;
        }
    }

    private void ChasePlayer()
    {
            if (transform.position.x < player.position.x)
            {
                //enemy is to the left side of the player, move right
                rb2d.velocity = new Vector2(moveSpeed, 0);
                transform.localScale = new Vector2(-k, k);
            }
            else if (transform.position.x > player.position.x)
            {
                //enemy is to the right side of the player, move left
                rb2d.velocity = new Vector2(-moveSpeed, 0);
                transform.localScale = new Vector2(k, k);
            }
    }

    private void StopChasingPlayer()
    {
        rb2d.velocity = Vector2.zero;
    }
}
