using UnityEngine;

public class VariablesCharyString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char c = '6';
        int valorEntero =0;
        if (!int.TryParse(c.ToString(), out valorEntero)) 
        {
            Debug.LogError("eso no es un tipo de dato valido");
        }
        Debug.Log(valorEntero);

        char miCaracter;
        string miString = "Hola desde EBAC";
        string miSegundoString = miString.ToUpper();
        string tercerString = miString + " " + miSegundoString;
        string ejemploEscape = "C:\\Users\nDiego\\Documentos";
        miCaracter = miString[13];
        string miNombre = "Diego";
        string misApellidos = "Rosas López";
        string primerApellido = misApellidos.Substring(0, 5);
        string salidasuma = "mi nombre es: " + miNombre + " y mis apellidos son " + misApellidos;
        string salida = $"Mi Nombre es: {miNombre} Y mis Apellidos son {misApellidos}";
        int longitud = miString.Length;
        Debug.Log(salida);
        Debug.Log(primerApellido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
