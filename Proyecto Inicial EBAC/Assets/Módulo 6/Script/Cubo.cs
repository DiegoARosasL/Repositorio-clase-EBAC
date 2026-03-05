using UnityEditor.SceneManagement;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    private void Awake()
    {
        MeshRenderer prefabCubo = GetComponent<MeshRenderer>();
        Color c = new Color(Random.value, Random.value, Random.value);
        prefabCubo.material.color = c;
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
