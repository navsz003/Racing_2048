using UnityEngine;

//----------------------------------------��ײ�˺��ж�---------------------------------------------
void OnCollisionEnter2D(Collision2D other)    // ��������ΪCollison2D
{
    CharController player = other.gameObject.GetComponent<CharController>();
    if (player != null)
    {
        player.ChangeHealth(-1);
    }
}