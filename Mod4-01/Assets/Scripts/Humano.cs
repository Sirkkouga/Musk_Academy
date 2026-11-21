using UnityEngine;

public class Humano : MonoBehaviour
{
    public string nombre;
    [SerializeField] private int paciencia = 100;
    private Gato gato;

    private void Start()
    {
        gato = FindAnyObjectByType<Gato>();

        bool quedanObjetos = true;
        while (quedanObjetos && paciencia > 0)
            quedanObjetos = VerComoTira();

        if (paciencia <= 0)
            Debug.Log(nombre + " ha perdido toda la paciencia.");

        gato.MostrarTrofeos();
    }

    private bool VerComoTira()
    {
        ObjetoFragil objetoTirado = gato.EmpujarObjetoAlAzar();
        if (objetoTirado == null)
            return false;

        BajarPaciencia(objetoTirado.valorSentimental);
        return true;
    }

    private void BajarPaciencia(int cantidad)
    {
        paciencia -= cantidad;
        Debug.Log(nombre + " ha perdido paciencia. Nivel de paciencia: " + paciencia);
    }
}
