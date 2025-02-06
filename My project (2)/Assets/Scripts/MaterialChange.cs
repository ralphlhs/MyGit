using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    public Material skyboxmaterial;
    //public Material woodboxmaterial;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RenderSettings.skybox = skyboxmaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
