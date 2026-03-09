using UnityEngine;

public class CrearCuboOn : MonoBehaviour
{
    public GameObject Cubo;
    private void OnEnable()
    {
        GameObject tempGameObject = Instantiate<GameObject>(Cubo);
        tempGameObject.name = "CuboOnEnable";
        tempGameObject.AddComponent<Rigidbody>();
        Debug.Log("El Cubo esta Activo");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        Debug.Log("El Cubo se Desactivo");
    }
}
