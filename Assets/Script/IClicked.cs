using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IClicked
{
    public void Name(GameObject a);
    public event Action<GameObject> Onclick;

}
