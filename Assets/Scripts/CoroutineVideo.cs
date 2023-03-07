using System.Collections;
using UnityEngine.Video;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CoroutineVideo : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
        videoPlayer.time = 0f;
        StartCoroutine(Timer());
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Timer()
    {
        videoPlayer.time = 0f;
        yield return new WaitForSeconds(20f);
        videoPlayer.Play();
        yield return new WaitForSeconds(11f);
        SceneManager.LoadScene("Menu");
    }
}
