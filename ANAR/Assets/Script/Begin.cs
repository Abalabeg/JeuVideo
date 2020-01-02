using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Begin : MonoBehaviour
{
     void Startm() {
      SceneManager.LoadScene("intro");
 }
    public void ResetAll(){
       PlayerPrefs.DeleteAll();
   }
   public void Start1()
   {
       
       SceneManager.LoadScene("MenuPlay");
       
   }
}
