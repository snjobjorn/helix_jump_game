using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public AudioSource PlatformBreakSound;
    public ParticleSystem ps;
    public void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Player player))
        {
            player.CurrentPlatform = this;
            player.PlatformsNumber++;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        PlatformBreakSound.Play();
        StartCoroutine(platformExit());
    }

    public IEnumerator platformExit()
    {
        yield return new WaitForSeconds(0.3f);
        ps.Play();
        yield return new WaitForSeconds(0.3f);
        gameObject.SetActive(false);
    }
}
