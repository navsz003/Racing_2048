using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager _isnstance;  //����ģʽ������

    public Transform poolManager;   //�������ֵĳ���
    private GameObject numPrefab;   //���ֵ�Ԥ����
    public Number[,] numbers = new Number[4, 4]; //���淽���е�����
    //�����ƶ��е�Num
    public List<Number> isMovingNum = new List<Number>();
    public bool hasMove = false;   //�Ƿ������ַ������ƶ�

    public GameObject UIFinsh;  //��Ϸ����ҳ��

    void Awake()
    {
        _isnstance = this;
    }

    void Start()
    {
        numPrefab = Resources.Load<GameObject>("Num");
        // ��ʼ��Ϸ
        ReStartBtn();
        // ��Ϸ������尴ť���������¿�ʼ
       // UIFinsh.GetComponentInChildren<Button>().onClick.AddListener(ReStartBtn);
    }

    // ���¿�ʼ
    void ReStartBtn()
    {
        isMovingNum.Clear();
        numbers = new Number[4, 4];
        for (int i = poolManager.childCount - 1; i >= 0; i--)
        {
            Destroy(poolManager.GetChild(i).gameObject);
        }
        hasMove = false;
        //��Ϸ��ʼ������������
        CreateNun();
        CreateNun();
        UIFinsh.SetActive(false);
    }

    void CreateNun()
    {
        GameObject go = Instantiate(numPrefab);
        go.transform.parent = poolManager;
        go.transform.localScale = Vector3.one;
    }

    #region ����������
    void Update()
    {
        //--------- PC�˼���߼� ---------
        if (isMovingNum.Count == 0)
        {
            int dieX = 0;
            int dieY = 0;
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                dieX = -1;
            }
            else
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                dieX = 1;
            }
            else
            if ( Input.GetKeyDown(KeyCode.UpArrow))
            {
                dieY = 1;
            }
            else
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                dieY = -1;
            }
            MoveNum(dieX, dieY);
        }

        if (hasMove && isMovingNum.Count == 0)   //�����µ�����
        {
            CreateNun();
            hasMove = false;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (numbers[i, j] != null)
                    {
                        numbers[i, j].OneMove = false;
                    }
                }
            }
        }
    }
    #endregion

    #region ��Ϸ�߼�
    /// <summary>
    /// �����ƶ�����
    /// </summary>
    /// <param name="directionX"></param>
    /// <param name="directionY"></param>
    public void MoveNum(int directionX, int directionY)
    {
        if (directionX == 1)  //�����ƶ�  
        {
            //���Ƚ��ո�����   ���Ҳ��в������ж�
            for (int j = 0; j < 4; j++)
            {
                for (int i = 2; i >= 0; i--)
                {
                    if (numbers[i, j] != null)  //�����������壨���֣����������ƶ�����
                    {
                        numbers[i, j].Move(directionX, directionY);
                    }
                }
            }
        }
        else

        //===========�����ƶ�==================
        if (directionX == -1)
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 1; i < 4; i++)
                {   //������һ�� [0,0] [0,1] [0,2] [0,3]
                    if (numbers[i, j] != null)
                    {
                        numbers[i, j].Move(directionX, directionY);
                    }
                }
            }
        }
        else

        //===========�����ƶ�==================
        if (directionY == 1)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j >= 0; j--)
                {
                    if (numbers[i, j] != null)
                    {
                        numbers[i, j].Move(directionX, directionY);
                    }
                }
            }
        }
        else

        //===========�����ƶ�==================
        if (directionY == -1)
        {
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (numbers[i, j] != null)  //�����壨���֣����ƶ�
                    {
                        numbers[i, j].Move(directionX, directionY);
                    }
                }
            }
        }
    }


    /// <summary>
    /// �ж��Ƿ��ǿո�ķ���
    /// </summary>
    /// <param name="x">��������X</param>
    /// <param name="y">��������Y</param>
    /// <returns></returns>
    public bool isEmpty(int x, int y)
    {
        if (x < 0 || x > 3 || y < 0 || y > 3)
        {
            return false;
        }
        else if (numbers[x, y] != null)
        {
            return false;
        }
        return true;
    }

    /// <summary>
    /// �ж���Ϸ�Ƿ����
    /// </summary>
    /// <returns>����true����Ϸ����</returns>
    public bool isDead()
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (numbers[i, j] == null)
                {
                    return false;
                }
            }
        }

        for (int j = 0; j < 4; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i, j].value == numbers[i + 1, j].value)
                {
                    return false;
                }
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (numbers[i, j].value == numbers[i, j + 1].value)
                {
                    return false;
                }
            }
        }
        return true;
    }

    #endregion

    /// <summary>
    /// ��Ϸ����
    /// </summary>
    /// <param name="isSuccess">false:��,true:Ӯ</param>
    public void ShowUIFinsh(bool isSuccess)
    {
        UIFinsh.SetActive(true);
        if (isSuccess)
        {
            ReStartBtn();
        }
        else
        {
            ReStartBtn();
        }
    }
}
