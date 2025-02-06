using System;
using UnityEngine;
using TMPro;

public class ObjectGenerator : MonoBehaviour
{
    //1. �� Ŭ������ ������Ʈ�� �����ϴ� ����� ������ �ִ�.
    //2. ���콺 ��ư�� ��������, ī�޶��� ��ũ�� ������ ����
    // ��ü�� ������ �����մϴ�.
    //3. ��ü�� ���⿡ ����  �߻��ϴ� ����� ȣ���� ���ڽ��ϴ�.
    public GameObject prefab;
    GameObject scoreText; //����ǥ��ǥ
    public float power = 1000f; //��ô���ݷ�
    public int score = 0; //����
    public TextMeshProUGUI textMeshPro;
    public TextMeshProUGUI pigkill;
    public Material skyboxmaterial;
    private GameObject gun;

    void Start()
    {
        gun = GameObject.Find("Gun");
    }


    public void ScorePlus(int value)
    {
        score += value;
        SetScoreText();
    }
    private void SetScoreText()
    {
        //scoreText.GetComponent<TextMeshPro>().text = $"���� : {score}";
        textMeshPro.text = $"���� : {score}";
    }

    public void PigKilling() {
        pigkill.text = "������Ҵ�! �����!";
        RenderSettings.skybox = skyboxmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        //~down : Ŭ���� 1��
        //~up : ��ū�� �������� 1��
        // : Ŭ���ϰ� �ִ� ���� ����
        //���콺 0����ư�� ��������(0:����, 1:������, 2:��)
        if (Input.GetMouseButtonDown(0))
        {
            var thrown = Instantiate(prefab) as GameObject;
            //as GameObject�� Instantiate�� ���� ����ϸ� ���ӿ�����Ʈ�μ� �����϶�� �ǹ�.
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //����(Ray)
            //������ ������ ������, �߻�Ǵ� ���� ������ ������ ������ �ֽ��ϴ�. 
            // �Ϲ����� Ray�� Vector3�� ���� ������, Ray2D�� ���� Vector2�� ���� ������ �˴ϴ�.
            //Vector3 origin = new Vector3(0, 0, 0);
            //Vector3 vect_dir = Vector3.forward;
            //Ray newRay = new Ray(origin, vect_dir);
            
            
            
            
            Vector3 direction = ray.direction;
            thrown.GetComponent<ObjectShooter>().Shoot(direction.normalized * power);
            gun.transform.Rotate(direction.normalized * power - transform.position );
        }
    }
}
