using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts
{
    public class Handler : MonoBehaviour
    {
        private JsonReader _jsonReader;
        public List<string> categories = new List<string>();
        public Dropdown[] dropDowns;
        
        private void Awake()
        {
            _jsonReader = GetComponent<JsonReader>();
        }
    }
}
