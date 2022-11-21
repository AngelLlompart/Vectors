using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> casellesPreFabs;
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                Instantiate(casellesPreFabs[0], new Vector2(4 * x, 4 * y), Quaternion.identity);
                Instantiate(casellesPreFabs[0], new Vector2(4 * x + 2 , 4 * y + 2), Quaternion.identity);
                Instantiate(casellesPreFabs[1], new Vector2(4 * x + 2, 4 * y), Quaternion.identity);
                Instantiate(casellesPreFabs[1], new Vector2(4 * x , 4 * y + 2), Quaternion.identity);
            } 
        }
       
        //Instantiate(casellesPreFabs[0], new Vector2(0, 0), Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
