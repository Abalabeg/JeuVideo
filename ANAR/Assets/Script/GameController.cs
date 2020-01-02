using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
   public void StartGame()
   {
       
       SceneManager.LoadScene("Scene00");
       //int index= Random.Range(2,4);
       //SceneManager.LoadScene(index);
   }
   public void StartGame1()
   {
       
       SceneManager.LoadScene("Scene01");
       //int index= Random.Range(2,4);
       //SceneManager.LoadScene(index);
   }
   public void GotoPrizeTicket(){
       SceneManager.LoadScene("PrizeTicket");
   }
   public void ResetPlayerPrefs(){
       PlayerPrefs.DeleteAll();
   }
}
