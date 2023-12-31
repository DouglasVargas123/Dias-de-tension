using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ChooseLabelControllerVisual : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Color defaultColor;
    public Color hoverColor;
    private StorySceneVisual scene;
    private TextMeshProUGUI textMesh;
    private ChooseControllerVisual controller;

    void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.color = defaultColor;
    }

    public float GetHeight()
    {
        return textMesh.rectTransform.sizeDelta.y * textMesh.rectTransform.localScale.y;
    }

    public void Setup(ChooseSceneVisual.ChooseLabel label, ChooseControllerVisual controller, float y)
    {
        scene = label.nextScene;
        textMesh.text = label.text;
        this.controller = controller;
        Vector3 position = textMesh.rectTransform.localPosition;
        position.y = y;
        textMesh.rectTransform.localPosition = position;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        controller.PerformChoose(scene);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        textMesh.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textMesh.color = defaultColor;
    }
}
