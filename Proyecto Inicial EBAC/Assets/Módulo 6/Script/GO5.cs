using UnityEngine;

public class GO5 : MonoBehaviour
{
    private MeshRenderer rendererComponent;
    public GameObject Capsula;
    public GameObject Capsula1;

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

        bool res1 = Capsula.GetComponent<Capsula>().resultado1;
        bool res2 = Capsula1.GetComponent<Capsula1>().resultado2;

        if (res1 && res2)
        {
            rendererComponent.material.color = Color.white;
            Debug.Log("El valor es Positivo(5)");
        }
        else
        {
            rendererComponent.material.color = Color.black;
            Debug.Log("El valor es Negativo(5)");
        }


    }
}
