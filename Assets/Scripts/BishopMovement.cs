using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BishopMovement : MonoBehaviour
{
    public List<GameObject> possibleMovements;

    [SerializeField]
    public GameObject possible;
    // Start is called before theirst frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 14)
        {
            transform.Translate(new Vector3(2,0,0));
        }
        
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > 0)
        {
            transform.Translate(new Vector3(-2,0,0));
        }
        
        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < 13.5)
        {
            transform.Translate(new Vector3(0,2,0));
        }
        
        if (Input.GetKeyDown(KeyCode.S) && transform.position.y > -0.5)
        {
            transform.Translate(new Vector3(0,-2,0));
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //possibleMovements.Add(Instantiate(possibleMovements[0], new Vector2(x, 0), Quaternion.identity);

            int y = (int)(transform.position.y + 0.5) - 2;
            for (int x = ((int) transform.position.x - 2); x >= 0 && y >= 0; x-=2, y-=2)
            { 
                possibleMovements.Add(Instantiate(possible, new Vector2(x, y), Quaternion.identity));
            } 
            y = (int)(transform.position.y + 0.5) - 2;
            for (int x = ((int) transform.position.x + 2); x <= 14 && y >= 0; x+=2, y-=2)
            { 
                possibleMovements.Add(Instantiate(possible, new Vector2(x, y), Quaternion.identity));
            }
           /* for (int x = ((int) transform.position.x - 2); x >= 0 && y >= 0; x-=2, y-=2)
            { 
                possibleMovements.Add(Instantiate(possible, new Vector2(x, y), Quaternion.identity));
            }
            for (int x = ((int) transform.position.x - 2); x >= 0 && y >= 0; x-=2, y-=2)
            { 
                possibleMovements.Add(Instantiate(possible, new Vector2(x, y), Quaternion.identity));
            }*/
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            for (int i = 0; i < possibleMovements.Count; i++)
            {
                Destroy(possibleMovements[i]);
            }
        }
    }
}
