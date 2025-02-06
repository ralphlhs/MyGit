using System;
using UnityEngine;
using TMPro;

public class ObjectGenerator : MonoBehaviour
{
    //1. 이 클래스는 오브젝트를 생성하는 기능을 가지고 있다.
    //2. 마우스 버튼을 눌렀을때, 카메라의 스크린 지점을 통해
    // 물체의 방향을 설정합니다.
    //3. 물체를 방향에 맞춰  발사하는 기능을 호출해 오겠습니다.
    public GameObject prefab;
    GameObject scoreText; //점수표시표
    public float power = 1000f; //투척공격력
    public int score = 0; //점수
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
        //scoreText.GetComponent<TextMeshPro>().text = $"점수 : {score}";
        textMeshPro.text = $"점수 : {score}";
    }

    public void PigKilling() {
        pigkill.text = "돼지잡았다! 밤샜다!";
        RenderSettings.skybox = skyboxmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        //~down : 클릭시 1번
        //~up : 버큰을 놓았을때 1번
        // : 클릭하고 있는 동안 지속
        //마우스 0번버튼을 눌렀을때(0:왼쪽, 1:오른쪽, 2:휠)
        if (Input.GetMouseButtonDown(0))
        {
            var thrown = Instantiate(prefab) as GameObject;
            //as GameObject는 Instantiate와 같이 사용하면 게임오브젝트로서 생성하라는 의미.
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //레이(Ray)
            //가상의 레이저 선으로, 발사되는 시작 지점과 방향을 가지고 있습니다. 
            // 일반적인 Ray는 Vector3의 값을 가지고, Ray2D의 경우는 Vector2의 값을 가지게 됩니다.
            //Vector3 origin = new Vector3(0, 0, 0);
            //Vector3 vect_dir = Vector3.forward;
            //Ray newRay = new Ray(origin, vect_dir);
            
            
            
            
            Vector3 direction = ray.direction;
            thrown.GetComponent<ObjectShooter>().Shoot(direction.normalized * power);
            gun.transform.Rotate(direction.normalized * power - transform.position );
        }
    }
}
