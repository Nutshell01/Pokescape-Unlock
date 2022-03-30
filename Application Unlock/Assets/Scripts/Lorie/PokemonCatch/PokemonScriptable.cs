using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Indice", menuName = "Indice")]

public class PokemonScriptable : MonoBehaviour
{
    
        public int _indiceNumber;
        [TextArea(3, 5)] public string _firstIndice;
        [TextArea(3, 5)] public string _secondIndice;
        public bool _usefulness;

   

    }

