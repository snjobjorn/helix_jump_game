using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public AudioSource PlatformBreakSound;    
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
    }
}
