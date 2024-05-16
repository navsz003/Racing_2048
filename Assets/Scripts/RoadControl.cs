using System.Collections;
using System.Collections.Generic;
using System.Threading;
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
        if (Input.GetKeyDown(KeyCode.A) && track != -1)
        {
            track--;
            ani.SetFloat("Horizontal", track);
        }
        else if (Input.GetKeyDown(KeyCode.D) && track != 1)
        {
            track++;
            ani.SetFloat("Horizontal", track);
        }
    }
}
