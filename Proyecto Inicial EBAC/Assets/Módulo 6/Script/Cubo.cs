using UnityEditor.SceneManagement;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public bool variable1;
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
        if (variable1)
        {
            rendererComponent.material.color = Color.black;
            Debug.Log("Es Falso(Negro)(1)");
        }
        else
        {
            rendererComponent.material.color = Color.white;
            Debug.Log("Es Verdadero(Blanco)(1)");
        }

        
    }
}
