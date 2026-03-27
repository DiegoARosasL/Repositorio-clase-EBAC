using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    public int[] ordernarArregloDescendente(int[] arregloOriginal) 
    {
        int[] arregloOrdenado = arregloOriginal.OrderByDescending(n  => n).ToArray();

        return arregloOrdenado;
    }

    public HashSet<string> eliminarRepetidos(List<string> listaOriginal) 
    {
        HashSet<string> conjuntoUnico = new HashSet<string>(listaOriginal);

        return conjuntoUnico;
    }

    public void procesarPilaACola(Stack<string> pila) 
    {
        Queue<string> cola = new Queue<string>();
        Debug.Log("--- PROCESANDO PILA ---");

        while (pila.Count > 0) 
        {
            string elemento = pila.Peek();
            Debug.Log("Viendo el tope de la pila: " + elemento);

            cola.Enqueue(pila.Pop());
            Debug.Log("Pasando a la cola y eliminando de la pila...");
        }

        while (cola.Count > 0) 
        {
            Debug.Log("Siguiente en salir de la cola: " + cola.Peek());
            string sacado = cola.Dequeue();
            Debug.Log("Atendiendo elemento: " + sacado);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        List<int> miLista = miFuncion(5, 1, 10);

        foreach (int numero in miLista) 
        {
            Debug.Log("El numero generado es: " + numero);
        }

        int[] misNumeros = { 5, 12, 8, 20, 3 };

        int[] resultado = ordernarArregloDescendente(misNumeros);

        Debug.Log("Arreglo ordenado: " + string.Join(", ", resultado));

        List<string> listaConTrampa = new List<string> { "Mario", "Zelda", "Metroid", "Zelda", "Pokemon"};

        HashSet<string> miHashset = eliminarRepetidos(listaConTrampa);

        foreach (string saga in miHashset) 
        {
            Debug.Log("Saga unica: " +  saga);
        }

        Stack<string> miPila = new Stack<string>();
        miPila.Push("Primero en entrar (Base)");
        miPila.Push("Segundo en entrar");
        miPila.Push("Tercero en entrar (Tope)");

        procesarPilaACola(miPila);
    }
    public List<int> miFuncion(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> listaNumeros = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            int numeroAleatorio = Random.Range(rangoInferior, rangoSuperior + 1);
            listaNumeros.Add(numeroAleatorio);
        }
        return listaNumeros;
    }

    
    // Update is called once per frame
    void Update()
        {

        }
        
}
