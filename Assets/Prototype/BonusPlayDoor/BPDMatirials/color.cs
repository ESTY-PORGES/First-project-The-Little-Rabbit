using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Paint.color = this.GetComponent<Renderer>().material;
        Debug.Log(Paint.color);
    }
}
