using UnityEngine;

public class Esfera : MonoBehaviour
{
    bool variable1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (variable1 == false)
        {
            MeshRenderer Falso = GetComponent<MeshRenderer>();
            Falso.material.color = Color.black;
            Debug.Log("Es Falso(Negro)");
        }
        else
        {
            MeshRenderer Verdadero = GetComponent<MeshRenderer>();
            Verdadero.material.color = Color.white;
            Debug.Log("Es Verdadero(Blanco)");
        }

        variable1 = !variable1;
     }
 }
