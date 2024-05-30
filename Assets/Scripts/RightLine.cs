using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = 1.5f;
        GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, -1);
        xSpeed+=1f;
    }
}
