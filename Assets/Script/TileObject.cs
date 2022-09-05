using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


namespace simulasi.tileObject
{
    public class TileObject : MonoBehaviour, IClicked
    {
        public event Action<string> OnClick;

        void start() 
        { 
        }
        public virtual void Name(string tile)
        {
            OnClick?.Invoke(tile);
            Debug.Log(tile);
        }
    }
}