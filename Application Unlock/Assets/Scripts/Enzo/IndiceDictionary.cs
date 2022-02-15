using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndiceDictionary : MonoBehaviour
{
    public Dictionary<int, IndiceValue> _indices = new Dictionary<int, IndiceValue>();

    #region Dictionnary
    IndiceValue indice01 = new IndiceValue("01", "ceci est un indice", "la réponse est 01");
    IndiceValue indice02 = new IndiceValue("02", "ceci est un aussi indice", "la réponse est 02");
    #endregion

    private void Start()
    {

        _indices.Add(01, indice01);
        _indices.Add(02, indice02);

    }

    public IndiceValue GetIndiceValue(int index)
    {
        IndiceValue currentIndice;
        currentIndice = _indices[index];
        return currentIndice;
    }
}
