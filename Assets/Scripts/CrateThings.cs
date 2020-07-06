using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateThings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= -12f)
        {
            transform.position = new Vector2(6.9f , 0.01f);
        }
    }
}
