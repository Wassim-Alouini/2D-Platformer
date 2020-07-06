using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformThings : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(600f, 0f)) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
