using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelControl : MonoBehaviour
{
    GameObject[] toEnable, toDisable;
    public GameObject correctSign, incorrectSign, airplane, prizeSign;
    int currentSceneIndex;
    public string whichAirplaneGot= "Airplane0Got";

    void Start(){
        currentSceneIndex= SceneManager.GetActiveScene().buildIndex;
        toEnable=GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable=GameObject.FindGameObjectsWithTag("ToDisable");

        foreach (GameObject element in toEnable){
            element.gameObject.SetActive(false);
        }

    }
    public void RightAnswer(){
        foreach(GameObject element in toDisable){
            element.gameObject.SetActive(false);
        }
        correctSign.gameObject.SetActive(true);
        int AirplaneGot= PlayerPrefs.GetInt(whichAirplaneGot);
        if (AirplaneGot==1){
            Invoke ("LoadNextLevel",4f);
        }
        else{
            Invoke("GetPrize",1f);
        }
    }
        public void WrongAnswer(){
            foreach(GameObject element in toDisable){
                element.gameObject.SetActive(false);
            }
            incorrectSign.SetActive(true);
            //Invoke("MenuPlay",1f);
            //GotMenuPlay();
            Invoke("currentscene",1f);
            //SceneManager.LoadScene(currentSceneIndex);
            
        }
        void GetPrize(){
            correctSign.SetActive(false);
            airplane.SetActive(true);
            prizeSign.SetActive(true);
            PlayerPrefs.SetInt(whichAirplaneGot,1);
            Invoke("LoadNextLevel",3f);
        }
        void LoadNextLevel(){
            //int index= Random.Range(2,5);
           // SceneManager.LoadScene(index);
            SceneManager.LoadScene(currentSceneIndex+1);
        }
        void GotMenuPlay(){
            SceneManager.LoadScene("MenuPlay");
        }
        void currentscene(){
            SceneManager.LoadScene(currentSceneIndex);
        }

    

}
