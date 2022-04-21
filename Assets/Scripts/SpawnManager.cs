using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    float time;
    float healthTime;
    PlayerMovement PlayerMovement;
    // Start is called before the first frame update
    void Start()
    {
        PlayerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerMovement.isGameOver)
        {
            time = time + Time.deltaTime;
            if (time > 3f)
            {
                // GameObject temp=Instantiate(ObjectPoolScript.instance.GetObjectsFromPool("Asteroid"),new Vector3(Random.Range(-8.0f, 8f),4f,0f),Quaternion.identity);
                GameObject tempAsteroid = (PoolScript.instance.GetObjectsFromPool("Asteroid"));

                tempAsteroid.transform.position = new Vector3(Random.Range(-8.0f, 8f), 4f, 0f);
                tempAsteroid.SetActive(true);

                time = 0;
                /* if (temp != null)
                 {
                     this.transform.position = temp.transform.position+new Vector3(Random.Range(-8.0f, 8f), 4f, 0f);
                     temp.SetActive(true);
                     time = 0;
                 }*/
            }
            healthTime = healthTime + Time.deltaTime;
            if (healthTime > 5f)
            {
                GameObject tempHealth = (PoolScript.instance.GetObjectsFromPool("Health"));
                tempHealth.transform.position = new Vector3(Random.Range(-8.0f, 8f), 4f, 0f);
                tempHealth.SetActive(true);
                healthTime = 0;
            }
        }


    }
}
