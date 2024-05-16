using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Racing
{

    public class RoadControl : MonoBehaviour
    {
        private Animator ani;
        public static float track = 0f;

<<<<<<< HEAD
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
=======
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
>>>>>>> 91b48f77e5723ce7ec946203115ac0b9bc1821bb
        }
    }
}