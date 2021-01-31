using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class UnlockButton : MonoBehaviour
{
    public Sprite Icon;
    public int UnlockIndex;

    private Sprite lockSprite;
    private Image lockImage;

    // Start is called before the first frame update
    void Start ()
    {
        lockImage = gameObject.GetComponent<Image> ();
        if (GameManager.Unlocks[UnlockIndex])
        {
            lockSprite = Resources.Load<Sprite> ("Art/Placeholder/unlocked");
        }
        else
        {
            lockSprite = Resources.Load<Sprite> ("Art/Placeholder/locked");
        }

        if (lockSprite == null)
        {
            lockSprite = Resources.Load<Sprite> ("Art/Placeholder/temp");
            Debug.Log ("no locksprite");
        }
        lockImage.sprite = lockSprite;

        if (Icon == null)
        {
            Icon = Resources.Load<Sprite> ("Art/Placeholder/temp.png");
        }

    }

}