using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{

    // Start is called before the first frame update

    public int bulletSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // transform.Translate(Vector3.left*Time.deltaTime );
        transform.Translate(-bulletSpeed * Time.deltaTime, 0f, 0f);

    }
}
