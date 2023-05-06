using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainitLielumu : MonoBehaviour
{
    public GameObject mainigaisAttels;
    public Slider platumaSlaideris;
    public Slider garumaSlaideris;

    private float platums;
    private float garums;

    private void Start()
    {
        platums = mainigaisAttels.transform.localScale.x;
        garums = mainigaisAttels.transform.localScale.y;
    }

    public void mainitPlatumu()
    {
        float pasreizejaVertiba = platumaSlaideris.value;

        mainigaisAttels.transform.localScale = new Vector2(platums * pasreizejaVertiba, garums);
    }

    public void mainitGarumu()
    {
        float pasreizejaVertiba = garumaSlaideris.value;

        mainigaisAttels.transform.localScale = new Vector2(platums, garums * pasreizejaVertiba);
    }
}
