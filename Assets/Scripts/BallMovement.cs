using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maximumSpeed;

    public int hitCounter;

    void Start()
    {
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if(isStartingPlayer1)
            this.MoveBall(new Vector2(-1, 0));
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }
    }
    
    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;

        float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidbody2D.velocity = dir * speed;
    }

    public void IncreaseHitCounter()
    {
        if (this.hitCounter * this.extraSpeedPerHit <= this.maximumSpeed)
        {
            this.hitCounter++;
        }
    }
}