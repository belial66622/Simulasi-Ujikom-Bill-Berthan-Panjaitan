using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace simulasi.tileObject
{
    public class TileObject : MonoBehaviour, IClicked
    {

        public event Action<GameObject> Onclick;


        void start() 
        { 
        }

        public virtual void Name(GameObject tile)
        {
            Onclick?.Invoke(tile);

        }
    }
}