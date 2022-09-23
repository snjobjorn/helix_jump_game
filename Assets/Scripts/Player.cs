using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;

    public Platform CurrentPlatform;
    public Game Game;
    public int PlatformsNumber;

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public IEnumerator Die()
    {
<<<<<<< Updated upstream
=======
        ParticleSystem ps = GetComponent<ParticleSystem>();
        MeshRenderer mr = GetComponent<MeshRenderer>();
        ps.Play();
        float dissolveAmount = -0.2f;
        while (dissolveAmount <= 1.8f)
        {
            dissolveAmount += 0.5f;
            mr.material.SetFloat("_DissolveAmount", dissolveAmount);
            Debug.Log(dissolveAmount);
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(0.01f);
>>>>>>> Stashed changes
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

}
