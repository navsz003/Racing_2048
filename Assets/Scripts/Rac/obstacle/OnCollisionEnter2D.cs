using UnityEngine;

//----------------------------------------碰撞伤害判定---------------------------------------------
void OnCollisionEnter2D(Collision2D other)    // 参数类型为Collison2D
{
    CharController player = other.gameObject.GetComponent<CharController>();
    if (player != null)
    {
        player.ChangeHealth(-1);
    }
}