using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using simulasi.themesDatabase;
using System.Linq;

public class themeList : MonoBehaviour
{
    [SerializeField] ThemeData _themedata;
    [SerializeField] List<Texture2D> _theme;
    [SerializeField] List<string> _themename;

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

