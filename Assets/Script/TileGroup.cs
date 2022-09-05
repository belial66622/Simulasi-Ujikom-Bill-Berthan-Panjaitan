using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using simulasi.themesDatabase;

public class TileGroup : MonoBehaviour
{
    [SerializeField] int _row, _col;
    [SerializeField] GameObject _tile;
    [SerializeField] Sprite[] _sprite;
    // Start is called before the first frame update
    void Start()
    {

        _sprite = ThemeDatabase.instance.themedata._theme[3]._tile;
        CreateTileGroup();
    }



    // Update is called once per frame
    void CreateTileGroup()
    {
        for (int col = 0; col < _col; col++)
        {
            for (int row = 0; row < _row; row++)
            {
                float x = -5 + col * 0.6f;
                float y =  2 - row * 0.6f;
                GameObject tile = Instantiate(_tile,transform);
                tile.transform.position = new Vector2(x, y);
                tile.AddComponent<BoxCollider2D>();
                tile.GetComponent<SpriteRenderer>().sprite = _sprite[Random.Range(0,_sprite.Length)]; 
                tile.transform.name = tile.GetComponent<SpriteRenderer>().sprite.name;
                
            }
        }
    
    }



}
