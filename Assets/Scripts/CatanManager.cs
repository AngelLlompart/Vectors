using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatanManager : MonoBehaviour
{
    private float longitudHexHorizontal = 2.56f;
    private float angle = 30;

    [SerializeField]
    private List<GameObject> caselles;

    // Start is called before the first frame update
    void Start()
    {
        float radi = longitudHexHorizontal / 2;
        float h = radi / Mathf.Cos(angle * Mathf.Deg2Rad);
        float longitudHexVertical = h + h/2;
        Instantiate(caselles[0], new Vector2(0,0), Quaternion.identity);
        Instantiate(caselles[1], new Vector2(longitudHexHorizontal, 0), Quaternion.identity);
        Instantiate(caselles[2], new Vector2(-longitudHexHorizontal, 0), Quaternion.identity);
        Instantiate(caselles[3], new Vector2(radi, longitudHexVertical), Quaternion.identity);
        Instantiate(caselles[5], new Vector2(radi, -longitudHexVertical), Quaternion.identity);
        Instantiate(caselles[6], new Vector2(-radi, longitudHexVertical), Quaternion.identity);
        Instantiate(caselles[7], new Vector2(-radi, -longitudHexVertical), Quaternion.identity);
        
        Instantiate(caselles[1], new Vector2((radi + longitudHexHorizontal), longitudHexVertical), Quaternion.identity);
        Instantiate(caselles[2], new Vector2(-(radi + longitudHexHorizontal), longitudHexVertical), Quaternion.identity);
        Instantiate(caselles[1], new Vector2((radi + longitudHexHorizontal), -longitudHexVertical), Quaternion.identity);
        Instantiate(caselles[2], new Vector2(-(radi + longitudHexHorizontal), -longitudHexVertical), Quaternion.identity);
        Instantiate(caselles[3], new Vector2(2*longitudHexHorizontal, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
