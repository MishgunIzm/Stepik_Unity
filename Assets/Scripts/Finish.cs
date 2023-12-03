using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private GameObject congrats; //1

    void Start()
    {
        Congrats(false);                          //2
    }

    void OnTriggerStay()                          //3
    {
        Congrats(true);                           //4
        Invoke("NextLvl", 3f);                    //5
    }

    void NextLvl()                                //6
    {
        print("NextLevel");                       //7
    }

    void Congrats(bool state)                     //8
    {
        congrats.SetActive(state);                //9
    }
}