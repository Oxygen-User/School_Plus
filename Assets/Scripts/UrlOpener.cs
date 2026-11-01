using UnityEngine;

public class UrlOpener : MonoBehaviour
{

    public string Url;

    public void OpenGivenUrl()
    {
        Application.OpenURL(Url);
    }
    
}
