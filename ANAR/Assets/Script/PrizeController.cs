using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrizeController : MonoBehaviour
{
   public GameObject airplane0,airplane0_1, airplane0_2,airplane0_3,airplane0_4,
   airplane0_5,airplane0_6,airplane0_7,airplane0_8, 
   airplane1, airplane1_1, airplane1_2,airplane1_3, 
   airplane2,airplane2_1, airplane2_2,airplane2_3, 
   airplane3,airplane3_1, airplane3_2,airplane3_3;
   int airplane0Got,airplane0_1Got,airplane0_2Got,airplane0_3Got,airplane0_4Got,
   airplane0_5Got, airplane0_6Got,airplane0_7Got,airplane0_8Got,
    airplane1Got,airplane1_1Got,airplane1_2Got,airplane1_3Got,
    airplane2Got,airplane2_1Got,airplane2_2Got,airplane2_3Got,
    airplane3Got,airplane3_1Got,airplane3_2Got,airplane3_3Got;
   void Start(){
      airplane0Got=PlayerPrefs.GetInt("Airplane0Got");
       airplane0_1Got=PlayerPrefs.GetInt("Airplane0_1Got");
       airplane0_2Got=PlayerPrefs.GetInt("Airplane0_2Got");
       airplane0_3Got=PlayerPrefs.GetInt("Airplane0_3Got");
       airplane0_4Got=PlayerPrefs.GetInt("Airplane0_4Got");
       airplane0_5Got=PlayerPrefs.GetInt("Airplane0_5Got");
       airplane0_6Got=PlayerPrefs.GetInt("Airplane0_6Got");
       airplane0_7Got=PlayerPrefs.GetInt("Airplane0_7Got");
       airplane0_8Got=PlayerPrefs.GetInt("Airplane0_8Got");
       airplane1Got=PlayerPrefs.GetInt("Airplane1Got");
       airplane1_1Got=PlayerPrefs.GetInt("Airplane1_1Got");
       airplane1_2Got=PlayerPrefs.GetInt("Airplane1_2Got");
       airplane1_3Got=PlayerPrefs.GetInt("Airplane1_3Got");
       airplane2Got=PlayerPrefs.GetInt("Airplane2Got");
       airplane2_1Got=PlayerPrefs.GetInt("Airplane2_1Got");
       airplane2_2Got=PlayerPrefs.GetInt("Airplane2_2Got");
       airplane2_3Got=PlayerPrefs.GetInt("Airplane2_3Got");
       airplane3Got=PlayerPrefs.GetInt("Airplane3Got");
        airplane3_1Got=PlayerPrefs.GetInt("Airplane3_1Got");
       airplane3_2Got=PlayerPrefs.GetInt("Airplane3_2Got");
       airplane3_3Got=PlayerPrefs.GetInt("Airplane3_3Got");
       if (airplane0Got==1)
        airplane0.SetActive(true);
        
        else
        
            airplane0.SetActive(false);

      if (airplane0_1Got==1)
        airplane0_1.SetActive(true);
        
        else
        
            airplane0_1.SetActive(false);
        
        if (airplane0_2Got==1)
        airplane0_2.SetActive(true);
        
        else
        
            airplane0_2.SetActive(false);
        if (airplane0_3Got==1)
        airplane0_3.SetActive(true);
        
        else
        
            airplane0_3.SetActive(false);
        if (airplane0_4Got==1)
        airplane0_4.SetActive(true);
        
        else
        
            airplane0_4.SetActive(false);
        if (airplane0_5Got==1)
        airplane0_5.SetActive(true);
        
        else
        
            airplane0_5.SetActive(false);
        if (airplane0_6Got==1)
        airplane0_6.SetActive(true);
        
        else
        
            airplane0_6.SetActive(false);
        if (airplane0_7Got==1)
        airplane0_7.SetActive(true);
        
        else
        
            airplane0_7.SetActive(false);
        if (airplane0_8Got==1)
        airplane0_8.SetActive(true);
        
        else
        
            airplane0_8.SetActive(false);
        
            
       if (airplane1Got==1)
        airplane1.SetActive(true);
        
        else
        
            airplane1.SetActive(false);

        if (airplane1_1Got==1)
        airplane1_1.SetActive(true);
        
        else
        
            airplane1_1.SetActive(false);
        
        if (airplane1_2Got==1)
        airplane1_2.SetActive(true);
        
        else
        
            airplane1_2.SetActive(false);
        if (airplane1_3Got==1)
        airplane1_3.SetActive(true);
        
        else
        
            airplane1_3.SetActive(false);
        
         if (airplane2Got==1)
        airplane2.SetActive(true);
        
        else
        
            airplane2.SetActive(false);

        if (airplane2_1Got==1)
        airplane2_1.SetActive(true);
        
        else
        
            airplane2_1.SetActive(false);
        
        if (airplane2_2Got==1)
        airplane2_2.SetActive(true);
        
        else
        
            airplane2_2.SetActive(false);
        if (airplane2_3Got==1)
        airplane2_3.SetActive(true);
        
        else
        
            airplane2_3.SetActive(false);
        
         if (airplane3Got==1)
        airplane3.SetActive(true);
        
        else
        
          airplane3.SetActive(false);
          if (airplane3_1Got==1)
        airplane3_1.SetActive(true);
        
        else
        
            airplane3_1.SetActive(false);
        
        if (airplane3_2Got==1)
        airplane3_2.SetActive(true);
        
        else
        
            airplane3_2.SetActive(false);
        if (airplane3_3Got==1)
        airplane3_3.SetActive(true);
        
        else
        
            airplane3_3.SetActive(false);
        
   }
}
