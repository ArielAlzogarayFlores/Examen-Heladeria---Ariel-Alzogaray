using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1 : MonoBehaviour
{
    public string gusto;

    public int cant;

    // Start is called before the first frame update
    void Start()
    {
        if (gusto != "CHO" && gusto != "DDL" && gusto != "FRU")
        {
            Debug.Log("Error");

        }
        else if (cant < 200 && cant > 3000)
        {
            Debug.Log("Error");

        }
        else
        {
            float precioGramo = 500f / 1000f;

            if (gusto == "CHO")
            {
                Debug.Log("Usted pidio "+cant+"g de helado de chocolate que cuesta un total de $"+cant * precioGramo);
            }
            else if (gusto == "DDL")
            {
                Debug.Log("Usted pidio "+cant+"g de helado de dulce de leche que cuesta un total de $" + cant * precioGramo);
            }

            else if (gusto == "FRU")
            {
                Debug.Log("Usted pidio "+cant+"g de helado de dulce de leche que cuesta un total de $"+ cant * precioGramo);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
