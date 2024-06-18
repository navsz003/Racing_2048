using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Racing
{

    public class RoadControl : MonoBehaviour
    {
        private Animator ani;
        public static int track = 0; // �������ڵĳ���
        public static int bPos; // ·�����ڵĳ���

        private DateTime startT = DateTime.Now;
        private DateTime nowT = DateTime.Now;
        private TimeSpan lifeT = RacingConstant.lifeT;
        private System.Random bRan = new System.Random();

        // Start is called before the first frame update
        void Start()
        {
            ani = GetComponent<Animator>();

        }

        // Update is called once per frame
        void Update()
        {
            // ��ʱ����·��λ��
            nowT = DateTime.Now;
            if (nowT - startT >= lifeT)
            {
                bPos = bRan.Next(-1, 2);
                startT = DateTime.Now;
            }

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
}