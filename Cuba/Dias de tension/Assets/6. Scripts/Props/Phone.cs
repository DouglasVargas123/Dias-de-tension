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
    public Contactos[] contactos;
    public int[] digitos;
    public TextMeshProUGUI[] Numero;

    public BottomBarController2 bottomBarController2;
    public GameController2 gameController2;


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
        if (digitos[0] <= 9 && digitos[0] >= 0)
        {
            digitos[0] = digitos[0] + 1;
            if (digitos[0] > 9)
            {
                digitos[0] = 0;
            }
            Numero[0].text = digitos[0].ToString();
        }
    }
    public void BotonArriba1()
    {
        if (digitos[1] <= 9 && digitos[1] >= 0)
        {
            digitos[1] = digitos[1] + 1;
            if (digitos[1] > 9)
            {
                digitos[1] = 0;
            }
            Numero[1].text = digitos[1].ToString();
        }
    }
    public void BotonArriba2()
    {
        if (digitos[2] <= 9 && digitos[2] >= 0)
        {
            digitos[2] = digitos[2] + 1;
            if (digitos[2] > 9)
            {
                digitos[2] = 0;
            }
            Numero[2].text = digitos[2].ToString();
        }
    }
    public void BotonArriba3()
    {
        if (digitos[3] <= 9 && digitos[3] >= 0)
        {
            digitos[3] = digitos[3] + 1;
            if (digitos[3] > 9)
            {
                digitos[3] = 0;
            }
            Numero[3].text = digitos[3].ToString();
        }
    }
    public void BotonArriba4()
    {
        if (digitos[4] <= 9 && digitos[4] >= 0)
        {
            digitos[4] = digitos[4] + 1;
            if (digitos[4] > 9)
            {
                digitos[4] = 0;
            }
            Numero[4].text = digitos[4].ToString();
        }
    }
    public void BotonArriba5()
    {
        if (digitos[5] <= 9 && digitos[5] >= 0)
        {
            digitos[5] = digitos[5] + 1;
            if (digitos[5] > 9)
            {
                digitos[5] = 0;
            }
            Numero[5].text = digitos[5].ToString();
        }
    }

    public void BotonAbajo0()
    {
        if (digitos[0] <= 9 && digitos[0] >= 0)
        {
            digitos[0] = digitos[0] - 1;
            if (digitos[0] < 0)
            {
                digitos[0] = 9;
            }
            Numero[0].text = digitos[0].ToString();
        }
    }
    public void BotonAbajo1()
    {
        if (digitos[1] <= 9 && digitos[1] >= 0)
        {
            digitos[1] = digitos[1] - 1;
            if (digitos[1] < 0)
            {
                digitos[1] = 9;
            }
            Numero[1].text = digitos[1].ToString();
        }
    }
    public void BotonAbajo2()
    {
        if (digitos[2] <= 9 && digitos[2] >= 0)
        {
            digitos[2] = digitos[2] - 1;
            if (digitos[2] < 0)
            {
                digitos[2] = 9;
            }
            Numero[2].text = digitos[2].ToString();
        }
    }
    public void BotonAbajo3()
    {
        if (digitos[3] <= 9 && digitos[3] >= 0)
        {
            digitos[3] = digitos[3] - 1;
            if (digitos[3] < 0)
            {
                digitos[3] = 9;
            }
            Numero[3].text = digitos[3].ToString();
        }
    }
    public void BotonAbajo4()
    {
        if (digitos[4] <= 9 && digitos[4] >= 0)
        {
            digitos[4] = digitos[4] - 1;
            if (digitos[4] < 0)
            {
                digitos[4] = 9;
            }
            Numero[4].text = digitos[4].ToString();
        }
    }
    public void BotonAbajo5()
    {
        if (digitos[5] <= 9 && digitos[5] >= 0)
        {
            digitos[5] = digitos[5] - 1;
            if (digitos[5] < 0)
            {
                digitos[5] = 9;
            }
            Numero[5].text = digitos[5].ToString();
        }
    }

    public void LLAMAR()
    {
        if (digitos[0] == contactos[0].numeroInt[0] && digitos[1] == contactos[0].numeroInt[1] && digitos[2] == contactos[0].numeroInt[2] && digitos[3] == contactos[0].numeroInt[3] && digitos[4] == contactos[0].numeroInt[4] && digitos[5] == contactos[0].numeroInt[5])
        {
            bottomBarController2.PlayScene(gameController2.currentScene);
            gameController2.inCall = true;
            phoneUI.SetActive(false);
        }
        if (digitos[0] == contactos[1].numeroInt[0] && digitos[1] == contactos[1].numeroInt[1] && digitos[2] == contactos[1].numeroInt[2] && digitos[3] == contactos[1].numeroInt[3] && digitos[4] == contactos[1].numeroInt[4] && digitos[5] == contactos[1].numeroInt[5])
        {
            bottomBarController2.PlayScene(gameController2.currentScene);
            gameController2.inCall = true;
            phoneUI.SetActive(false);
        }
        if (digitos[0] == contactos[2].numeroInt[0] && digitos[1] == contactos[2].numeroInt[1] && digitos[2] == contactos[2].numeroInt[2] && digitos[3] == contactos[2].numeroInt[3] && digitos[4] == contactos[2].numeroInt[4] && digitos[5] == contactos[2].numeroInt[5])
        {
            bottomBarController2.PlayScene(gameController2.currentScene);
            gameController2.inCall = true;
            phoneUI.SetActive(false);
        }
        if (digitos[0] == contactos[3].numeroInt[0] && digitos[1] == contactos[3].numeroInt[1] && digitos[2] == contactos[3].numeroInt[2] && digitos[3] == contactos[3].numeroInt[3] && digitos[4] == contactos[3].numeroInt[4] && digitos[5] == contactos[3].numeroInt[5])
        {
            bottomBarController2.PlayScene(gameController2.currentScene);
            gameController2.inCall = true;
            phoneUI.SetActive(false);
        }
        if (digitos[0] == contactos[4].numeroInt[0] && digitos[1] == contactos[4].numeroInt[1] && digitos[2] == contactos[4].numeroInt[2] && digitos[3] == contactos[4].numeroInt[3] && digitos[4] == contactos[4].numeroInt[4] && digitos[5] == contactos[4].numeroInt[5])
        {          
            bottomBarController2.PlayScene(gameController2.currentScene);
            gameController2.inCall = true;
            phoneUI.SetActive(false);
        }
        if (digitos[0] == contactos[5].numeroInt[0] && digitos[1] == contactos[5].numeroInt[1] && digitos[2] == contactos[5].numeroInt[2] && digitos[3] == contactos[5].numeroInt[3] && digitos[4] == contactos[5].numeroInt[4] && digitos[5] == contactos[5].numeroInt[5])
        {          
            bottomBarController2.PlayScene(gameController2.currentScene);
            gameController2.inCall = true;
            phoneUI.SetActive(false);
        }
    }
}
