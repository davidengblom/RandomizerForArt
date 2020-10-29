using System.IO;
using UnityEngine;

namespace Resources.Scripts
{
    public class JsonReader : MonoBehaviour
    {
        [SerializeField] private Handler handler;
        public TextAsset categoriesFile;

        private void Start()
        {
            categoriesFile = (TextAsset) UnityEngine.Resources.Load(Application.streamingAssetsPath + "/JSON/Categories.json");
            var categoriesInJson = JsonUtility.FromJson<Categories>(categoriesFile.text);

            foreach (var category in categoriesInJson.categories)
            {
                handler.categories.Add(category);
            }

            foreach (var dropdown in handler.dropDowns)
            {
                dropdown.AddOptions(handler.categories);
            }
        }
    }
}
