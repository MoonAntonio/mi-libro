using UnityEngine;
using System.Collections;

public class Recetas : MonoBehaviour
{
    public UILocalize textEncabezado;
    public GameObject desa;
    public GameObject almu;
    public GameObject com;
    public GameObject mer;
    public GameObject cen;


    public void Desayuno()
    {
        Limpiar();
        textEncabezado.key = "lblDesayuno";
        textEncabezado.value = Localization.Get(textEncabezado.key);
        desa.SetActive(true);
    }

    public void Almuerzo()
    {
        Limpiar();
        textEncabezado.key = "lblAlmuerzo";
        textEncabezado.value = Localization.Get(textEncabezado.key);
        almu.SetActive(true);
    }

    public void Comida()
    {
        Limpiar();
        textEncabezado.key = "lblComida";
        textEncabezado.value = Localization.Get(textEncabezado.key);
        com.SetActive(true);
    }

    public void Merienda()
    {
        Limpiar();
        textEncabezado.key = "lblMerienda";
        textEncabezado.value = Localization.Get(textEncabezado.key);
        mer.SetActive(true);
    }

    public void Cena()
    {
        Limpiar();
        textEncabezado.key = "lblCena";
        textEncabezado.value = Localization.Get(textEncabezado.key);
        cen.SetActive(true);
    }

    public void Limpiar()
    {
        desa.SetActive(false);
        almu.SetActive(false);
        com.SetActive(false);
        mer.SetActive(false);
        cen.SetActive(false);
    }
}
