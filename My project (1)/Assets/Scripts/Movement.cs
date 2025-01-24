using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
//�÷��̾��� �̵� (������ �ٵ�)
// �ش� ����� ���� �� ��ũ��Ʈ�� ������Ʈ�μ� ����� ��� 
// ������� ������Ʈ�� �䱸�ϰ� �˴ϴ�. 
// 1. �ش� ������Ʈ�� ���� ������Ʈ�� ������ ��쿡�� �ڵ��� ������ ����
// 2. �� ��ũ��Ʈ�� ����� ���¶�� �� ������Ʈ�� ����� ������Ʈ�� ������ �� �����ϴ�.
[AddComponentMenu("LHS/Movement")]
[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    public float speed = 2.0f;
    public int getCount = 0;
    public int jumpCount;
    public String count = "����";
    public double jump_force = 3.5; // double�� 3.0�ڿ� f�� �Ⱦ���. �Ҽ��� 6�ڸ����� ��Ȯ�ϰ� ���.
    public bool is_Jump = false;
    public TextMeshProUGUI textMeshPro;
    public TextMeshProUGUI textMeshPro1;
    private Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();  
        // GetComponent<T> �ش�������Ʈ�� ���� ������ ���. T���� ������Ʈ�� ���¸� �ۼ����ݴϴ�.
        // ������Ʈ�� ���°� �ٸ��ٸ� ���� �߻�
        // �ش絥���Ͱ� �������� ���� ����� null�� ��ȯ�ϰ� �˴ϴ�. 
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }
    private void Move()
    {
        float _x = Input.GetAxisRaw("Horizontal");
        float _y = Input.GetAxisRaw("Vertical");
        // GetAxisRaw('Ű�̸�')�� ��ǲ �Ŵ����� Ű�� �����鼭 Ŭ���� ���� -1,0,1 ��ġ�� ���� ���ɴϴ�. 
        // Horizontal : ���� �̵� a,d Ű�� Ű������ ����, ������ Ű
        // Vertical :  ���� �̵� w,s Ű�� Ű������ ����, �Ʒ��� Ű
        // ���� �ڵ带 ���� ������ ������ ����մϴ�.
        Vector3 _velocty = new Vector3(_x, _y, 0) * speed * Time.deltaTime; // �ӷ� = ���� * �ӵ�;

        transform.position += _velocty;
    }

    private void Jump()
    {
        //����ڰ� Ű���� Space Ű�� �Է��Ѵٸ�
        if (Input.GetKeyDown(KeyCode.Space)) {
            //!�� ������ �ݴ�� ó���ϴ� ��� false
            //������ ����� true�� ��� false
            //������ ����� false�� ��� true
            if (!is_Jump)
            {
                is_Jump = true; // �������·� �����մϴ�.
                rigid.AddForce(Vector3.up * (float)jump_force, ForceMode2D.Impulse);
                // type casting 
                // (Ÿ���̸�) ������ ���� �ش� ������ ������Ÿ������ ����
                // �� ĳ������ ������ ����������
                // �ַ� int => float ���� ���� ����
                // ������ Ÿ���� ���� ȣȯ���� �ʴ� ����� ��� �Ұ�.
            }
           
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ����Ƽ���� ũ�⸦ ���ϴ� ������.
        // a == b ũ�Ⱑ ����.
        // a!= b ũ�Ⱑ �ٸ���.
        // �浹ü�� ���� ������Ʈ�� ���̾ 7�� �������� ũ�Ⱑ ���ٸ�
        if (collision.gameObject.layer == 7) {
            is_Jump = false;
            jumpCount++;
            textMeshPro1.text = jumpCount.ToString() + " �� �پ����ϴ�.";
        }
        Debug.Log("���� ��ҽ��ϴ�.");

        if (collision.gameObject.layer == 8)
        {
            getCount++;
            textMeshPro.text = getCount.ToString() + " �� �Ծ����ϴ�.";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("����!");
            SceneManager.LoadScene(0);
        }
    }







}
