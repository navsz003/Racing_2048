using Racing;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{

    public class RightRightLine : MonoBehaviour
    {
        Vector3 addSize = RacingConstant.addSize;
        private DateTime startT = DateTime.Now;
        private DateTime nowT = DateTime.Now;
        TimeSpan lifeT = RacingConstant.lifeT;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            float xSpeed = 3f;
            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, -1);
            xSpeed += 6f;

            transform.localScale += addSize;

            nowT = DateTime.Now;
            if (nowT - startT >= lifeT)
                GameObject.Destroy(gameObject);
        }
    }
}