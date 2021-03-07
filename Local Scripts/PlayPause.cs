using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayPause : MonoBehaviour
{
    public Material playButtonMaterial;
    public Material pauseButtonMaterial;
    public Renderer playButtonRenderer;

    private VideoPlayer vPlayer;

    void Awake(){
        vPlayer = GetComponent<VideoPlayer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayandPause(){
        if(vPlayer.isPlaying){
            vPlayer.Pause();
            playButtonRenderer.material = playButtonMaterial;
        }
        else{
            vPlayer.Play();
            playButtonRenderer.material = pauseButtonMaterial;
        }

    }
}
