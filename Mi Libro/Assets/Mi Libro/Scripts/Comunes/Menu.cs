using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{

    public BDController bd = new BDController();
    public UISprite spriteTransicion;
    public GameObject btnPlantas;
    public GameObject btnInfusiones;
    public GameObject btnRecetas;
    public TweenRotation spriteInit;
    public GameObject ColliderBack2;
    public GameObject Fondo2;
    public TweenScale tweenFondo2;
    public GameObject panelSelectivo;

    private bool transicionON = false;
    private float transicionTime;
    private float transicionSpeed = 1.9f;
    private bool init = false;

    void Awake()
    {
        bd = GameObject.FindGameObjectWithTag("BD").GetComponent<BDController>();
        spriteTransicion = GameObject.FindGameObjectWithTag("Transicion").GetComponent<UISprite>();
        btnPlantas = GameObject.FindGameObjectWithTag("btnPlantas");
        btnInfusiones = GameObject.FindGameObjectWithTag("BtnInfusiones");
        btnRecetas = GameObject.FindGameObjectWithTag("btnRecetas");
        spriteInit = GameObject.FindGameObjectWithTag("ScrollInit").GetComponent<TweenRotation>();
        transicionTime = 0.0f;
        bd.coleccion = Colleccion.vacio;
        Localization.language = "Spain";
        Init();
    }

    void Update()
    {
        if (transicionON == true)
        {
            if (bd.coleccion == Colleccion.Plantas)
            {
                transicionTime = transicionTime + transicionSpeed * Time.deltaTime;
                spriteTransicion.fillAmount = transicionTime;
            }

            if (bd.coleccion == Colleccion.Infusiones)
            {
                transicionTime = transicionTime + transicionSpeed * Time.deltaTime;
                spriteTransicion.fillAmount = transicionTime;
            }

            if (bd.coleccion == Colleccion.Recetas)
            {
                transicionTime = transicionTime + transicionSpeed * Time.deltaTime;
                spriteTransicion.fillAmount = transicionTime;
            }
        }

        if (spriteTransicion.fillAmount >= 1.0f)
        {
            transicionON = false;
            transicionTime = 0.0f;
            Aparece2Background();
            spriteTransicion.fillAmount = 0.0f;
        }

        if (init == true)
        {
            spriteInit.enabled = true;
            init = false;
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            if (bd.coleccion == Colleccion.Plantas)
            {
                SalirPlantas();
            }

            if (bd.coleccion == Colleccion.Infusiones)
            {
                SalirInfusiones();
            }

            if (bd.coleccion == Colleccion.Recetas)
            {
                SalirRecetas();
            }

            if (bd.coleccion == Colleccion.vacio)
            {
                Salir();
            }

        }
    }

    public void SalirPlantas()
    {
        bd.coleccion = Colleccion.vacio;
        panelSelectivo.SetActive(false);
        Fondo2.SetActive(false);
        ColliderBack2.SetActive(false);
    }

    public void SalirInfusiones()
    {
        bd.coleccion = Colleccion.vacio;
        panelSelectivo.SetActive(false);
        Fondo2.SetActive(false);
        ColliderBack2.SetActive(false);
    }

    public void SalirRecetas()
    {
        bd.coleccion = Colleccion.vacio;
        panelSelectivo.SetActive(false);
        Fondo2.SetActive(false);
        ColliderBack2.SetActive(false);
    }

    public void Salir()
    {
        Application.Quit();
    }


    public void Plantas()
    {
        bd.coleccion = Colleccion.Plantas;
        IrPlantas();
    }

    public void Infusiones()
    {
        bd.coleccion = Colleccion.Infusiones;
        IrInfusiones();
    }

    public void Recetas()
    {
        bd.coleccion = Colleccion.Recetas;
        IrRecetas();
    }

    public void Init()
    {
        btnPlantas.SetActive(false);
        btnInfusiones.SetActive(false);
        btnRecetas.SetActive(false);
        init = true;
    }

    public void ShowBtnRecetas()
    {
        btnRecetas.SetActive(true);
        ShowPlantas();
    }

    public void ShowBtnInfusiones()
    {
        btnInfusiones.SetActive(true);
    }

    public void ShowPlantas()
    {
        btnPlantas.SetActive(true);
        ShowBtnInfusiones();
    }


    //Metodos

    public void IrPlantas()
    {
        transicionON = true;
    }

    public void IrInfusiones()
    {
        transicionON = true;
    }

    public void IrRecetas()
    {
        transicionON = true;
    }

    public void Aparece2Background()
    {
        ColliderBack2.SetActive(true);
        Fondo2.SetActive(true);
        tweenFondo2.enabled = true;
    }

    public void fin2Background()
    {
        panelSelectivo.SetActive(true);
    }
}
