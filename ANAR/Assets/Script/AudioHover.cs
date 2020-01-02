using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHover : MonoBehaviour
{
    public AudioSource voice;
   public AudioClip hoverVoice;
   

   public void HoverV()
   {
       voice.PlayOneShot(hoverVoice);

   }
}
