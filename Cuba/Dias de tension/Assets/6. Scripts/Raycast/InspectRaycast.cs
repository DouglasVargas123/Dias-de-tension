using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InspectRaycast : MonoBehaviour
{
    private int rayLenght = 6;
    [SerializeField] private string  targetTag = "Interact";
    private ObjectController raycastedObj;

    [SerializeField] private Image crosshair;
    private bool isCrosshairActive;
    private bool doOnce;


    [Header("CARTA")]
    public Carta carta;
    [Header("Phone")]
    public Phone phone;
    public GameController2 gameController2;
    [Header("Reloj")]
    public Reloj reloj;
    private void Update()
    {
        RaycastHit hit;
        Vector3 fdw = transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(transform.position, fdw * rayLenght, Color.red);

        if (Physics.Raycast(transform.position,fdw, out hit, rayLenght))
        {
            if (!carta.inCarta | !phone.inPhone)
            {
                if (!gameController2.inCall)
                {
                    if (hit.collider.CompareTag(targetTag))
                    {
                        if (!doOnce)
                        {
                            raycastedObj = hit.collider.gameObject.GetComponent<ObjectController>();
                            raycastedObj.ShowObjectName();
                            CrosshairChange(true);
                        }
                        isCrosshairActive = true;
                        doOnce = true;

                        if (Input.GetMouseButtonDown(0) && hit.collider.transform.name == "Tv")
                        {
                            raycastedObj.ShowExtraInfo();
                        }
                        if (Input.GetMouseButtonDown(0) && hit.collider.transform.name == "Carta")
                        {
                            carta.AbrirCarta();
                        }
                        if (Input.GetMouseButtonDown(0) && hit.collider.transform.name == "Phone")
                        {
                            phone.AbrirTelefono();
                        }
                        if (Input.GetMouseButtonDown(0) && hit.collider.transform.name == "Clock")
                        {
                            reloj.ShowAdditionalInfoReloj();
                        }
                    }
                }
            }
        }
        else
        {
            if (isCrosshairActive)
            {
                raycastedObj.HideObjectName();
                CrosshairChange(false);
                doOnce = false;
            }
        }
    }

    void CrosshairChange(bool on)
    {
        if(on && !doOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrosshairActive = false;
        }
    }
}
