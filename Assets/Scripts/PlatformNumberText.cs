using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformNumberText : MonoBehaviour
{
    public Text Text;
    public Player player;

    private void Update()
    {
        Text.text = (player.PlatformsNumber - 1).ToString();
    }
}
