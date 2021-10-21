using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoController : MonoBehaviour
{
    // private 했을 때 inspector에 띄우기
    // [SerializeField]
    // private GameObject panelMP4Player;
    // [SerializeField]
    // private Slider sliderPlaybar;
    // [SerializeField]
    // private RawImage rawImageDrawVideo;
    public VideoPlayer videoPlayer;
    private AudioSource audioSource;

    private void Awake() {
        Debug.Log("Awake");
    }
    private void Start() {
        Debug.Log("Start");
    }

    private void OnMouseDown()
    {

        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
        else
        {
            videoPlayer.Play();
        }
    }

    private void ResetPlaytimeUI(){
        // sliderPlaybar.value = 0;
    }

    public void LoadVideo(){
        // rawImageDrawVideo.texture = videoPlayer.targetTexture;
        Play();
    }

    public void Play(){
        // videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.Play();
        StartCoroutine("OnPlaytimeUI");
    }

    public void Pause(){
        videoPlayer.Pause();
    }

    public void Stop(){
        videoPlayer.Stop();
        StopCoroutine("OnPlaytimeUI");
        ResetPlaytimeUI();
    }

    private IEnumerator OnPlaytimeUI(){
        while(true){
            // sliderPlaybar.value = (float)(videoPlayer.time / videoPlayer.length);
            yield return new WaitForSeconds(1);
        }
    }

    public void OnPlayVideo(){
        GameObject o = GameObject.Find("PanelMP4Player");
        var player = o.AddComponent<UnityEngine.Video.VideoPlayer>();

        // Play on awake defaults to true. Set it to false to avoid the url set
        // below to auto-start playback since we're in Start().
        player.playOnAwake = false;

        // By default, VideoPlayers added to a camera will use the far plane.
        // Let's target the near plane instead.
        player.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;

        // This will cause our Scene to be visible through the video being played.
        player.targetCameraAlpha = 0.5F;

        // Set the video to play. URL supports local absolute or relative paths.
        // Here, using absolute.
        player.url = "/Users/multicampus/My project (1)/Assets/네모옷징어게임소개.mp4";

        // Skip the first 100 frames.
        // videoPlayer.frame = 100;

        // Restart from beginning when done.
        // player.isLooping = true;

        // Each time we reach the end, we slow down the playback by a factor of 10.
        // videoPlayer.loopPointReached += EndReached;

        // Start playback. This means the VideoPlayer may have to prepare (reserve
        // resources, pre-load a few frames, etc.). To better control the delays
        // associated with this preparation one can use videoPlayer.Prepare() along with
        // its prepareCompleted event.
        player.Play();
    }

    // void EndReached(UnityEngine.Video.VideoPlayer vp)
    // {
    //     vp.playbackSpeed = vp.playbackSpeed / 10.0F;
    // }
}
