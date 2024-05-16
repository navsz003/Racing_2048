using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{

    public class ContachControl : MonoBehaviour
    {

        private Animator ani;
        private Rigidbody2D rBody;
        private float track = RoadControl.track;

        void Start()
        {
            ani = GetComponent<Animator>();
            rBody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            //float horizontal = Input.GetAxisRaw("Horizontal");

            if (Input.GetKeyDown(KeyCode.A) && track != -1)
            {
                track--;
                ani.SetFloat("Horizontal", -1);
            }
            else if (Input.GetKeyDown(KeyCode.D) && track != 1)
            {
                track++;
                ani.SetFloat("Horizontal", 1);
            }
            else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            {
                ani.SetFloat("Horizontal", 0);
            }
            else
            {

            }


        }
    }
}
/*
                     _ooOoo_
                    o8888888o
                    88" . "88
                    (| -_- |)
                     O\ = /O
                 ____/`---'\____
               .   ' \\| |// `.
                / \\||| : |||// \
              / _||||| -:- |||||- \
                | | \\\ - /// | |
              | \_| ''\---/'' | |
               \ .-\__ `-` ___/-. /
            ___`. .' /--.--\ `. . __
         ."" '< `.___\_<|>_/___.' >'"".
        | | : `- \`.;`\ _ /`;.`/ - ` : | |
          \ \ `-. \_ __\ /__ _/ .-` / /
  ======`-.____`-.___\_____/___.-`____.-'======
                    `=---='
 
  .............................................
           ·ð×æ±£ÓÓ             ÓÀÎÞBUG
 */
