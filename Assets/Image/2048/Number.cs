using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using Vector3 = UnityEngine.Vector3;

public class Number : MonoBehaviour
{
    //�ڶ�ά�����е�λ��X��Y
    public int posX;
    public int posY;

    private float offsetX = -298.25f;      //��ʾƫ��X
    private float offsetY = -296.25f;      //��ʾƫ��Y
    private float space = 197.5F;         // ���

    private bool isMoving = false;   //�����Ƿ񲥷Ź��ļ���
    public int value;                //���������Ǽ�
    private bool toDestroy;          //�ж������Ƿ�����  
    public bool OneMove = false;     //��ʶ�����Ƿ�ϲ���һ��

    // Use this for initialization
    void Start()
    {
        // 80%��2�ĸ��ʣ����ı����Sprite���֣��Ը���ͼƬ
        value = Random.value > 0.2f ? 2 : 4;
        this.GetComponent<Image>().sprite = LoadSprite();
        do
        {
            posX = Random.Range(0, 4);
            posY = Random.Range(0, 4);
        } while (Manager._isnstance.numbers[posX, posY] != null);

        transform.localPosition = GetLocalPos();
        // ������ֱ��������У���ʾ��λ�������ֲ��������µ�����
        Manager._isnstance.numbers[posX, posY] = this;
        if (Manager._isnstance.isDead())
        {
            // ��Ϸʧ��
            Manager._isnstance.ShowUIFinsh(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //����һ�ζ���
        if (!isMoving)
        {
            if (transform.localPosition != GetLocalPos())
            {
                isMoving = true;
                StartCoroutine(MoveAni());
            }
        }
    }

    // �ƶ�����
    IEnumerator MoveAni()
    {
        Debug.Log("�ƶ�����...");
        float t = 0;
        for (int i = 0; i < 10; i++)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, GetLocalPos(), t);
            t += 0.01f;
            yield return new WaitForEndOfFrame();
        }
        // �ƶ������Ļص�
        MoveOver();
    }


