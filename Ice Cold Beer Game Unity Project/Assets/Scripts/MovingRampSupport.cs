using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{
    public float moveSpeed = 0.1f;

    private float verticalInput;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(1, 0);
    }

    // Use fixed update for physics code, because we need to be
    // Careful about how often we call expensive, hardware intensive,
    // physics stuff.
    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector2(0, verticalInput * moveSpeed);
    }
}
