using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelWord : MonoBehaviour
{

        

      public GameObject play1, play2,play3;
      int Bu1,Bu2,Bu3;
      void Start(){
      Bu1=PlayerPrefs.GetInt("Bu1");
       Bu2=PlayerPrefs.GetInt("Bu2");
       Bu3=PlayerPrefs.GetInt("Bu3");
          if (Bu1==1)
        play1.SetActive(true);
        
        else
        
            play1.SetActive(false);

      if (Bu2==1)
        play2.SetActive(true);
        
        else
        
            play2.SetActive(false);
         if (Bu3==1)
        play3.SetActive(true);
        
        else
        
            play3.SetActive(false);
        }

 public void StartGame1()
   {
       
       SceneManager.LoadScene("Scene01");
   }

   public void StartGame2()
   {
       
       SceneManager.LoadScene("Scene02");
       
   }
  
  public void StartGame3()
   {
       
       SceneManager.LoadScene("Scene03");
       
   }
  
}
