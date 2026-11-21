using UnityEngine;
using System.Collections.Generic;

public class Gato : MonoBehaviour
{
    public string nombre;
    [SerializeField] private int caos;
    private List<ObjetoFragil> objetosTirados = new List<ObjetoFragil>();
    private List<ObjetoFragil> objetosEnLaMesa;

    private void Awake()
    {
        objetosEnLaMesa = new List<ObjetoFragil>(FindObjectsByType<ObjetoFragil>());
    }

    public ObjetoFragil EmpujarObjetoAlAzar()
    {
        if (objetosEnLaMesa.Count == 0) return null;

        ObjetoFragil objeto = objetosEnLaMesa[Random.Range(0, objetosEnLaMesa.Count)];
        objeto.Caer();
        objetosEnLaMesa.Remove(objeto);
        objetosTirados.Add(objeto);
        caos++;
        Debug.Log(nombre + " ha empujado " + objeto.nombre + ". Nivel de caos: " + caos);
        return objeto;
    }

    public void MostrarTrofeos()
    {
        Debug.Log(nombre + " ha tirado los siguientes objetos:");
        foreach (ObjetoFragil objeto in objetosTirados)
            Debug.Log(objeto.nombre);
    }
}
