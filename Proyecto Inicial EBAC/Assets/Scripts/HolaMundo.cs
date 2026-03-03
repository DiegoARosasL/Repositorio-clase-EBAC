using UnityEngine;

public class HolaMundo : MonoBehaviour
{

    int x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 0;
        print("Algo paso");
        
        Debug.LogWarning("Algo Salio Medianamente Mal");
        Debug.LogError("Algo Salio Muy Mal");
    }

    // Update is called once per frame
    void Update()
    {
        x = x + 1;
        Debug.Log("x");
    }
}
