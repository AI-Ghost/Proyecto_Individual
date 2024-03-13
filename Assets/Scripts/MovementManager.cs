using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    public Sprite[] mySprites;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(TurnCoRutine());
    }

    IEnumerator TurnCoRutine()
    {
        yield return new WaitForSeconds(0.1f);
        mySpriteRenderer.sprite = mySprites[index];
        index++;
        if (index == 3)
        {
            index = 0;
        }
        StartCoroutine(TurnCoRutine());
    }
}
