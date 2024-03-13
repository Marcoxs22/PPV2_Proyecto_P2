using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LessonContainer : MonoBehaviour
{
    [Header("GameObject Configuration")]
    public int Lection = 0;
    public int CurrentLession = 0;
    public int TotalLessions = 0;
    public bool AreAllLessondComplete = false;

    [Header("UI Configuration")]
    public TMP_Text StageTitle;
    public TMP_Text LessonStage;

    [Header("External GameObject Configuration")]
    public GameObject lessonContainer;

    [Header("Lesson Data")]
    public ScriptableObject LessonData;


    //// Start is called before the first frame update
    void Start()
    {
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
        if (StageTitle != null || LessonStage != null)
        {
            StageTitle.text = "Lección " + Lection;
            LessonStage.text = "Lección " + CurrentLession + " de " + TotalLessions;
        }
        else
        {
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo TMP_Text");
        }
    }

    //Este metodo activa/desactiva la ventana de lessonContainer
    public void EnableWindow()
    {
        OnUpdateUI();

        if (lessonContainer.activeSelf)
        {
            // Desactiva el objecto si esta activo
            lessonContainer.SetActive(false);
        }
        else
        {
            // Activa el objeto si está desactivado
            lessonContainer.SetActive(true);
        }
    }

   
}
