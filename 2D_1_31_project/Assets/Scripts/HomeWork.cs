using UnityEngine;
using UnityEngine.UI;

public class HomeWork : MonoBehaviour
{
    public GameObject arrow;
    public Transform arrow_transform;
    public float shoot_speed;

    void LookAt()
    {
        Vector2 mouse_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = new Vector2(mouse_position.x-arrow_transform.position.x, mouse_position.y - arrow_transform.position.y);
        arrow_transform.right = dir;
    }

    void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //GameObject go = Ins
        }
    }
}
