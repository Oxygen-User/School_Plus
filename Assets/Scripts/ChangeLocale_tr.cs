using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class ChangeLocale_tr : MonoBehaviour
{

    public void SetLocaleTR()
    {

        Locale locale = LocalizationSettings.AvailableLocales.GetLocale(new LocaleIdentifier("tr"));


        LocalizationSettings.SelectedLocale = locale;

    }
}