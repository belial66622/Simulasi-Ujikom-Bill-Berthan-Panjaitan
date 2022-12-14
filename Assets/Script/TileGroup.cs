using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using simulasi.themesDatabase;

public class TileGroup : MonoBehaviour
{
    [SerializeField] int _row, _col;
    [SerializeField] GameObject _tileobject;
    [SerializeField] Sprite[] _sprite;
    [SerializeField] GameObject[,] _tile;
    GameObject one, two;
    bool change = true;
    int random;
    // Start is called before the first frame update
    void Start()
    {

        _sprite = ThemeDatabase.instance.themedata._theme[1]._tile;
        CreateTileGroup();
        randomizer(_tile);
    }



    // Update is called once per frame
    void CreateTileGroup()
    {
        _tile = new GameObject[_col,_row];
        for (int col = 0; col < _col; col++)
        {
            for (int row = 0; row < _row; row++)
            {
                if (change)
                {
                    random = Random.Range(0, _sprite.Length);
                }

                float x = -5 + col * 0.6f;
                float y =  2 - row * 0.6f;
                _tile[col,row] = Instantiate(_tileobject,transform);
                _tile[col,row].transform.position = new Vector2(x, y);
                _tile[col,row].GetComponent<SpriteRenderer>().sprite = _sprite[random]; 
                _tile[col,row].transform.name = _tile[col,row].GetComponent<SpriteRenderer>().sprite.name;
                IClicked _clicked = _tile[col, row].GetComponent<IClicked>();
                _clicked.Onclick += Onclick;

                change = !change;
            }
        }
    
    }

    void randomizer(GameObject[,] loc)
    {
        Vector3 temp;
        int c, d;
        for (int a = 0; a < _col; a++)
        {
            for (int b = 0; b < _row; b++)
            {
                c = Random.Range(0, _col);
                d = Random.Range(0, _row);
                temp = loc[a,b].transform.position;
                loc[a, b].transform.position = loc[c, d].transform.position;
                loc[c, d].transform.position = temp;

            }
            
        }
    
    }

    void Onclick(GameObject a)
    {
        if (one == null)
        {
            one = a;
        }
        else if (two == null)
        {
            two = a;
        }

        if (one != null && two != null )
        {
            if (one.name == two.name && one != two)
            {
                Destroy(one);
                Destroy(two);
            }

            else
            {
                one = null;
                two = null;
            }
        }
    }
}
