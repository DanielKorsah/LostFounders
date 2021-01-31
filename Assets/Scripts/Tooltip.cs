using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode ()]
public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI headerField;
    public TextMeshProUGUI contentField;
    public LayoutElement LayoutElement;
    public int characterWrapLimit;

    private RectTransform rect;

    private void Awake() {
        rect = GetComponent<RectTransform>();
    }

    public void SetText (string content, string header = "")
    {
        if (string.IsNullOrEmpty (header))
        {
            headerField.gameObject.SetActive (false);
        }
        else
        {
            headerField.gameObject.SetActive (true);
            headerField.text = header;
        }

        contentField.text = content;

        UpdateWrapping ();
    }

    private void Update ()
    {
        if (Application.isEditor)
        {
            UpdateWrapping ();
        }
    
        Vector2 position = Input.mousePosition;
        transform.position = position;
    
        float pivotX = position.x/Screen.width;
        float pivotY = position.y/Screen.height;

        rect.pivot = new Vector2(pivotX, pivotY);
    
        

    }

    private void UpdateWrapping ()
    {
        int headerLength = headerField.text.Length;
        int contentLength = contentField.text.Length;

        LayoutElement.enabled = (headerLength > characterWrapLimit || contentLength > characterWrapLimit) ? true : false;
    }
}