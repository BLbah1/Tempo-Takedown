using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb2d;

    [SerializeField] float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 2D Movement
        Vector2 move = new Vector2 (Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb2d.velocity = move * moveSpeed;
    }
}
