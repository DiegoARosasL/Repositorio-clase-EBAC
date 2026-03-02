using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Algo paso");
        Debug.Log("Algo paso");
        Debug.LogWarning("Algo Salio Medianamente Mal");
        Debug.LogError("Algo Salio Muy Mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
