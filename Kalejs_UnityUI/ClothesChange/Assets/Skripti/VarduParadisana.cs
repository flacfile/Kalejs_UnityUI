using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VarduParadisana : MonoBehaviour {

    public string teksts;
    public GameObject ievadLauks;
    public GameObject tekstaAttelosana;
    int indekss;
    public int vecums;
    public void UzglabatTekstu()
    {
     
        teksts = ievadLauks.GetComponent<InputField>().text;
        
        tekstaAttelosana.GetComponent<Text>().text =  teksts.ToUpper() + "!";

    }

}
