using UnityEngine;

//----------------------------------------碰撞伤害判定---------------------------------------------
/* 未被调用，游戏无法执行
void OnCollisionEnter2D(Collision2D other)    // 参数类型为Collison2D
{
    CharController player = other.gameObject.GetComponent<CharController>();
    if (player != null)
    {
        player.ChangeHealth(-1);
    }
}
*/