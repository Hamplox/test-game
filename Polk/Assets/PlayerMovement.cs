using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    private Vector2 dir;
    public float speed;
    public int hp = 100;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            dir = Vector2.left;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            dir = Vector2.right;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            dir = Vector2.down;
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            dir = Vector2.up;
        }else
        {
            dir = Vector2.zero;
        }
        transform.position = transform.position + (Vector3)(dir * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            hp--;
        }
    }
}
