using UnityEngine;

[AddComponentMenu("LHS/Sample01")]

public class Bottle : MonoBehaviour
{

    public int count = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            count++;
            Debug.Log("À¸¾Ç!");
        }
        Debug.Log(count);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("getCount.ToString");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
