using UnityEngine;

public class Esfera : MonoBehaviour
{
    public bool variable2;
    private MeshRenderer rendererComponent;
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
        if (variable2)
        {
            rendererComponent.material.color = Color.black;
            Debug.Log("Es Falso(Negro)(2)");
        }
        else
        {
            rendererComponent.material.color = Color.white;
            Debug.Log("Es Verdadero(Blanco)(2)");
        }
    }
 }
