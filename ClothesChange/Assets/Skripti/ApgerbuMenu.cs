using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApgerbuMenu : MonoBehaviour {
        
    public List<ApgerbuMainitais> outfitChangers = new List<ApgerbuMainitais> ();
    public void RandomizeCharacter()
    {
        foreach(ApgerbuMainitais changer in outfitChangers)
        {
            changer.RandomCharacter();
        }
    }

}
