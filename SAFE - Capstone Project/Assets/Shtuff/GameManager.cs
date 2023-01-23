using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject tileCollection;
    static public Component[] tileTransforms;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        tileTransforms = tileCollection.GetComponentsInChildren(typeof(Transform));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
