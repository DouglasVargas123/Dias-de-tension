using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewContact", menuName = "Data/New Contact")]
[System.Serializable]
public class Contactos : ScriptableObject
{
    public string nombre;
    public Color textColor;
    public string numero;
    public int[] numeroInt;
    public Sprite Foto;
}
