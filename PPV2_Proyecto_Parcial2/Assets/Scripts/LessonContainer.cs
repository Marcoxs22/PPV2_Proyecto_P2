using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LessonContainer : MonoBehaviour
{
    //coloca un encabezado en el inspector para agrupar las variables bajo la categor�a "GameObject Configuration"
    [Header("GameObject Configuration")]
    //declara una variable p�blica llamada Lection e inicializa su valor en 0
    public int Lection = 0;
    //declara una variable p�blica llamada CurrentLession e inicializa su valor en 0
    public int CurrentLession = 0;
    //declara una variable p�blica llamada TotalLessions e inicializa su valor en 0
    public int TotalLessions = 0;
    //declara una variable p�blica llamada AreAllLessondComplete de tipo booleano e inicializa su valor en false
    public bool AreAllLessondComplete = false;

    //coloca un encabezado en el inspector para agrupar variables bajo la categor�a "UI Configuration"
    [Header("UI Configuration")]
    //declara una variable p�blica TMP_Text que representa un texto en la interfaz de usuario
    public TMP_Text StageTitle;
    //declara una variable p�blica TMP_Text que representa otro texto en la interfaz de usuario
    public TMP_Text LessonStage;

    //coloca un encabezado en el inspector para agrupar variables bajo la categor�a "External GameObject Configuration"
    [Header("External GameObject Configuration")]
    //declara una variable p�blica GameObject que representa un objeto de juego externo
    public GameObject lessonContainer;

    //Coloca un encabezado en el inspector para agrupar variables bajo la categor�a "Lesson Data"
    [Header("Lesson Data")]
    //declara una variable p�blica ScriptableObject que representa datos relacionados con la lecci�n
    public ScriptableObject LessonData;


    //// Start is called before the first frame update
    void Start()
    {
        //Define el m�todo Start(), que se llama antes del primer cuadro de actualizaci�n. En este m�todo, se verifica si lessonContainer no es nulo y luego se llama al m�todo 
        if (lessonContainer != null)
        {
            OnUpdateUI();
        }
        else
        {
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo GameObject lessonContainer " + name);
        }
    }

    
    public void OnUpdateUI()
    {
        //Define un m�todo p�blico llamado OnUpdateUI() que actualiza la interfaz de usuario con los valores actuales de StageTitle y LessonStage
        if (StageTitle != null || LessonStage != null)
        {
            
            StageTitle.text = "Lecci�n " + Lection;
            
            LessonStage.text = "Lecci�n " + CurrentLession + " de " + TotalLessions;
        }
        else
        {
            
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo TMP_Text");
        }
    }

    //Este metodo activa/desactiva la ventana de lessonContainer
    public void EnableWindow()
    {
        //
        OnUpdateUI();

        //
        if (lessonContainer.activeSelf)
        {
            // Desactiva el objecto si esta activo
            lessonContainer.SetActive(false);
        }
        else
        {
            // Activa el objeto si est� desactivado
            lessonContainer.SetActive(true);
        }
    }

   
}
