using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        CharController controller = other.GetComponent<CharController>();    // 获取触碰的刚体
        if (controller != null)
        {
            if (controller.CurrentHealth < controller.maxhealth)
            {    // 仅当当前生命值小于最大生命值时执行
                controller.ChangeHealth(1);    // 生命值改变量为+1
                Destroy(gameObject);    // 销毁被触碰的游戏对象
            }
        }
    }
}
