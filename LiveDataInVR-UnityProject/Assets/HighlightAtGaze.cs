using System.Collections;
using System.Collections.Generic;
using Tobii.G2OM;
using UnityEngine;
using UnityEngine.Networking;

public class HighlightAtGaze : MonoBehaviour
{
    private static readonly int _baseColor = Shader.PropertyToID("_BaseColor");
    public Color highlightColor = Color.red;
    public float animationTime = 0.1f;
    private GameObject _TextEditor;

    private Renderer _renderer;
    private Color _originalColor;
    private Color _targetColor;
    private bool _readData;
    private string _apiURL = "http://livedataapi.sistemasrsa.com/api/heatvalue";
    
    //ALTERNATIVE API
    //private string _apiURL = "http://www.randomnumberapi.com/api/v1.0/random?min=0&max=100&count=1";

    //THIS WILL BE CALLED WHEN THE OBJECT RECIEVE OR LOSE THE FOCUS
    public void GazeFocusChanged(bool ObjectHasFocus)
    {
        //WHEN OBJECT HAS FOCUS
        if (ObjectHasFocus)
        {
            Debug.Log("ROJO");
            _readData = true;
            _targetColor = highlightColor;
        }
        else
        {
            Debug.Log("NEGRO");
            _readData = false;
            _targetColor = _originalColor;
        }
    }

    private void Start()
    {
        GameObject _Main = this.transform.gameObject;
        GameObject _Canvas = _Main.transform.GetChild(0).gameObject;
        _TextEditor = _Canvas.transform.GetChild(0).gameObject;
        //_renderer = _Main.GetComponent<Renderer>();
        _renderer = GetComponent<Renderer>();
        _originalColor = _renderer.material.color;
        _targetColor = _originalColor;
    }

    private void Update()
    {
        //This lerp will fade the color of the object
        if (_renderer.material.HasProperty(_baseColor)) // new rendering pipeline (lightweight, hd, universal...)
        {
            _renderer.material.SetColor(_baseColor, Color.Lerp(_renderer.material.GetColor(_baseColor), _targetColor, Time.deltaTime * (1 / animationTime)));
        }
        else // old standard rendering pipline
        {
            _renderer.material.color = Color.Lerp(_renderer.material.color, _targetColor, Time.deltaTime * (1 / animationTime));
        }

        //GET DATA EVERY TIME
        if (true)
        {
            StartCoroutine(GetRequest(_apiURL));
        }
    }
    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // REQUEST AND WAIT FOR DESIRED PAGE
            yield return webRequest.SendWebRequest();
            if (webRequest.result == UnityWebRequest.Result.ConnectionError || webRequest.result == UnityWebRequest.Result.DataProcessingError)
            {
                Debug.Log("Error: " + webRequest.error);
            }
            else
            {
                _TextEditor.GetComponent<TMPro.TextMeshProUGUI>().text = "Heat: " + webRequest.downloadHandler.text + " Celsius";
                var courses = webRequest.downloadHandler.text;
                print(courses);
            }
        }
    }
}
