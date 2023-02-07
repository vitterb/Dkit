using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubeSpawner : MonoBehaviour
{
    public GameObject MyCube;
    public Button spawnButton;
    // Start is called before the first frame update
    void Start()
    {
        spawnButton.onClick.AddListener(spawnCube);
    }

    public void spawnCube()
    {
        Instantiate(MyCube, transform.position, Quaternion.identity);
    }
   
}
