using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Player player;
    public ParticleSystem ps;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.TryGetComponent(out Player Player))
        {
            return;
        }

        StartCoroutine(FinishLevel());
    }

    public IEnumerator FinishLevel()
    {
        ps.Play();
        yield return new WaitForSeconds(1.5f);
        player.ReachFinish();
    }
}
