using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string gustoAPedir;
    public float gramosAPedir;
    float costoPorGramo;
    float costoFinal;
    float descuentoFrutilla;
    float costoDescuento;

    // Start is called before the first frame update
    void Start()
    {
        costoPorGramo = 1.25f;
        descuentoFrutilla = 0.1f;
        if (gramosAPedir < 250 || gramosAPedir > 3000)
        {
            Debug.Log("ERROR. Ingrese una cantidad entre 250g y 3000g");
            return;
        }
        else
        {
            if (gustoAPedir == "CHO")
            {
                costoFinal = gramosAPedir * costoPorGramo;
                Debug.Log("Serian $" + costoFinal);
            }
            else if (gustoAPedir == "DDL")
            {
                costoFinal = gramosAPedir * costoPorGramo;
                Debug.Log("Serian $" + costoFinal);
            }
            else if (gustoAPedir == "FRU")
            {
                costoFinal = gramosAPedir * costoPorGramo;
                costoDescuento = costoFinal - costoFinal * descuentoFrutilla;
                Debug.Log("Serian $" + costoDescuento);
            }
            else
            {
                Debug.Log("Solo hay tres gustos: Chocolate (ingrese como CHO), Frutilla (Ingrese como FRU), y Dulce de leche (Ingrese como DDL).");
                return;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
