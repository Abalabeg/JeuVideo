using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelC3 : MonoBehaviour
{ public GameObject D,S,R,Z,K,N,DPlace, SPlace,RPlace,ZPlace,KPlace,NPlace;
    Vector2 DInitialPosition,SInitialPosition , RInitialPosition, ZInitialPosition,KInitialPosition, NInitialPosition;
    Vector2 mousePosition;
    bool one, two, three, four,five, six=false;
//public AudioSource source;
//public AudioClip DSound;
//public AudioClip SSound;
//public AudioClip RSound;
//public AudioClip ZSound;
//public AudioClip KSound;
//public AudioClip NSound;
    GameObject[] toEnable, toDisable;
    public GameObject correctSign, incorrectSign, airplane, prizeSign;
    int currentSceneIndex;
    public string whichAirplaneGot= "Airplane0Got";

    void Start(){
        DInitialPosition=D.transform.position;
        SInitialPosition=S.transform.position;
        RInitialPosition=R.transform.position;
        ZInitialPosition=Z.transform.position;
        KInitialPosition=K.transform.position;
        NInitialPosition=N.transform.position;

        currentSceneIndex= SceneManager.GetActiveScene().buildIndex;
        toEnable=GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable=GameObject.FindGameObjectsWithTag("ToDisable");

        foreach (GameObject element in toEnable){
            element.gameObject.SetActive(false);
        }
    }
    public void DragD(){
        D.transform.position = Input.mousePosition;
    
    }
    public void DragS(){
        S.transform.position = Input.mousePosition;
    
    }
     public void DragR(){
        R.transform.position=Input.mousePosition;
    }
     public void DragZ(){
        Z.transform.position=Input.mousePosition;
    }

    public void DragK(){
        K.transform.position=Input.mousePosition;
    }
     public void DragN(){
        N.transform.position=Input.mousePosition;
    }

    public void DropD(){
        float Distance=Vector3.Distance(D.transform.position,DPlace.transform.position);
        if (Distance<50&& six==false)
        {
            D.transform.position=DPlace.transform.position;
            //source.clip= DSound;
            //source.Play();
            six=true;
        }
        else
        {
            D.transform.position=DInitialPosition;
        }
        }

    public void DropS(){
        float Distance=Vector3.Distance(S.transform.position,SPlace.transform.position);
        if (Distance<50&& one==false)
        {
            S.transform.position=SPlace.transform.position;
            //source.clip= SSound;
            //source.Play();
            one=true;
        }
        else
        {
            S.transform.position=SInitialPosition;
        }
    }
    public void DropR(){
        float Distance=Vector3.Distance(R.transform.position,RPlace.transform.position);
        if (Distance<50&&two==false)
        {
            R.transform.position=RPlace.transform.position;
            //source.clip= RSound;
            //source.Play();
            two=true;
        }
        else
        {
            R.transform.position=RInitialPosition;
        }
    }

    public void DropK(){
        float Distance=Vector3.Distance(K.transform.position,KPlace.transform.position);
    if (Distance<50 && three==false)
        {
            K.transform.position=KPlace.transform.position;
            //source.clip= KSound;
            //source.Play();
            three=true;
        }
        else
        {
            K.transform.position=KInitialPosition;
        }
    }

public void DropN(){
        float Distance=Vector3.Distance(N.transform.position,NPlace.transform.position);
    if (Distance<50 && four==false)
        {
            N.transform.position=NPlace.transform.position;
            //source.clip= NSound;
            //source.Play();
            four=true;
        }
        else
        {
            N.transform.position=NInitialPosition;
        }
    }
    public void DropZ(){
        float Distance=Vector3.Distance(Z.transform.position,ZPlace.transform.position);
    if (Distance<50 && five==false)
        {
            Z.transform.position=ZPlace.transform.position;
            //source.clip= ZSound;
            //source.Play();
            five=true;
        }
        else
        {
            Z.transform.position=ZInitialPosition;
        }
    }
    void Update()
    {if(one==true&&two==true&& three==true&& four==true&&five==true&&six==true){
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

