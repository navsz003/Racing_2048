using Racing;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{

    public class LeftLeftLine : MonoBehaviour
    {
        Vector3 addSize = RacingConstant.addSize;
        private DateTime startT = DateTime.Now;
        private DateTime nowT = DateTime.Now;
        TimeSpan lifeT = RacingConstant.lifeT;
        private float xSpeed = -3f;
        private float ySpeed = -1f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);
            xSpeed -= 0.08f;
            ySpeed -= 0.02f;

            transform.localScale += addSize;

            nowT = DateTime.Now;
            if (nowT - startT >= lifeT)
                GameObject.Destroy(gameObject);
        }
    }
}