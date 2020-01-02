using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelC : MonoBehaviour
{
    public GameObject A,I,OU,APlace,IPlace,OUPlace;
    Vector2 AInitialPosition , IInitialPosition, OUInitialPosition;
    Vector2 mousePosition;
    bool one, two, three=false;
    //public AudioSource source;
    //public AudioClip ASound;
    //public AudioClip ISound;
    //public AudioClip OUSound;
    GameObject[] toEnable, toDisable;
    public GameObject correctSign, incorrectSign, airplane, prizeSign;
    int currentSceneIndex;
    public string whichAirplaneGot= "Airplane0Got";

    void Start(){
        AInitialPosition=A.transform.position;
        IInitialPosition=I.transform.position;
        OUInitialPosition=OU.transform.position;
         currentSceneIndex= SceneManager.GetActiveScene().buildIndex;
        toEnable=GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable=GameObject.FindGameObjectsWithTag("ToDisable");

        foreach (GameObject element in toEnable){
            element.gameObject.SetActive(false);
        }
    }

    public void DragA(){
        A.transform.position = Input.mousePosition;
        //source.clip= ASound;
        //source.Play();
    }
     public void DragI(){
        I.transform.position=Input.mousePosition;
        //source.clip= ISound;
        //source.Play();
    }
     public void DragOU(){
        OU.transform.position=Input.mousePosition;
        //source.clip= OUSound;
        //source.Play();
    }

    public void DropA(){
        float Distance=Vector3.Distance(A.transform.position,APlace.transform.position);
        if (Distance<50&& one==false)
        {
            A.transform.position=APlace.transform.position;
            //source.clip= ASound;
            //source.Play();
            one=true;
        }
        else
        {
            A.transform.position=AInitialPosition;
        }
    }
    public void DropI(){
        float Distance=Vector3.Distance(I.transform.position,IPlace.transform.position);
        if (Distance<50&&two==false)
        {
            I.transform.position=IPlace.transform.position;
            //source.clip= ISound;
            //source.Play();
            two=true;
        }
        else
        {
            I.transform.position=IInitialPosition;
        }
    }
    public void DropOU(){
        float Distance=Vector3.Distance(OU.transform.position,OUPlace.transform.position);
    if (Distance<50 && three==false)
        {
            OU.transform.position=OUPlace.transform.position;
            //source.clip= OUSound;
            //source.Play();
            three=true;
        }
        else
        {
            OU.transform.position=OUInitialPosition;
        }
    }

    void Update()
    {if(one==true&&two==true&& three==true){
        foreach(GameObject element in toDisable){
            element.gameObject.SetActive(false);
        }
        //correctSign.gameObject.SetActive(true);
        int AirplaneGot= PlayerPrefs.GetInt(whichAirplaneGot);
        if (AirplaneGot==1){
            Invoke ("LoadNextLevel",1f);
        }
        else{
            Invoke("GetPrize",1f);
        }}
    }
     void GetPrize(){
            correctSign.SetActive(false);
            airplane.SetActive(true);
            prizeSign.SetActive(true);
            PlayerPrefs.SetInt(whichAirplaneGot,1);
            Invoke("LoadNextLevel",1f);
        }
        void LoadNextLevel(){
            //int index= Random.Range(2,5);
           // SceneManager.LoadScene(index);
            SceneManager.LoadScene(currentSceneIndex+1);
        }
        void GotMenuPlay(){
            SceneManager.LoadScene("MenuPlay");
        }
    

}
