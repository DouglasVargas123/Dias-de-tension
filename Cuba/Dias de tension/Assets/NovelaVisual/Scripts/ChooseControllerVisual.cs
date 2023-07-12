using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChooseControllerVisual : MonoBehaviour
{
    public ChooseLabelControllerVisual label;
    public GameControllerVisual gameController;
    private RectTransform rectTransform;
    private Animator animator;
    private float labelHeight = -1;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rectTransform = GetComponent<RectTransform>();
    }

    public void SetupChoose(ChooseSceneVisual scene)
    {
        DestroyLabels();
        animator.SetTrigger("Show");
        Cursor.lockState = CursorLockMode.None;

        for (int index = 0; index < scene.labels.Count; index++)
        {
            ChooseLabelControllerVisual newLabel = Instantiate(label.gameObject, transform).GetComponent<ChooseLabelControllerVisual>();
            if (labelHeight == -1)
            {
                labelHeight = newLabel.GetHeight();
            }

            newLabel.Setup(scene.labels[index], this, CalculateLabelPosition(index, scene.labels.Count));
        }
    }

    private float CalculateLabelPosition(int labelIndex, int labelCount)
    {
        if (labelCount % 2 == 0)
        {
            if (labelIndex < labelCount / 2)
            {
                return labelHeight * (labelCount / 2 - labelIndex - 1) + labelHeight / 2;
            }
            else
            {
                return -1 * (labelHeight * (labelIndex - labelCount / 2) + labelHeight / 2);
            }
        }
        else
        {
            if (labelIndex < labelCount / 2)
            {
                return labelHeight * (labelCount / 2 - labelIndex - 1) + labelHeight / 2;
            }
            else if(labelIndex > labelCount / 2)
            {
                return -1 * (labelHeight * (labelIndex - labelCount / 2));
            }
            else
            {
                return 0;
            }
        }
    }


    private void DestroyLabels()
    {
        foreach (Transform childTransform in transform)
        {
            Destroy(childTransform.gameObject);
        }
    }

    public void PerformChoose(StorySceneVisual scene)
    {
        gameController.PlayScene(scene);
        animator.SetTrigger("Hide");
        Cursor.lockState = CursorLockMode.Locked;
    }
}