    #region ��Ϸ�����ƶ��㷨
    /// <summary>
    /// ���ģ��ƶ��������пո��������Ƿ�һ����
    /// </summary>
    public void Move(int directionX, int directionY)
    {
        //Debug.Log("����");

        //==========�����ƶ�==================  
        if (directionX == 1)
        {
            int index = 1;  // �ո��־
            while (Manager._isnstance.isEmpty(posX + index, posY))
            {
                index++;
            }
            // �пո���ƶ�
            if (index > 1)
            {

                if (!Manager._isnstance.isMovingNum.Contains(this))
                {   // ��֤�����ظ�������壨���֣����б�
                    Manager._isnstance.isMovingNum.Add(this);
                }
                //�ƶ�һ�Σ��������������ֵı�־��
                Manager._isnstance.hasMove = true;
                //��ո�λ���ƶ�
                Manager._isnstance.numbers[posX, posY] = null;
                posX = posX + index - 1;
                Manager._isnstance.numbers[posX, posY] = this;
            }
            //����ͬ���ֵ��ƶ�
            if (posX < 3 && value == Manager._isnstance.numbers[posX + 1, posY].value &&
                !Manager._isnstance.numbers[posX + 1, posY].OneMove)
            {
                // ֻ�ϲ�һ�εı�־
                Manager._isnstance.numbers[posX + 1, posY].OneMove = true;
                // �ƶ��ı�־���������µ����壨���֣���
                Manager._isnstance.hasMove = true;
                // �������ŵ��޶������������б��оͲ����ظ����ŵڶ��ζ����� 
                // �����ظ�������壨���֣����б�
                if (!Manager._isnstance.isMovingNum.Contains(this))
                {
                    Manager._isnstance.isMovingNum.Add(this);
                }
                // ����һ�������֣���λ����Ϊ�� �����ٱ����ʶ��true����
                // �ٽ���λ���ϵ�ֵ��Ϊ2�������������µ����֣�
                toDestroy = true;
                Manager._isnstance.numbers[posX, posY] = null;
                Manager._isnstance.numbers[posX + 1, posY].value *= 2;
                posX += 1;
            }
        }
        else

        //===========�����ƶ�==================
        if (directionX == -1)
        {
            int index = 1;
            while (Manager._isnstance.isEmpty(posX - index, posY))
            {
                index++;
            }
            //�пո���ƶ�
            if (index > 1)
            {
                Manager._isnstance.hasMove = true;
                if (!Manager._isnstance.isMovingNum.Contains(this))
                {
                    Manager._isnstance.isMovingNum.Add(this);
                }

                Manager._isnstance.numbers[posX, posY] = null;
                posX = posX - index + 1;
                Manager._isnstance.numbers[posX, posY] = this;
            }

            //������ͬ���ֵ��ƶ�
            if (posX > 0 && value == Manager._isnstance.numbers[posX - 1, posY].value &&
                !Manager._isnstance.numbers[posX - 1, posY].OneMove)
            {
                Manager._isnstance.numbers[posX - 1, posY].OneMove = true;
                Manager._isnstance.hasMove = true;
                if (!Manager._isnstance.isMovingNum.Contains(this))
                {
                    Manager._isnstance.isMovingNum.Add(this);
                }

                toDestroy = true;
                Manager._isnstance.numbers[posX, posY] = null;
                Manager._isnstance.numbers[posX - 1, posY].value *= 2;
                posX -= 1;
            }

        }
        else

        //===========�����ƶ�==================
        if (directionY == 1)
        {
            int index = 1;   //�ո��־
            while (Manager._isnstance.isEmpty(posX, posY + index))
            {
                index++;
            }
            //�пո���ƶ�
            if (index > 1)
            {
                Manager._isnstance.hasMove = true;
                if (!Manager._isnstance.isMovingNum.Contains(this))
                {
                    Manager._isnstance.isMovingNum.Add(this);
                }

                Manager._isnstance.numbers[posX, posY] = null;
                posY = posY + index - 1;
                Manager._isnstance.numbers[posX, posY] = this;
            }
            //����ͬλ�õ��ƶ�
            if (posY < 3 && value == Manager._isnstance.numbers[posX, posY + 1].value && !Manager._isnstance.numbers[posX, posY + 1].OneMove)
            {
                Manager._isnstance.numbers[posX, posY + 1].OneMove = true;
                Manager._isnstance.hasMove = true;
                if (!Manager._isnstance.isMovingNum.Contains(this))
                {
                    Manager._isnstance.isMovingNum.Add(this);
                }

                toDestroy = true;
                Manager._isnstance.numbers[posX, posY] = null;
                Manager._isnstance.numbers[posX, posY + 1].value *= 2;
                posY += 1;
            }

        }
        else

        //===========�����ƶ�==================
        if (directionY == -1)
        {
            int index = 1;  //�ո��־λ
            while (Manager._isnstance.isEmpty(posX, posY - index))
            {
                index++;
            }
            //�пո���ƶ�
            if (index > 1)
            {
                Manager._isnstance.hasMove = true;
                if (!Manager._isnstance.isMovingNum.Contains(this))
                {
                    Manager._isnstance.isMovingNum.Add(this);
                }

                Manager._isnstance.numbers[posX, posY] = null;
                posY = posY - index + 1;
                Manager._isnstance.numbers[posX, posY] = this;
            }
            //����ͬ���ֵ��ƶ�
            if (posY > 0 && value == Manager._isnstance.numbers[posX, posY - 1].value && !Manager._isnstance.numbers[posX, posY - 1].OneMove)
            {
                Manager._isnstance.numbers[posX, posY - 1].OneMove = true;
                Manager._isnstance.hasMove = true;
                if (!Manager._isnstance.isMovingNum.Contains(this))
                {
                    Manager._isnstance.isMovingNum.Add(this);
                }

                toDestroy = true;
                Manager._isnstance.numbers[posX, posY] = null;
                Manager._isnstance.numbers[posX, posY - 1].value *= 2;
                posY -= 1;
            }
        }
    }

    #endregion

    /// <summary>
    /// ������������־��Ϊfalse
    /// </summary>
    public void MoveOver()
    {
        isMoving = false;
        //����������ͬ������  �����Լ����͸ı���һ��ͼƬ�����֣�
        if (toDestroy)
        {
            Destroy(this.gameObject);
            value = Manager._isnstance.numbers[posX, posY].value;
            Manager._isnstance.numbers[posX, posY].GetComponent<Image>().sprite = LoadSprite();
            //��Ϸ�ɹ�
            if (value == 4096)
            {
                Manager._isnstance.ShowUIFinsh(true);
            }
        }
        Manager._isnstance.isMovingNum.Remove(this);
    }

    Vector3 GetLocalPos()
    {
        return new Vector3(offsetX + posX * space, offsetY + posY * space, 0);
    }

    /// <summary>
    /// �������ּ��ض�ӦͼƬ
    /// </summary>
    /// <returns></returns>
    Sprite LoadSprite()
    {
        return Resources.Load<Sprite>(value.ToString());
    }
}
