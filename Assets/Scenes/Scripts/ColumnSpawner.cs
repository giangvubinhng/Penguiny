using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    private Penguin myPenguin;
    public GameObject columnPrefab;
    float timer;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        myPenguin = GameObject.Find("Penguiny").GetComponent<Penguin>();

        if (!myPenguin.isPaused)
        {
            SpawnColumn();
        }
        

        
           
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!myPenguin.isPaused)
        {
            timer += Time.deltaTime;
            if (timer >= maxTime)
            {
                SpawnColumn();
                timer = 0;
            }
        }

        
        
        
    }
    void SpawnColumn()
    {
     
       
       GameObject newColumn = Instantiate(columnPrefab);
       newColumn.transform.position = new Vector2(transform.position.x, transform.position.y);

    }
}
