using System.Net.Http.Headers;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    private MeshRenderer rendererComponent;
    string res2;
    int miInt = 0;
    int miInt2 = 0;
    float mifloat1 = 0.2f;
    float float1 = 2.25f;
    float float2 = 3.70f;
    float float3 = 12.1826f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rendererComponent = GetComponent<MeshRenderer>();
        string numdecimal = float3.ToString();
        Debug.Log("El numero en decimales es: " + numdecimal);
        string nombrecompleto = "Diego Alberto Rosas López";
        string nombres = nombrecompleto.Substring(0, 13);
        string apellidoP = nombrecompleto.Substring(14, 5);
        string apellidoM = nombrecompleto.Substring(20, 5);
        Debug.Log("Mis nombres son: " + nombres);
        Debug.Log("Mi apellido Paterno es: " + apellidoP);
        Debug.Log("Mi apellido Materno es: " + apellidoM);
        string[] nomseparado = nombrecompleto.Split(' ');
        string nombres2 = nomseparado[0] + " " + nomseparado[1];
        string apellidoP2 = nomseparado[2];
        string apellidoM2 = nomseparado[3];
        Debug.Log("(2)Mis nombres son: " + nombres2);
        Debug.Log("(2)Mi apellido Paterno es: " + apellidoP2);
        Debug.Log("(2)Mi apellido Materno es: " + apellidoM2);

        string valor1 = "4326.72";
        string valor2 = "1482.39";
        float numero1, numero2;
        bool res1 = float.TryParse(valor1, out numero1);
        bool res2 = float.TryParse(valor2, out numero2);

        if (res1 && res2) 
        {
            float suma = numero1 + numero2;
            Debug.Log("La suma de los miles es: " + suma);
        }
        else 
        {
            Debug.Log("Error: Uno de los textos no es un nunmero valido");
        }

        string oracion = "Inserte frase ingeniosa aqui";
        for (int i = 0; i < oracion.Length; i++) 
        {
            if(i %  2 == 0) 
            {
                Debug.Log("Par [" + i + "]: " + oracion[i]);
            }
        }

        string oracion2 = "Corpse Party";
        string recorte = oracion2.Substring(5);
        Debug.Log("Original: " + oracion2);
        Debug.Log("Recortada: " + recorte);
    }

    // Update is called once per frame
    void Update()
    {
        miInt++;
        Debug.Log("El numero entero es: " + miInt);
        
        int resultado1 = (int)((int)float1 + float2);
        Debug.Log("El resultado de las 2 flotantes es " + resultado1);
    }
    private void FixedUpdate()
    {
        miInt2++;
        
        mifloat1 *= 2.5f;
        Debug.Log("El numero flotante es: " + mifloat1);
        
        if (miInt2 % 2 == 0) 
        {
            rendererComponent.material.color = Color.white;
            Debug.Log("El numero: " + miInt2 + " Es Par(Blanco)");
            res2 = "Par";
        }
        else 
        {
            rendererComponent.material.color = Color.black;
            Debug.Log("El numero: " + miInt2 + " es Impar(Negro)");
            res2 = "Impar";
        }
        switch (res2) 
        {
            case "Par":
                rendererComponent.material.color = Color.white;
                Debug.Log($"Es {res2}: Blanco");
                break;
            case "Impar":
                rendererComponent.material.color = Color.black;
                Debug.Log($"Es {res2}: Negro");
                break;
        }

        
        
        
    }
}
