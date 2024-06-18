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

        private DateTime startT;
        private DateTime nowT;
        private TimeSpan lifeT;

        private float xSpeed;
        private float ySpeed;
        private Vector3 addSize;

        private Renderer bRenderer;

        // Start is called before the first frame update
        void Start()
        {
            InitVar();
        }

        // Update is called once per frame
        void Update()
        {
            // 控制路障是否显示，是否碰撞
            if (RoadControl.track < 0 && RoadControl.bPos - RoadControl.track == 2)
                bRenderer.enabled = true;
            else
                bRenderer.enabled = false;

            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);
            xSpeed += RacingConstant.addX2;
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

            xSpeed = RacingConstant.initXSpeed2;
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

            xSpeed = RacingConstant.initXSpeed2;
            ySpeed = RacingConstant.intiYSpeed;

            startT = DateTime.Now;
            nowT = DateTime.Now;
        }
    }
}