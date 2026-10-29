using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class ChangeLocale_de : MonoBehaviour
{

    public void SetLocaleDE()
    {

        Locale locale = LocalizationSettings.AvailableLocales.GetLocale(new LocaleIdentifier("de"));


        LocalizationSettings.SelectedLocale = locale;

    }
}