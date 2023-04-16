using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneButton : MonoBehaviour
{
    [SerializeField]
    private InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(TryLoadScene);   
    }

    private void TryLoadScene()
    {
        string playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
