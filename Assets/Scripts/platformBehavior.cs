using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class platformBehavior : MonoBehaviour {


    float positionx;
    public float speed;
    public float cubePosition;
    public float cubePositionI;

    public GameObject baseD;
    public GameObject baseI;
    public GameObject sphere;

    bool toRight;


    // Use this for initialization
    void Start () {
      toRight = true;
        //cubePosition = transform.position = new Vector3()
        cubePosition = baseD.transform.localPosition.x ;
        cubePositionI = baseI.transform.localPosition.x ;
    }

     void Update()
    {

        if(toRight == true)
        transform.position += new Vector3(speed, 0, 0);
        else {
        transform.position -= new Vector3(speed, 0, 0);
        }

        if (transform.position.x > cubePosition -2 )
        {
            
            toRight = false;
            sphere.transform.position = new Vector3(cubePosition,1,0);
            Instantiate(sphere);
          
        }
        if (transform.position.x < cubePositionI +2 )
        {
            toRight = true;
            sphere.transform.position = new Vector3(cubePositionI, 1, 0);
            Instantiate(sphere);
        }




    }




    /*private void OnTriggerEnter (Collider collision)
    {
     
        if(collision.gameObject.tag == "BaseD")
        {
           Debug.Log("Hola");

        }
         if(platform collider BaseD)
        {
            Instantiate(sphere);
        }
      
	}*/



}
