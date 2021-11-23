using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit rayhit = new RaycastHit();

            if (Physics.Raycast(ray, out rayhit))
            {
                GameObject hitObject = rayhit.collider.gameObject;
                //Fetch the Renderer from the GameObject
                Renderer rend = hitObject.GetComponent<Renderer>();

                //Create a new Material
                Material material = new Material(Shader.Find("Standard"));
                material.color = Color.green;

                //Switch to new material
                rend.material = material;
            }


        }
    }
}
