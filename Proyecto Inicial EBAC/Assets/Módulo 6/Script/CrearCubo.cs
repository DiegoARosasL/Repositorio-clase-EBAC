using UnityEngine;

public class CrearCubo : MonoBehaviour
{
    public GameObject Cubo;    
    private void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(Cubo);
        tempGameObject.name = "CuboAwake";
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
