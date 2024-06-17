using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        CharController controller = other.GetComponent<CharController>();    // ��ȡ�����ĸ���
        if (controller != null)
        {
            if (controller.CurrentHealth < controller.maxhealth)
            {    // ������ǰ����ֵС���������ֵʱִ��
                controller.ChangeHealth(1);    // ����ֵ�ı���Ϊ+1
                Destroy(gameObject);    // ���ٱ���������Ϸ����
            }
        }
    }
}
