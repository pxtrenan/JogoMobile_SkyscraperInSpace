using UnityEngine;
using UnityEngine.Advertisements;
using GoogleMobileAds.Api;


public class Death : MonoBehaviour
{
    public static bool isGameOver;
    private int deadCount;
    public GameObject gameOver;
    public GameObject player;
    private RewardBasedVideoAd rewardBasedVideo;

    public void ShowInterstitialAd()
    {
        //Show Ad
        if (interstitial.IsLoaded())
        {
            interstitial.Show();

            //Stop Sound
            //

            Debug.Log("SHOW AD XXX");
        }
    }

        void Start()
    {
        RequestInterstitialAds();
        deadCount = 0;        
    }

    InterstitialAd interstitial;
    private void RequestInterstitialAds()
    {
        string adID = "ca-app-pub-3526702404345714/9438035770";

#if UNITY_ANDROID
        string adUnitId = adID;
#elif UNITY_IOS
        string adUnitId = adID;
#else
        string adUnitId = adID;
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        //***Test***
        AdRequest request = new AdRequest.Builder()
       .AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
       .AddTestDevice("2077ef9a63d2b398840261c8221a0c9b")  // My test device.
       .Build();

        //***Production***
        //AdRequest request = new AdRequest.Builder().Build();

        //Register Ad Close Event
        interstitial.OnAdClosed += Interstitial_OnAdClosed;

        // Load the interstitial with the request.
        interstitial.LoadAd(request);

        Debug.Log("AD LOADED XXX");

    }
    //Ad Close Event
    private void Interstitial_OnAdClosed(object sender, System.EventArgs e)
    {
        //Resume Play Sound

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Platform")
        {
            
            if (deadCount == 0)
            {
                ShowInterstitialAd();
                deadCount += 1;
            }
            // We reset counter after 3 deads
            else if (deadCount == 3)
            {
                deadCount = 0;
            }
            isGameOver = true;
            
            player.gameObject.SetActive(false);
            gameOver.gameObject.SetActive(true);

            Handheld.Vibrate();
           
            
            
        }
    }
}

	