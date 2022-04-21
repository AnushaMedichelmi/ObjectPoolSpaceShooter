using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public int playerSpeed;
    int playerHealth = 10;
    int maxHealth = 10;
    // public GameObject bulletPrefab;
    public Vector3 offSet;
    public bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
           
        if (!isGameOver)
        {

            float inputX = Input.GetAxis("Horizontal") * playerSpeed;
            transform.Translate(0f, -inputX * Time.deltaTime, 0f);
            //Clamp player position within gameWindow

            if (Input.GetKeyDown(KeyCode.Space))
            {

                GameObject tempBullet = PoolScript.instance.GetObjectsFromPool("Bullet");
                tempBullet.transform.position = this.transform.position + offSet;
                // transform.Translate(0f, 0f, 1f);
                tempBullet.SetActive(true);
                //Instantiate(bulletPrefab, transform.position + offSet, Quaternion.identity);
            }
        }
        if (playerHealth == 0)               //If health of the player is equal to 0
        {
            Destroy(gameObject);             //Destroying the player
            isGameOver = true;
           // print("GameOver");

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")      //player hitting the asteroid
        {
            playerHealth--;                             //decreasing the health of the player
            collision.gameObject.SetActive(false);      
            print("player Health Decreased:" + playerHealth);        //Printing the health of the player
             
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Health" && playerHealth < maxHealth) //player hitting the health
        {
            playerHealth = Mathf.Clamp(playerHealth + 1, 0, maxHealth);  //Increasing health of the player
            collision.gameObject.SetActive(false);                       //Making the health back to pool
            print("player Health increased:" + playerHealth);                   //Printing health of the player
        }
    }
}