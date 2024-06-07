using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadControl : MonoBehaviour
{
    private Animator ani;
    private float track = 0f;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        switch (horizontal)
        {
            case 0:
                break;
            case 1:
                if(track != 1)
                    track++;
                break;
            case -1:
                if(track != -1) 
                    track--;
                break;
            default:
                break;
        }
        
        ani.SetFloat("Horizontal", track);
    }
}
