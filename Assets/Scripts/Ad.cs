using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;

public class Ad : MonoBehaviour
{
    public static Ad instance;
    public BannerView bannerView;
    public int size;
    public string adUnitId;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        MobileAds.Initialize(initStatus => { });
        RequestBanner();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void RequestBanner()
    {


        AdSize adSize = new AdSize(size, size);
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        this.bannerView.OnAdLoaded += this.HandleOnAdLoaded;
        this.bannerView.OnAdOpening += this.HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        this.bannerView.OnAdClosed += this.HandleOnAdClosed;

        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
        this.bannerView.Show();
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        this.bannerView.Show();
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        Time.timeScale = 0;
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        Time.timeScale = 1;
    }
}
