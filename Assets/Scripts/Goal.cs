using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    [SerializeField] bool isLeftGoal;

    private void OnTriggerEnter2D(Collider2D collision)        
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            if (isLeftGoal)
                GameObject.Find("GameManager").GetComponent<GameManager>().RightPlayerScored();

            else
                GameObject.Find("GameManager").GetComponent<GameManager>().LeftPlayerScored();
        }
    }
}
