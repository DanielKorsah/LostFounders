using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using UnityEngine;
using UnityEngine.UI;

public class BuildMenuButton : MonoBehaviour
{
    public RectTransform rect;
    private bool showing = false;

    public void Toggle ()
    {
        if (showing)
        {
            SlideOut ();
        }
        else
        {
            SlideIn ();
        }

        showing = !showing;
    }

    public void SlideIn ()
    {
        LeanTween.move (rect, new Vector2 (-384f, -643.92f), 0.2f);
    }

    public void SlideOut ()
    {
        LeanTween.move (rect, new Vector2 (384f, -643.92f), 0.2f);
    }
}