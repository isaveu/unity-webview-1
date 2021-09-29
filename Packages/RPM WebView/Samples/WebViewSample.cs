using UnityEngine;
using ReadyPlayerMe;

public class WebViewSample : MonoBehaviour
{
    [SerializeField] private WebView webView;

    void Start()
    {
        webView.CreateWebView();
    }
}
