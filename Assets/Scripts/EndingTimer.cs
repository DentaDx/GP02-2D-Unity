using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTimer : MonoBehaviour
{
    [SerializeField] private VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(endingTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator endingTimer()
    {
        videoPlayer.time = 0f;
        videoPlayer.Play();
        yield return new WaitForSeconds(11f);
        SceneManager.LoadScene("Menu");
    }
}
