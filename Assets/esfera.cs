using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using UnityEngine.UI;

public class esfera : MonoBehaviour
{



    public Dropdown myDropdown;
    Material matflat;
    Material matgo;
    Material matpo;

    void Start()
    {
        matflat = Resources.Load<Material>("Flat");
        matgo = Resources.Load<Material>("Gouraud");
        matpo = Resources.Load<Material>("Phong");

        gameObject.GetComponent<Renderer>().material = matflat;


        myDropdown = GameObject.Find("Dropdown").GetComponent<Dropdown>();
        myDropdown.onValueChanged.AddListener(delegate {
            myDropdownValueChangedHandler(myDropdown);
        });
    }
    void Destroy()
    {
        myDropdown.onValueChanged.RemoveAllListeners();
    }

    private void myDropdownValueChangedHandler(Dropdown target)
    {
        Debug.Log("selected: " + target.value);
        if (target.value == 0)
        {
            gameObject.GetComponent<Renderer>().material = matflat;

        }
        else if (target.value == 2)
        {
            gameObject.GetComponent<Renderer>().material = matpo;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = matgo;
        }
    }

    public void SetDropdownIndex(int index)
    {
        myDropdown.value = index;
    }
    void Update()
    {

        gameObject.transform.Rotate(0, 0.1f, 0);

    }

}
