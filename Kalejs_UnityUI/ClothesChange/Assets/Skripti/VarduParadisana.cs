using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarduParadisana : MonoBehaviour {

    public string vardsS;
    public int vecumsNum;
    public GameObject vards;
    public GameObject vecums;
    public GameObject tekstaAttelosana;
    public GameObject kluda;

    public void UzglabatTekstu()
    {
        vardsS = vards.GetComponent<InputField>().text;
        int V;

        if (!int.TryParse(vecums.GetComponent<InputField>().text, out V))
        {
            kluda.GetComponent<Text>().text = "Kļūda!!!";
            return;
        }
        vecumsNum = V;
        tekstaAttelosana.GetComponent<Text>().text = "Varonim " + vardsS +" ir "+ vecumsNum+" gadi";
        kluda.GetComponent<Text>().text = "";
    }
}


