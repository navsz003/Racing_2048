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
        private TimeSpan lifeT;

        private float xSpeed;
        private float ySpeed;
        private Vector3 addSize;

        private Renderer bRender;

        // Start is called before the first frame update
        void Start()
        {
            InitVar();
        }

        // Update is called once per frame
        void Update()
        {
            // ͼƬ�ƶ�
            GetComponent<Rigidbody2D>().velocity = new Vector2(xSpeed, ySpeed);
            ySpeed *= RacingConstant.mutiY1;

            // ͼƬ�Ŵ�
            transform.localScale += addSize;

            // ��ʱ��������
            nowT = DateTime.Now;
            if (nowT - startT >= lifeT)
                ResetObj();
            
        }

        private void InitVar()
        {
            startPosition = transform.position;
            startScale = transform.localScale;

            xSpeed = 0f;
            ySpeed = RacingConstant.intiYSpeed;
            addSize = RacingConstant.addSize;

            startT = DateTime.Now;
            nowT = DateTime.Now;
            lifeT = RacingConstant.lifeT;

            bRender = GetComponent<Renderer>();
        }

        private void ResetObj()
        {
            transform.position = startPosition;
            transform.localScale = startScale;

            xSpeed = 0f;
            ySpeed = RacingConstant.intiYSpeed;

            startT = DateTime.Now;
            nowT = DateTime.Now;
        }
    }
}