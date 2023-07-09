using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewContact", menuName = "Data/New Contact")]
[System.Serializable]
public class Contactos : ScriptableObject
{
    public string nombre;
    public string numero;
    public int[] numeroInt;
}
