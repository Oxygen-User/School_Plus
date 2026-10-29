using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LocaleSelect : MonoBehaviour
{
    public enum Language
    {
        en, de, tr
    }

    public Language lang;

    public void SetNewLocale()
    {
        string localeCode;

        switch (lang)
        {
            case Language.en:
                localeCode = "en";
                break;

            case Language.de:
                localeCode = "de";
                break;

            case Language.tr:
                localeCode = "tr";
                break;

            default:
                return;
        }

        Locale locale = LocalizationSettings
            .AvailableLocales
            .GetLocale(new LocaleIdentifier(localeCode));

        if (locale == null)
        {
            Debug.LogError("Locale not found: " + localeCode);
            return;
        }

        LocalizationSettings.SelectedLocale = locale;
    }
}