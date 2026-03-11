using UnityEngine;

public class Cubo5 : MonoBehaviour
{
    public bool variable1;
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
        //A   B    AND
        //1   1    1
        //0   1    0
        //0   1    0
        //0   0    0


        if (variable1 && variable2)
        {
            rendererComponent.material.color = Color.white;
            Debug.Log("La operacion 1 es Verdadero");
        }
        else if (!variable1 && variable2)
        {
            rendererComponent.material.color = Color.black;
            Debug.Log("La operacion 2 es Falsa");
        }
        else if (!variable1 && variable2)
        {
            rendererComponent.material.color = Color.black;
            Debug.Log("La operacion 3 es Falsa");
        }
        else
        {
            rendererComponent.material.color = Color.black;
            Debug.Log("La operacion 4 es Falsa");
        }


    }
}
