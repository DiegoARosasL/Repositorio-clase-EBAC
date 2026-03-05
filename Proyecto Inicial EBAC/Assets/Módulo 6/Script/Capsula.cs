using UnityEngine;

public class Capsula : MonoBehaviour
{
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
        MeshRenderer prefabEsfera = GetComponent<MeshRenderer>();
        Color c = new Color(Random.value, Random.value, Random.value);
        prefabEsfera.material.color = c;
    }
}
