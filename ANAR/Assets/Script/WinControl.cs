using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke ("back",1f);
    }

    // Update is called once per frame
    void back()
    {
      SceneManager.LoadScene("MenuPlay");
    }
}
