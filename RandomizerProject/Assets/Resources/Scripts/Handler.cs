using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts
{
    public class Handler : MonoBehaviour
    {
        public List<string> categories = new List<string>();
        public Dropdown[] dropDowns;

        public Text text;

        private void Start()
        {
            Debug.Log(Application.streamingAssetsPath + "/JSON/Categories.json");
        }
    }
}
