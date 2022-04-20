using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed;
    public GameObject bullet;
    Vector3 offSet;

   // float InputX;
   // float InputY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement;
        movement = Input.GetAxis("Horizontal") * playerSpeed;   //Movement of the player in horizantal direction 
       transform.Translate(0, -movement*Time.deltaTime,0);

        //need to clamp the player

        
        if(Input.GetKey(KeyCode.Space))

        {
            Instantiate(bullet,transform.position+offSet,Quaternion.Euler(0,90,0) );
        }
    }
}
