using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


namespace simulasi.themesDatabase
{
    public class ThemeDatabase : MonoBehaviour
    {
        [SerializeField] ThemeData _themedata;
        [SerializeField] List<Texture2D> _theme;
        [SerializeField] List<string> _themename;

        public ThemeData themedata => _themedata; 

        public static ThemeDatabase instance { get; private set; }


        private void Awake()
        {
            instance = this;
        }
        void Start()
        {
            _theme = new();
            _themename = new();
            _theme = Resources.LoadAll<Texture2D>("Theme").ToList();
            for (int i = 0; i < _theme.Count; i++)
            {
                _themename.Add(null);
                _themename[i] = _theme[i].name;
                _themedata._theme.Add(new());
                _themedata._theme[i]._tile = Resources.LoadAll<Sprite>("Theme/" + _themename[i]);
                Resources.UnloadAsset(_theme[i]);
            }




        }

    }
}
