using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D c)
    {
        Debug.Log("RACKET COLLISION");
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;
        
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        
        Debug.Log("COLLISION");
        
        if (col.gameObject.name == "RacketPlayer1" || col.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRacket(col);
        }
        else if(col.gameObject.name == "LeftWall")
        {
            Debug.Log("Collision with wall left");
            this.scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovement.StartBall(true));
        }
        else if(col.gameObject.name == "RightWall")
        {
            Debug.Log("Collision with wall right");
            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovement.StartBall(false));
        }
            
    }
}
