using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OptionBtm : MonoBehaviour
{
    //declara una variable pública OptionID, que representa el identificador de la opción
    //public int OptionID;
    //declara una variable pública OptionName, que representa el nombre o contenido de la opción
    //public string OptionName;

    //define el método Start(), que se llama automáticamente al iniciar el objeto en el escenario. En este método, se obtiene el componente TMP_Text del primer hijo del objeto actual (transform.GetChild(0)), y se establece el texto de este componente en el valor de OptionName
    //void Start()
    //{
    //    transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
    //}

    //define un método público llamado UpdateText(), que actualiza el texto del componente TMP_Text del primer hijo del objeto actual con el valor de OptionName
    //public void UpdateText()
    //{
    //    transform.GetChild(0).GetComponent<TMP_Text>().text = OptionName;
    //}

    //define un método público llamado SelectOption(), que es llamado cuando se selecciona esta opción. En este método, se utiliza un singleton (LevelManager.Instance) para establecer la respuesta del jugador y luego verificar el estado del jugador utilizando el método SetPlayerAnswer(OptionID) y CheckPlayerState() del LevelManager
    //public void SelectOption()
    //{
    //    LevelManager.Instance.SetPlayerAnswer(OptionID);
    //    LevelManager.Instance.CheckPlayerState();
    //}
}
