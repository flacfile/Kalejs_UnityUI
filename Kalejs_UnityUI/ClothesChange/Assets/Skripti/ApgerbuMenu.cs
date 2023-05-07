using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ApgerbuMenu : MonoBehaviour {

    public SpriteRenderer bodypart;
    public List<Sprite> options = new List<Sprite>();
    private int currentOption = 0;

    public void NextOption()
    {
        currentOption++;
        if (currentOption >= options.Count)
        {
            currentOption = 0;
        }
        bodypart.sprite = options[currentOption];
    }

    public void previousOption()
    {
        currentOption--;
        if (currentOption <= 0)
        {
            currentOption = options.Count - 1;
        }
        bodypart.sprite = options[currentOption];

    }

    public void randomize()
    {
        currentOption = Random.Range(0, options.Count - 1);
        bodypart.sprite = options[currentOption];
    }
}
