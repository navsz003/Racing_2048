using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;    // �ƶ��ٶ�
    public bool Vertical;    // �ƶ�����
    public float ChangeTime = 3.0f;    // ��ʱ��
    float timer;
    int direction = 1;    // �ƶ�˳������/����
    Rigidbody2D rigidbody2D;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = ChangeTime;
    }
    void Update()
    {
        timer -= Time.deltaTime;    // ��ʱ
        if (timer <= 0)
        {    // ��ת˳��
            direction = -direction;
            timer = ChangeTime;
        }
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        if (Vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;    // ��ֱ�ƶ�
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;    // ˮƽ�ƶ�
        }
        rigidbody2D.MovePosition(position);
    }
}