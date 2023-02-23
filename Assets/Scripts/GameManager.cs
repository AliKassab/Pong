using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [Header("Ball")]
    [SerializeField] GameObject ball;

    [Header("Left Player")]
    [SerializeField] GameObject LeftPlayer;
    [SerializeField] GameObject LeftGoal;

    [Header("Right Player")]
    [SerializeField] GameObject RightPlayer;
    [SerializeField] GameObject RightGoal;

    [Header("Score UI")]
    [SerializeField] Text LeftScore;
    [SerializeField] Text RightScore;

    int leftScore;
    int rightScore;

    public void LeftPlayerScored()
    {
        leftScore++;
        LeftScore.text = leftScore.ToString();
        RestartPos();
    }

    public void RightPlayerScored()
    {
        rightScore++;
        RightScore.text = rightScore.ToString();
        RestartPos();
    }

    private void RestartPos()
    {
        ball.GetComponent<Ball>().ResetPosition();
        LeftPlayer.GetComponent<Platform>().ResetPosition();
        RightPlayer.GetComponent<Platform>().ResetPosition();
    }

}
