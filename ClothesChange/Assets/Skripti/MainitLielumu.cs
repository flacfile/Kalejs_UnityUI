using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainitLielumu : MonoBehaviour {
    public GameObject mainigaisAttels;
    public GameObject izmSlaideris;
    public void mainitLielumu()
    {
        float pasreizejaVertiba =
            izmSlaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector2(1f * pasreizejaVertiba, 1f * pasreizejaVertiba);
    }
}
