using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelC4 : MonoBehaviour
{
    public GameObject yek,doo,se;
    public GameObject chahar, panj, shish, haft, hasht, noh, dah,
    yekPlace, doPlace, sePlace, chaharPlace, panjPlace, shishPlace, haftPlace, hashtPlace, nohPlace, dahPlace;
    Vector2 yekInitialPosition,doInitialPosition , seInitialPosition, chaharInitialPosition,panjInitialPosition, 
    shishInitialPosition,haftInitialPosition,hashtInitialPosition,nohInitialPosition,dahInitialPosition;
    Vector2 mousePosition;
    bool one, two, three, four,five, six, seven, eight, nine, ten=false;
    //public AudioSource source;
    //public AudioClip yekSound;
    //public AudioClip doSound;
    //public AudioClip seSound;
    //public AudioClip chaharSound;
    //public AudioClip panjSound;
    //public AudioClip shishSound;
    //public AudioClip haftSound;
    //public AudioClip hashtSound;
    //public AudioClip nohSound;
    //public AudioClip dahSound;
    GameObject[] toEnable, toDisable;
    public GameObject correctSign, incorrectSign, airplane, prizeSign;
    int currentSceneIndex;
    public string whichAirplaneGot= "Airplane0Got";

    void Start(){
        yekInitialPosition=yek.transform.position;
        doInitialPosition=doo.transform.position;
        seInitialPosition=se.transform.position;
        chaharInitialPosition=chahar.transform.position;
        panjInitialPosition=panj.transform.position;
        shishInitialPosition=shish.transform.position;
        haftInitialPosition=haft.transform.position;
        hashtInitialPosition=hasht.transform.position;
        nohInitialPosition=noh.transform.position;
        dahInitialPosition=dah.transform.position;




        currentSceneIndex= SceneManager.GetActiveScene().buildIndex;
        toEnable=GameObject.FindGameObjectsWithTag("ToEnable");
        toDisable=GameObject.FindGameObjectsWithTag("ToDisable");

        foreach (GameObject element in toEnable){
            element.gameObject.SetActive(false);
        }
    }
    public void Drag1(){
        yek.transform.position = Input.mousePosition;
    
    }
    public void Drag2(){
        doo.transform.position = Input.mousePosition;
    
    }
     public void Drag3(){
        se.transform.position=Input.mousePosition;
    }
     public void Drag4(){
        chahar.transform.position=Input.mousePosition;
    }

    public void Drag5(){
        panj.transform.position=Input.mousePosition;
    }
     public void Drag6(){
        shish.transform.position=Input.mousePosition;
    }
    public void Drag7(){
        haft.transform.position=Input.mousePosition;
    }
    public void Drag8(){
        hasht.transform.position=Input.mousePosition;
    }
    public void Drag9(){
        noh.transform.position=Input.mousePosition;
    }
    public void Drag10(){
        dah.transform.position=Input.mousePosition;
    }

    public void Drop1(){
        float Distance=Vector3.Distance(yek.transform.position,yekPlace.transform.position);
        if (Distance<50&& six==false)
        {
            yek.transform.position=yekPlace.transform.position;
            //source.clip= yekSound;
            //source.Play();
            six=true;
        }
        else
        {
            yek.transform.position=yekInitialPosition;
        }
        }

    public void Drop2(){
        float Distance=Vector3.Distance(doo.transform.position,doPlace.transform.position);
        if (Distance<50&& one==false)
        {
            doo.transform.position=doPlace.transform.position;
            //source.clip= doSound;
            //source.Play();
            one=true;
        }
        else
        {
            doo.transform.position=doInitialPosition;
        }
    }
    public void Drop3(){
        float Distance=Vector3.Distance(se.transform.position,sePlace.transform.position);
        if (Distance<50&&two==false)
        {
            se.transform.position=sePlace.transform.position;
            //source.clip= seSound;
            //source.Play();
            two=true;
        }
        else
        {
            se.transform.position=seInitialPosition;
        }
    }

    public void Drop4(){
        float Distance=Vector3.Distance(chahar.transform.position,chaharPlace.transform.position);
    if (Distance<50 && three==false)
        {
            chahar.transform.position=chaharPlace.transform.position;
            //source.clip= chaharSound;
            //source.Play();
            three=true;
        }
        else
        {
            chahar.transform.position=chaharInitialPosition;
        }
    }

    public void Drop5(){
        float Distance=Vector3.Distance(panj.transform.position,panjPlace.transform.position);
    if (Distance<50 && four==false)
        {
            panj.transform.position=panjPlace.transform.position;
            //source.clip= panjSound;
            //source.Play();
            four=true;
        }
        else
        {
            panj.transform.position=panjInitialPosition;
        }
    }
    public void Drop6(){
        float Distance=Vector3.Distance(shish.transform.position,shishPlace.transform.position);
    if (Distance<50 && five==false)
        {
            shish.transform.position=shishPlace.transform.position;
            //source.clip= shishSound;
            //source.Play();
            five=true;
        }
        else
        {
            shish.transform.position=shishInitialPosition;
        }
    }

    public void Drop7(){
        float Distance=Vector3.Distance(haft.transform.position,haftPlace.transform.position);
    if (Distance<50 && seven==false)
        {
            haft.transform.position=haftPlace.transform.position;
            //source.clip= haftSound;
            //source.Play();
            seven=true;
        }
        else
        {
            haft.transform.position=haftInitialPosition;
        }
    }
    public void Drop8(){
        float Distance=Vector3.Distance(hasht.transform.position,hashtPlace.transform.position);
    if (Distance<50 && eight==false)
        {
            hasht.transform.position=hashtPlace.transform.position;
            //source.clip= hashtSound;
            //source.Play();
            eight=true;
        }
        else
        {
            hasht.transform.position=hashtInitialPosition;
        }
    }
    public void Drop9(){
        float Distance=Vector3.Distance(noh.transform.position,nohPlace.transform.position);
    if (Distance<50 && nine==false)
        {
            noh.transform.position=nohPlace.transform.position;
            //source.clip= nohSound;
            //source.Play();
            nine=true;
        }
        else
        {
            noh.transform.position=nohInitialPosition;
        }
    }
    public void Drop10(){
        float Distance=Vector3.Distance(dah.transform.position,dahPlace.transform.position);
    if (Distance<50 && ten==false)
        {
            dah.transform.position=dahPlace.transform.position;
            //source.clip= dahSound;
            //source.Play();
            ten=true;
        }
        else
        {
            dah.transform.position=dahInitialPosition;
        }
    }

    void Update()
    {if(one==true&&two==true&& three==true&& four==true&&five==true&&six==true&&seven==true&&eight==true&&nine==true&&ten==true){
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
