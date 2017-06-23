using UnityEngine;
using System.Collections;

public class BDController : MonoBehaviour
{
    public Colleccion coleccion;

    void Update()
    {
        if (coleccion == Colleccion.Infusiones)
            Debug.Log("infusiones");

        if (coleccion == Colleccion.Plantas)
            Debug.Log("Plantas");

        if (coleccion == Colleccion.Recetas)
            Debug.Log("Recetas");

        if (coleccion == Colleccion.vacio)
            Debug.Log("Vacio");
    }

}

public enum Colleccion
{
    Recetas,
    Infusiones,
    Plantas,
    vacio,
}
