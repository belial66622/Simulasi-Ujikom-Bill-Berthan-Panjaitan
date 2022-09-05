using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace simulasi.themesDatabase
{

    [System.Serializable]
    public class ThemeData
    {
        public List<Theme> _theme;

        [System.Serializable]
        public class Theme
        {
            public Sprite[] _tile;
            public string unlocked;
        }

    }



}