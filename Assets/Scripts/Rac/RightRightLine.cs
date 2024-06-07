using Racing;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{

    public class RightRightLine : MonoBehaviour
    {
        private Vector2 startPosition;
        private Vector2 startScale;

        private DateTime startT = DateTime.Now;
        private DateTime nowT = DateTime.Now;
        TimeSpan lifeT = RacingConstant.lifeT;

        private float xSpeed = RacingConstant.initXSpeed2;
        private float ySpeed = RacingConstant.intiYSpeed;
        Vector3 addSize = RacingConstant.addSize;

        // Start is called before the first frame update
        void Start()
        {
            initVar();
        }

        // Update is called once per frame
        void Update()
        {
            
            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);
            xSpeed += RacingConstant.addX2;
            ySpeed *= RacingConstant.mutiY1;

            transform.localScale += addSize;

            nowT = DateTime.Now;
            if (nowT - startT >= lifeT)
                GameObject.Destroy(gameObject);
        }
        private void initVar()
        {
            startPosition = transform.position;
            startScale = transform.localScale;

            startT = DateTime.Now;
            nowT = DateTime.Now;
            lifeT = RacingConstant.lifeT;

            xSpeed = RacingConstant.initXSpeed1;
            ySpeed = RacingConstant.intiYSpeed;
            addSize = RacingConstant.addSize;
        }
    }
}