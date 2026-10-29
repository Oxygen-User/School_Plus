using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class ChangeLocale_en : MonoBehaviour
{

    public void SetLocaleEN()
    {

        Locale locale = LocalizationSettings.AvailableLocales.GetLocale(new LocaleIdentifier("en"));


        LocalizationSettings.SelectedLocale = locale;

    }
}