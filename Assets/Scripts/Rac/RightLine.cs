using Racing;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{

    public class RightLine : MonoBehaviour
    {
        private Vector2 startPosition;
        private Vector2 startScale;

        private DateTime startT = DateTime.Now;
        private DateTime nowT = DateTime.Now;
        private TimeSpan lifeT = RacingConstant.lifeT;

        private float xSpeed = RacingConstant.initXSpeed1;
        private float ySpeed = RacingConstant.intiYSpeed;
        private Vector3 addSize = RacingConstant.addSize;

        private Renderer bRenderer;

        // Start is called before the first frame update
        void Start()
        {
            InitVar();
        }

        // Update is called once per frame
        void Update()
        {
            if (RoadControl.track < 1)
                bRenderer.enabled = true;
            else
                bRenderer.enabled = false;

            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);
            xSpeed += RacingConstant.addX1;
            ySpeed *= RacingConstant.mutiY1;

            transform.localScale += addSize;

            nowT = DateTime.Now;
            if (nowT - startT >= lifeT)
                ResetObj();
        }

        private void InitVar()
        {
            startPosition = transform.position;
            startScale = transform.localScale;

            xSpeed = RacingConstant.initXSpeed1;
            ySpeed = RacingConstant.intiYSpeed;
            addSize = RacingConstant.addSize;

            startT = DateTime.Now;
            nowT = DateTime.Now;
            lifeT = RacingConstant.lifeT;

            bRenderer = GetComponent<Renderer>();
        }
        private void ResetObj()
        {
            transform.position = startPosition;
            transform.localScale = startScale;

            xSpeed = RacingConstant.initXSpeed1;
            ySpeed = RacingConstant.intiYSpeed;

            startT = DateTime.Now;
            nowT = DateTime.Now;
        }
    }
}