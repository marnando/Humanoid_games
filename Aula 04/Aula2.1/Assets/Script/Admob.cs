using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class Admob : MonoBehaviour {

    private void RequestBanner()
    {

        //Chave do AdMob
#if UNITY_ANDROID
        string adUnityId = "ca-app-pub-9193329563746183/1789282953";
#elif UNITY_IPHONE
        string adUnityId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
        string adUnityId = "unexpected_platform";
#endif

        // Definir o tamanho do banner se preferir
        //AdSize adSize = new AdSize(250, 250);
        //BannerView banneView = new BannerView(adUnityId, adSize, AdPosition.Bottom);

        //Create a 320x50 banner at the top of the screen
        BannerView bannerView = new BannerView(adUnityId, AdSize.Banner, AdPosition.Bottom);
        //Create an empty ad request
        AdRequest request = new AdRequest.Builder().Build();
        //Load the banner with the request
        bannerView.LoadAd(request);
    }

	// Use this for initialization
	void Start () {
        RequestBanner();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
