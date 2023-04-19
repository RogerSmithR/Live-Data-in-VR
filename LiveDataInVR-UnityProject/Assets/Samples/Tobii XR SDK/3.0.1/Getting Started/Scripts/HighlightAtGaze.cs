// Copyright © 2018 – Property of Tobii AB (publ) - All Rights Reserved

using Tobii.G2OM;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System;

namespace Tobii.XR.Examples.GettingStarted
{
    //Monobehaviour which implements the "IGazeFocusable" interface, meaning it will be called on when the object receives focus
    public class HighlightAtGaze : MonoBehaviour, IGazeFocusable
    {
        private static readonly int _baseColor = Shader.PropertyToID("_BaseColor");
        public Color highlightColor = Color.red;
        public float animationTime = 0.1f;

        private Renderer _renderer;
        private Color _originalColor;
        private Color _targetColor;
        private double _count;
        private bool _readData;

        //The method of the "IGazeFocusable" interface, which will be called when this object receives or loses focus
        public void GazeFocusChanged(bool hasFocus)
        {
            //If this object received focus, fade the object's color to highlight color
            if (hasFocus)
            {
                Debug.Log("ROJO");
                _readData = true;
                _targetColor = highlightColor;
            }
            //If this object lost focus, fade the object's color to it's original color
            else
            {
                Debug.Log("NEGRO");
                _readData = false;
                _targetColor = _originalColor;
            }
        }

        private void Start()
        {
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
            if (_readData)
            {
                StartCoroutine(GetRequest("http://www.randomnumberapi.com/api/v1.0/random?min=0&max=100&count=1"));
            }
        }

        IEnumerator GetRequest(string uri)
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
            {
                // Request and wait for the desired page.
                yield return webRequest.SendWebRequest();

                string[] pages = uri.Split('/');
                int page = pages.Length - 1;

                if (webRequest.result == UnityWebRequest.Result.ConnectionError || webRequest.result == UnityWebRequest.Result.DataProcessingError)
                {
                    Debug.Log(pages[page] + ": Error: " + webRequest.error);
                }
                else
                {
                    string value = webRequest.downloadHandler.text;
                    value = value.Remove(0, 1);
                    value = value.Remove(value.Length - 1, 1);
                    double number = Convert.ToDouble(value);
                    Debug.Log(pages[page] + ":\nReceived: " + number + ", count: " + _count.ToString());
                    var courses = webRequest.downloadHandler.text;
                    print(courses);
                }
            }
        }
    }
}
