using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class skipButton : MonoBehaviour
{
    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(skipButtonTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator skipButtonTimer()
    {
        yield return new WaitForSeconds(3f);
        button.gameObject.SetActive(false);
    }
}
