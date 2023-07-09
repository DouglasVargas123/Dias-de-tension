using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InspectController : MonoBehaviour
{
    [SerializeField] private GameObject objectNameBG;
    [SerializeField] private TextMeshProUGUI objectNameUI;

    [SerializeField] private float onScreanTimer;
    [SerializeField] private TextMeshProUGUI extraInfoUI;
    [SerializeField] private GameObject extraInfoBG;
    [HideInInspector] public bool startTImer;
    private float timer;

    private void Start()
    {
        objectNameBG.SetActive(false);
        extraInfoBG.SetActive(false);
    }

    private void Update()
    {
        if (startTImer)
        {
            timer -= Time.deltaTime;

            if(timer <= 0)
            {
                timer = 0;
                ClearAdditionalInfo();
                startTImer = false;
            }
        }
    }

    public void ShowName(string objectName)
    {
        objectNameBG.SetActive(true);
        objectNameUI.text = objectName;
    }

    public void HideName()
    {
        objectNameBG.SetActive(false);
        objectNameUI.text = "";
    }

    public void ShowAdditionalInfo(string newInfo)
    {
        timer = onScreanTimer;
        startTImer = true;
        extraInfoBG.SetActive(true);
        extraInfoUI.text = newInfo;
    }

    void ClearAdditionalInfo()
    {
        extraInfoBG.SetActive(false);
        extraInfoUI.text = "";
    }
}
