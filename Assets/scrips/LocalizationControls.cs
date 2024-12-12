using System.Collections;
using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine;
using UnityEngine.Localization;


public class LocalizationControls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("LocaleSelection"))
        {
            //Ya ha entrado al juego mas de una vez
            int locale = PlayerPrefs.GetInt("LocaleSelection", 0); // Cargar el valor del locale selection
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[locale]; // Cambiar el idioma seleccionado
        }
        else
        {
            //La primera vez que entra
            //Sacar el menu de seleccion de idioma
        }
    }

    public void ButtonSelectLocale(int id)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[id];
        PlayerPrefs.SetInt("LocaleSelection", id);
    }
}
