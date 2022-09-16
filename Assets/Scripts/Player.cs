using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;

    public Platform CurrentPlatform;
    public Game Game;
    public int PlatformsNumber;

    public Material material;

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
    }

    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public void Die()
    {
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.SetFloat("_DissolveAmount", 0.4f);
        Thread.Sleep(500);
        mr.material.SetFloat("_DissolveAmount", 0.8f);
        Thread.Sleep(500);
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

}
