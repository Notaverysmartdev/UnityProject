﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playgroundmenugo : MonoBehaviour
{
    
    public Animator transition;



    public float transitiontime = 1f;
   

    public void Playgame()
    {
         Time.timeScale = 1;
        if (gameObject.CompareTag("Restart"))
        {
         StartCoroutine(loadlevel(2));

        }
        if(!(gameObject.CompareTag("Restart") && !((gameObject.CompareTag("Startgame")))))
        {
            StartCoroutine(loadlevel(0));
        }

        if ((gameObject.CompareTag("Startgame")))
        {
            StartCoroutine(loadlevel(2));
        }
    }





    IEnumerator loadlevel(int loadlevel)
    {
        transition.SetTrigger("start");


        yield return new WaitForSeconds(transitiontime);


        SceneManager.LoadScene(loadlevel);




    }
}

