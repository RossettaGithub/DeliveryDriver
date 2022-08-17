using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Parcels : MonoBehaviour
{
    [SerializeField] TMP_Text parcelText;
int count;
    // Start is called before the first frame update
    void Start()
    {
        count= GameObject.FindGameObjectsWithTag("Package").Length;
        parcelText.text= "Packages: " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        count= GameObject.FindGameObjectsWithTag("Package").Length;
        parcelText.text= "Packages: " + count.ToString();
    }
}
