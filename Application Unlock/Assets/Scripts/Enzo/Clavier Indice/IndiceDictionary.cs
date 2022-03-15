using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndiceDictionary : MonoBehaviour
{
    [SerializeField] IndiceValue[] _indiceObjectArray;
    public IndiceValue _defaultValue;
    public Dictionary<int, IndiceValue> _indices = new Dictionary<int, IndiceValue>();

    // #region Dictionnary
    // IndiceValue indice01 = new IndiceValue("01", "Ceci est un indice", "la réponse est 01", true);
    // IndiceValue indice02 = new IndiceValue("02", "Rien à signaler", null, false);
    // #endregion

    private void Awake()
    {
        foreach(IndiceValue value in _indiceObjectArray)
        {
            _indices.Add(value._indiceNumber, value);
        }

        // _indices.Add(01, indice01);
        // _indices.Add(02, indice02);

    }

    public IndiceValue GetIndiceValue(int index)
    {
        IndiceValue value;
        
        if(_indices.TryGetValue(index, out value))
        {
            return value;
        }
        else
        {
           
            return _defaultValue;
        }
        
        // IndiceValue currentIndice;
        // currentIndice = _indices[index];
        // return currentIndice;
    }
}
