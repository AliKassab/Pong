using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    Rigidbody2D rgd;

    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos= transform.position;
        rgd= GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rgd.velocity= new Vector2(x * speed,y * speed);
    }

    public void ResetPosition()
    {
        transform.position = startPos;
        Launch();
    }
}
