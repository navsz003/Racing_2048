using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContachControl : MonoBehaviour
{

    private Animator ani;
    private Rigidbody2D rBody;

    void Start()
    {
        ani = GetComponent<Animator>();
        rBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        ani.SetFloat("Horizontal", horizontal);
        
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
