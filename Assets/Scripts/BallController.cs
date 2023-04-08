using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        body= GetComponent<Rigidbody2D>();
        body.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
