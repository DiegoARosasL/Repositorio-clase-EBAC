using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arreglouni1 = new int[4];
        int[] arreglouni2 = new int[5];
        int[] arregloresul = new int[4];

        for (int i = 0; i < 4; i++) 
        {
            arreglouni1[i] = Random.Range(1, 15);
            arreglouni2[i] = Random.Range(1, 15);

            arregloresul[i] = arreglouni1[i] + arreglouni2[i];

            Debug.Log($"La suma {i} es: {arreglouni1[i]} + {arreglouni2[i]} = {arregloresul[i]}");
        }

        string[] oraciones = { "Ya", "quiero", "que", "llege", "mi", "copia", "de", "RE9." };
        string oracioncompleta = "";
        foreach(string oracion in oraciones) 
        {
            oracioncompleta += oracion + " ";
        }
        Debug.Log(oracioncompleta.Trim());


        int[,] matriz = new int[2, 3] 
        {
            {1, 2, 3 },
            {4, 5, 6 }
        };
        int[] vector = new int[3] { 10, 20, 30 };

        int[] resultado = new int[2];

        for (int i = 0; i < 2; i++) 
        {
            int suma = 0;
            for (int j = 0; j < 3; j++) 
            {
                suma += matriz[i, j] * vector[j];
            }
            resultado[i] = suma;
        }
        Debug.Log("El resultado del renglon 1 es: " + resultado[0]);
        Debug.Log("El resultado del renglon 2 es: " + resultado[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
