using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapStomper : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private Rigidbody2D player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void Update()
    {
        if (player.position.x > transform.position.x -1f && player.position.x < transform.position.x + 1f && player.bodyType == RigidbodyType2D.Dynamic)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.bodyType = RigidbodyType2D.Static;
    }
}
