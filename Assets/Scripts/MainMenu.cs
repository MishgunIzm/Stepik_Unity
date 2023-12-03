using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;                                                  

public class MainMenuScript : MonoBehaviour
{                                                                                   
    [SerializeField] private GameObject ballPrefab;                                 
    [SerializeField] private float xBound = 6f;                                     
    [SerializeField] private float zBound = 5.3f;                                   
    [SerializeField] private float destroyBorder = -15f;                            

    private GameObject ball;                                                        

    void Update()                                                                   
    {
        BallSpawner();                                                              

        BallDestroy(destroyBorder);                                                 
    }

    void BallSpawner()                                                              
    {
        if (ball != null)                                                            
        {
            return;                                                                 
        }
        else                                                                        
        {
            float rXBound = Random.Range(-xBound, xBound);                          
            float rZBound = Random.Range(-zBound, zBound);                          

            Vector3 ballPos = new Vector3(rXBound, transform.position.y, rZBound);  

            ball = Instantiate(ballPrefab, ballPos, Quaternion.identity);           
            ball.transform.parent = transform;                                      
        }
    }

    void BallDestroy(float value)                                                   
    {
        if (ball.transform.position.y < value)                                      
        {
            Destroy(ball);                                                          
        }
    }

    public void AppExit()                                                           
    {
#if UNITY_EDITOR                                                            
        UnityEditor.EditorApplication.ExitPlaymode();                               
#endif                                                                      

        Application.Quit();                                                         

        Debug.Log("Exit");                                                          
    }

    public void LoadNextScene()                                                     
    {
        SceneManager.LoadScene(1);                                                  
    }
}                                                                                   