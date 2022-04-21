using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolScript : MonoBehaviour
{


    // private static PoolScript instance;
    public static PoolScript instance;
    public List<GameObject> pools = new List<GameObject>();
    public List<PoolObject> poolObjects = new List<PoolObject>();


    // Start is called before the first frame update
    void Start()
    {
        AddToPool();
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        return;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void AddToPool()
    {
        foreach (PoolObject item in poolObjects)
        {
            for (int i = 0; i < item.amount; i++)
            {
                GameObject temp = Instantiate(item.prefab);
                temp.SetActive(false);
                pools.Add(temp);
            }
        }
    }


    public GameObject GetObjectsFromPool(string tagname)
    {
        for(int i = 0;i < pools.Count;i++ && pools[i].gameObject.activeInHierarchy)
        {
            if (tagname == "Asteroid")
            {
               if(pools[i].gameObject.tag==tagname)
                {
                    return pools[i];
                }

               
            }
        }
        return null;
        foreach(PoolObject item in poolObjects)
        {
            if(item.prefab.tag==tagname)
            {
                GameObject temp=Instantiate(item.prefab);
                temp.SetActive(false);
                pools.Add(temp);
                return temp;
            }
        }
    }
}
[System.Serializable]
public class PoolObject
{
    public GameObject prefab;
    public int amount;

   
}
