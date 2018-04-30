using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cadr_Img : MonoBehaviour {
    
    public Card Cardobj;
    public int No;

    //public int Cut;
    // Use this for initialization
    public void OnMouseDown()
    {
        Cardobj.count(No);
        Cardobj.Btnclick();
    }
}
