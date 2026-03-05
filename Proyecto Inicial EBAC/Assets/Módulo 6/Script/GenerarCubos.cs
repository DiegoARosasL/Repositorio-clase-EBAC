using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class GenerarCubos : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listaDeCubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
