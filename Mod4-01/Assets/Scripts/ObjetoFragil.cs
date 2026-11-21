using UnityEngine;

public class ObjetoFragil : MonoBehaviour
{
    public string nombre;
    public int valorSentimental;
    private bool estaRoto;

    public void Caer()
    {
        if (!estaRoto)
        {
            estaRoto = true;
            Debug.Log(nombre + " se ha roto.");
        }
    }
}
