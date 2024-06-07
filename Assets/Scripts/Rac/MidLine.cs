using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{

    public class MidLine : MonoBehaviour
    {
        private Vector2 startPosition;
        private Vector2 startScale;

        private DateTime startT;
        private DateTime nowT;
        TimeSpan lifeT;

        private float xSpeed;
        private float ySpeed;
        Vector3 addSize;

        // Start is called before the first frame update
        void Start()
        {
            initVar();
        }

        // Update is called once per frame
        void Update()
        {
            // 图片移动
            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);
            ySpeed *= RacingConstant.mutiY1;

            // 图片放大
            transform.localScale += addSize;

            // 定时消除对象
            nowT = DateTime.Now;
            if (nowT - startT >= lifeT)
            {
                GameObject.Destroy(gameObject);
                //ResetObj();
            }
        }

        private void initVar()
        {
            startPosition = transform.position;
            startScale = transform.localScale;

            startT = DateTime.Now;
            nowT = DateTime.Now;
            lifeT = RacingConstant.lifeT;

            xSpeed = 0f;
            ySpeed = RacingConstant.intiYSpeed;
            addSize = RacingConstant.addSize;
        }

        // TODO
        private void ResetObj()
        {
            transform.position = startPosition;
            transform.localScale = startScale;

            startT = DateTime.Now;
            nowT = DateTime.Now;
        }
    }
}