using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelC1 : MonoBehaviour
{
   public GameObject B,T,P,TA,Y, BPlace,PPlace,TPlace,YPlace,TAPlace;
    Vector2 BInitialPosition , TInitialPosition, PInitialPosition,TAInitialPosition, YInitialPosition;
    Vector2 mousePosition;
    bool one, two, three, four,five=false;
    //public AudioSource source;
    //public AudioClip BSound;
    //public AudioClip PSound;
    //public AudioClip TASound;
    //public AudioClip TSound;
    //public AudioClip YSound;
    GameObject[] toEnable, toDisable;
    public GameObject correctSign, incorrectSign, airplane, prizeSign;
    int currentSceneIndex;
    public string whichAirplaneGot= "Airplane0Got";

    void Start(){
        BInitialPosition=B.transform.position;
        TInitialPosition=T.transform.position;
        PInitialPosition=P.transform.position;
        TAInitialPosition=TA.transform.position;
        YInitialPosition=Y.transform.position;
        currentSceneIndex= SceneManager.GetActiveScene().buildIndex;
        toEnable=GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable=GameObject.FindGameObjectsWithTag("ToDisable");

        foreach (GameObject element in toEnable){
            element.gameObject.SetActive(false);
        }
    }

    public void DragB(){
        B.transform.position = Input.mousePosition;
    
    }
     public void DragP(){
        P.transform.position=Input.mousePosition;
    }
     public void DragT(){
        T.transform.position=Input.mousePosition;
    }

    public void DragTA(){
        TA.transform.position=Input.mousePosition;
    }
     public void DragY(){
        Y.transform.position=Input.mousePosition;
    }

    public void DropB(){
        float Distance=Vector3.Distance(B.transform.position,BPlace.transform.position);
        if (Distance<50&& one==false)
        {
            B.transform.position=BPlace.transform.position;
            //source.clip= BSound;
            //source.Play();
            one=true;
        }
        else
        {
            B.transform.position=BInitialPosition;
        }
    }
    public void DropP(){
        float Distance=Vector3.Distance(P.transform.position,PPlace.transform.position);
        if (Distance<50&&two==false)
        {
            P.transform.position=PPlace.transform.position;
            //source.clip= PSound;
            //source.Play();
            two=true;
        }
        else
        {
            P.transform.position=PInitialPosition;
        }
    }

    public void DropT(){
        float Distance=Vector3.Distance(T.transform.position,TPlace.transform.position);
    if (Distance<50 && three==false)
        {
            T.transform.position=TPlace.transform.position;
            //source.clip= TSound;
            //source.Play();
            three=true;
        }
        else
        {
            T.transform.position=TInitialPosition;
        }
    }

public void DropTA(){
        float Distance=Vector3.Distance(TA.transform.position,TAPlace.transform.position);
    if (Distance<50 && four==false)
        {
            TA.transform.position=TAPlace.transform.position;
            //source.clip= TASound;
            //source.Play();
            four=true;
        }
        else
        {
            TA.transform.position=TAInitialPosition;
        }
    }
    public void DropY(){
        float Distance=Vector3.Distance(Y.transform.position,YPlace.transform.position);
    if (Distance<50 && five==false)
        {
            Y.transform.position=YPlace.transform.position;
        // source.clip= YSound;
            //source.Play();
            five=true;
        }
        else
        {
            Y.transform.position=YInitialPosition;
        }
    }
    void Update()
    {if(one==true&&two==true&& three==true&& four==true&&five==true){
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
