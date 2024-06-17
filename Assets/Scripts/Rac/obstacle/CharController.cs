// CharController脚本新增
using UnityEngine;

public class CharController : MonoBehaviour
{    // ...
    public int maxHealth = 5;     // 最大生命值
    int currentHealth;            // 当前生命值
    public int CurrentHealth { get => currentHealth; }    // 可以从外部访问，但无法修改
    bool isInvincible;    // 是否无敌
    float invincibleTimer;    // 无敌时间

    void Start()
    {    // ...
        currentHealth = maxHealth;    // 运行前将当前生命值设为最大生命值
    }

    public void ChangeHealth(int amount)
    {
        // ...
        if (amount < 0)
        {
            if (isInvincible)    // 无敌状态不损失生命值
                return;
            isInvincible = true;    // 非无敌状态，损失生命，重设为无敌状态
            invincibleTimer = 2; //暂定2（但我不知道判定是秒还是帧）
        }
    }

   

    void Updat()
    {
        // ...
        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;    // 无敌时间倒计时
            if (invincibleTimer < 0)
            {
                isInvincible = false;    // 进入非无敌状态
            }
        }
    }


}