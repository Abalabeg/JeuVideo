using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
   public AudioSource answer;
   public AudioClip hoverAnswer;
   public AudioClip clickAnswer;

   public void HoverSound()
   {
       answer.PlayOneShot(hoverAnswer);

   }
   public void ClickSound(){
       answer.PlayOneShot(clickAnswer);
   }
}
