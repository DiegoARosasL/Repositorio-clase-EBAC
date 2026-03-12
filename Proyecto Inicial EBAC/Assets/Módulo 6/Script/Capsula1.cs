using UnityEngine;
using UnityEngine.XR;

public class Capsula1 : MonoBehaviour
{
    public bool resultado2;
    private MeshRenderer rendererComponent;
    public GameObject Cubo;
    public GameObject Esfera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rendererComponent = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        //A   B    OR
        //1   1    1
        //1   0    1
        //0   1    1
        //0   0    0
        bool valor1 = Cubo.GetComponent<Cubo>().variable1;
        bool valor2 = Esfera.GetComponent<Esfera>().variable2;

        if (valor1 || valor2)
        {
            rendererComponent.material.color = Color.white;
            Debug.Log("El valor es Positivo(4)");
            
        }
        else
        {
            rendererComponent.material.color = Color.black;
            Debug.Log("El valor es Negativo(4)");
            
        }




    }
}
