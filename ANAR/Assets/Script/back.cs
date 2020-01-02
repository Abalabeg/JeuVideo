using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class back : MonoBehaviour
{
    public string whichBu= "Bu1";
    void Start()
    {
    int Bu= PlayerPrefs.GetInt(whichBu);
        if (Bu==1){
            Invoke ("GoMenu",1f);
        }
        else{
            Invoke("Get",1f);
        }
       
    }
     void Get(){
           
            PlayerPrefs.SetInt(whichBu,1);
            Invoke("GoMenu",1f);}

    void GoMenu()
    {
      SceneManager.LoadScene("MenuPlay");
    }
}
