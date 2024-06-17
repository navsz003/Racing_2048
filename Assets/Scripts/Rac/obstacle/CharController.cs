// CharController�ű�����
using UnityEngine;

public class CharController : MonoBehaviour
{    // ...
    public int maxHealth = 5;     // �������ֵ
    int currentHealth;            // ��ǰ����ֵ
    public int CurrentHealth { get => currentHealth; }    // ���Դ��ⲿ���ʣ����޷��޸�
    bool isInvincible;    // �Ƿ��޵�
    float invincibleTimer;    // �޵�ʱ��

    void Start()
    {    // ...
        currentHealth = maxHealth;    // ����ǰ����ǰ����ֵ��Ϊ�������ֵ
    }

    public void ChangeHealth(int amount)
    {
        // ...
        if (amount < 0)
        {
            if (isInvincible)    // �޵�״̬����ʧ����ֵ
                return;
            isInvincible = true;    // ���޵�״̬����ʧ����������Ϊ�޵�״̬
            invincibleTimer = 2; //�ݶ�2�����Ҳ�֪���ж����뻹��֡��
        }
    }

   

    void Updat()
    {
        // ...
        if (isInvincible)
        {
            invincibleTimer -= Time.deltaTime;    // �޵�ʱ�䵹��ʱ
            if (invincibleTimer < 0)
            {
                isInvincible = false;    // ������޵�״̬
            }
        }
    }


}