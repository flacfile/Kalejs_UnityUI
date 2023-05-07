using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainitLielumu : MonoBehaviour
{
    public GameObject attels;
    public GameObject platumaSlider;
    public GameObject garumaSlider;

    public void mainitPlatumu()
    {
        float pasreizejaVertiba = platumaSlider.GetComponent<Slider>().value;
        float augstums = attels.transform.localScale.y;

        Vector2 newScale = new Vector2(90f * pasreizejaVertiba, augstums);
        attels.transform.localScale = newScale;
    }
    public void mainitGarums()
    {
        float pasreizejaVertiba = garumaSlider.GetComponent<Slider>().value;
        float platum = attels.transform.localScale.x;

        Vector2 newScale = new Vector2(platum, 90f * pasreizejaVertiba);
        attels.transform.localScale = newScale;
    }
}
