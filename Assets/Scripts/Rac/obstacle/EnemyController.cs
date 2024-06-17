using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;    // 移动速度
    public bool Vertical;    // 移动方向
    public float ChangeTime = 3.0f;    // 定时器
    float timer;
    int direction = 1;    // 移动顺序（正向/反向）
    Rigidbody2D rigidbody2D;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = ChangeTime;
    }
    void Update()
    {
        timer -= Time.deltaTime;    // 计时
        if (timer <= 0)
        {    // 逆转顺序
            direction = -direction;
            timer = ChangeTime;
        }
    }
    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        if (Vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;    // 垂直移动
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;    // 水平移动
        }
        rigidbody2D.MovePosition(position);
    }
}