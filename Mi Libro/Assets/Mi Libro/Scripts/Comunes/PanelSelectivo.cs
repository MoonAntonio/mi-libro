using UnityEngine;
using System.Collections;

public class PanelSelectivo : MonoBehaviour
{
    public BDController bd2 = new BDController();
    public GameObject panelRecetas;
    public GameObject panelPlantas;
    public GameObject panelInfusiones;


	void Start ()
    {
        panelPlantas.SetActive(false);
        panelRecetas.SetActive(false);
        panelInfusiones.SetActive(false);

        if (bd2.coleccion == Colleccion.Plantas)
            panelPlantas.SetActive(true);

        if (bd2.coleccion == Colleccion.Recetas)
            panelRecetas.SetActive(true);

        if (bd2.coleccion == Colleccion.Infusiones)
            panelInfusiones.SetActive(true);
    }

    void Update()
    {
        if (bd2.coleccion == Colleccion.Plantas)
        {
            panelPlantas.SetActive(true);
            panelRecetas.SetActive(false);
            panelInfusiones.SetActive(false);
        }


        if (bd2.coleccion == Colleccion.Recetas)
        {
            panelPlantas.SetActive(false);
            panelRecetas.SetActive(true);
            panelInfusiones.SetActive(false);
        }


        if (bd2.coleccion == Colleccion.Infusiones)
        {
            panelPlantas.SetActive(false);
            panelRecetas.SetActive(false);
            panelInfusiones.SetActive(true);

        }
            
    }
	
	
}
