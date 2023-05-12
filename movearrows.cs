using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movearrows : MonoBehaviour
{
        public GameObject effectPrefab;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                GameObject effect = Instantiate(effectPrefab, mousePosition, Quaternion.identity);
                Destroy(effect, 1.0f); 
        }
        }
    }

