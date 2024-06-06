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
            // 图片移动
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, ySpeed);
            ySpeed -= 0.02f;

            // 图片放大
            transform.localScale += addSize;

            nowT = DateTime.Now;
            // 定时消除对象
            if (nowT - startT >= lifeT)
                GameObject.Destroy(gameObject);

        }
    }
}