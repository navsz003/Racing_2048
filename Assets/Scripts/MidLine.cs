using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{

    public class MidLine : MonoBehaviour
    {
        Vector3 addSize = RacingConstant.addSize;
        private DateTime startT = DateTime.Now;
        private DateTime nowT = DateTime.Now;
        TimeSpan lifeT = RacingConstant.lifeT;
        private float ySpeed = -1f;
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // ͼƬ�ƶ�
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, ySpeed);
            ySpeed -= 0.02f;

            // ͼƬ�Ŵ�
            transform.localScale += addSize;

            nowT = DateTime.Now;
            // ��ʱ��������
            if (nowT - startT >= lifeT)
                GameObject.Destroy(gameObject);

        }
    }
}