using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    [SerializeField] bool isPlayerLeft;
    [SerializeField] float speed = 1f;
    [SerializeField] Rigidbody2D rgd;

    Vector2 startPos;

    float direction;

    private void Start()
    {
        startPos= transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (isPlayerLeft)
            direction = Input.GetAxisRaw("Vertical");
        else
            direction = Input.GetAxisRaw("Vertical2");

        rgd.velocity = new Vector2(rgd.velocity.x, direction * speed);
    }

    public void ResetPosition()
    {
        transform.position = startPos;
    }
}
