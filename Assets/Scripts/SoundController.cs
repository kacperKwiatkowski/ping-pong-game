using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{

    public AudioSource wallSound;
    public AudioSource racketSound;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RacketPlayer1" || col.gameObject.name == "RacketPlayer2")
        {
            this.racketSound.Play();
        }
        else
        {
            this.wallSound.Play();
        }
    }
}
