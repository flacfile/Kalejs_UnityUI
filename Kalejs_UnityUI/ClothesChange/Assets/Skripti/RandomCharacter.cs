using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCharacter : MonoBehaviour {

    public List<ApgerbuMenu> ApgerbuMenus = new List<ApgerbuMenu>();

    public void RandomizeCharacter()
    {
        foreach(ApgerbuMenu changer in ApgerbuMenus)
        {
            changer.randomize();
        }
    }

}
