using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Resources.Scripts
{
    public class JsonReader : MonoBehaviour
    { 
        private Handler _handler;

        private void Awake()
        {
            _handler = GetComponent<Handler>();
        }

        private void Start()
        {
            UpdateDropDownData();
        }

        public void UpdateDropDownData()
        {
            ClearDropDownData();
            var jsonFile = File.ReadAllText(Application.streamingAssetsPath + "/Categories.json");
            var categoriesInJson = JsonUtility.FromJson<Categories>(jsonFile);

            foreach (var category in categoriesInJson.categories)
            {
                _handler.categories.Add(category);
            }

            foreach (var dropdown in _handler.dropDowns)
            {
                dropdown.AddOptions(_handler.categories);
            }
            
        }

        private void ClearDropDownData()
        {
            _handler.categories.Clear();
            foreach (var dropdown in _handler.dropDowns)
            {
                dropdown.ClearOptions();
            }
        }

        private void UpdateKeywordData()
        {
            //for each category, create a new list containing keywords from .json file with the same name as the Dropdown option
            
            //Last Session: 11/2/2020 - David E.
        }
    }
}
