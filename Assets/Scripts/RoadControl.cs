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
        float turn = Input.GetAxisRaw("Horizontal");

        switch (turn)
        {
            case 0:
                break;
            case 1:
                if (track != 1) {
                    track++;
                    ani.SetFloat("Horizontal", track);
                    Thread.Sleep(50);
                }
                break;
            case -1:
                if (track != -1)
                {
                    track--;
                    ani.SetFloat("Horizontal", track);
                    Thread.Sleep(50);
                }
                break;
            default:
                break;
        }
    }
}
