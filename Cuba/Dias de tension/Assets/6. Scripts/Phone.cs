using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Phone : MonoBehaviour
{
    public bool inPhone = false;
    public GameObject phoneUI;
    public GameObject UINormal;

    [Header("Numeros")]
    public Contactos contactos;
    public int[] digitos;
    public TextMeshProUGUI[] Numero;

    public void AbrirTelefono()
    {
        Cursor.lockState = CursorLockMode.None;
        phoneUI.SetActive(true);
        UINormal.SetActive(false);
        inPhone = true;
    }

    public void CerrarTelefono()
    {
        inPhone = false;
        UINormal.SetActive(true);
        phoneUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    //Botones

    public void BotonArriba0()
    {
        digitos[0] = digitos[0] + 1;
        Numero[0].text = digitos[0].ToString();
        if(digitos[0] >= 9)
        {
            digitos[0] = -1;
        }
    }
    public void BotonArriba1()
    {
        digitos[1] = digitos[1] + 1;
        Numero[1].text = digitos[1].ToString();
        if (digitos[1] > 9)
        {
            digitos[1] = 0;
        }
    }
    public void BotonArriba2()
    {
        digitos[2] = digitos[2] + 1;
        Numero[2].text = digitos[2].ToString();
        if (digitos[2] > 9)
        {
            digitos[2] = 0;
        }
    }
    public void BotonArriba3()
    {
        digitos[3] = digitos[3] + 1;
        Numero[3].text = digitos[3].ToString();
        if (digitos[3] > 9)
        {
            digitos[3] = 0;
        }
    }
    public void BotonArriba4()
    {
        digitos[4] = digitos[4] + 1;
        Numero[4].text = digitos[4].ToString();
        if (digitos[4] > 9)
        {
            digitos[4] = 0;
        }
    }
    public void BotonArriba5()
    {
        digitos[5] = digitos[5] + 1;
        Numero[5].text = digitos[5].ToString();
        if (digitos[5] > 9)
        {
            digitos[5] = 0;
        }
    }

    public void BotonAbajo0()
    {
        digitos[0] = digitos[0] - 1;
        Numero[0].text = digitos[0].ToString();
        if(digitos[0] <= 0)
        {
            digitos[0] = 10;
        }
    }
    public void BotonAbajo1()
    {
        digitos[1] = digitos[1] - 1;
        Numero[1].text = digitos[1].ToString();
        if (digitos[1] <= 0)
        {
            digitos[1] = 10;
        }
    }
    public void BotonAbajo2()
    {
        digitos[2] = digitos[2] - 1;
        Numero[2].text = digitos[2].ToString();
        if (digitos[2] <= 0)
        {
            digitos[2] = 10;
        }
    }
    public void BotonAbajo3()
    {
        digitos[3] = digitos[3] - 1;
        Numero[3].text = digitos[3].ToString();
        if (digitos[3] <= 0)
        {
            digitos[3] = 10;
        }
    }
    public void BotonAbajo4()
    {
        digitos[4] = digitos[4] - 1;
        Numero[4].text = digitos[4].ToString();
        if (digitos[4] <= 0)
        {
            digitos[4] = 10;
        }
    }
    public void BotonAbajo5()
    {
        digitos[5] = digitos[5] - 1;
        Numero[5].text = digitos[5].ToString();
        if (digitos[5] <= 0)
        {
            digitos[5] = 10;
        }
    }
}
