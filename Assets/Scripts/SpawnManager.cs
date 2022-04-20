using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject Asteroid;
    // Start is called before the first frame update
    void Start()
    {
        //asteroid = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 100) < 3f)
        {

           
            //float X = Random.Range(-3.0f, 3.0f);
           
           GameObject temp=PoolScript.instance.GetObjectsFromPool("Bullet");
            temp.SetActive(true);

        }
    }
}
