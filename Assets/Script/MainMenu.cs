using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace simulasi.mainmenu { 
public class MainMenu : MonoBehaviour
{
        [SerializeField] Button _play, _themeSelection;

    void Start()
    {
            _play.onClick.RemoveAllListeners();
            _play.onClick.AddListener(Play);
            _themeSelection.onClick.RemoveAllListeners();
            _themeSelection.onClick.AddListener(SceneSelection);
     }

        void Play()
        {
            Debug.Log("Play");
        }


        void SceneSelection()
        {
            Debug.Log("SceneSelection");
        }

}
}