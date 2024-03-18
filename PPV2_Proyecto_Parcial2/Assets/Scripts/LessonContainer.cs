using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LessonContainer : MonoBehaviour
{
    //coloca un encabezado en el inspector para agrupar las variables bajo la categoría "GameObject Configuration"
    [Header("GameObject Configuration")]
    //declara una variable pública llamada Lection e inicializa su valor en 0
    public int Lection = 0;
    //declara una variable pública llamada CurrentLession e inicializa su valor en 0
    public int CurrentLession = 0;
    //declara una variable pública llamada TotalLessions e inicializa su valor en 0
    public int TotalLessions = 0;
    //declara una variable pública llamada AreAllLessondComplete de tipo booleano e inicializa su valor en false
    public bool AreAllLessondComplete = false;

    //coloca un encabezado en el inspector para agrupar variables bajo la categoría "UI Configuration"
    [Header("UI Configuration")]
    //declara una variable pública TMP_Text que representa un texto en la interfaz de usuario
    public TMP_Text StageTitle;
    //declara una variable pública TMP_Text que representa otro texto en la interfaz de usuario
    public TMP_Text LessonStage;

    //coloca un encabezado en el inspector para agrupar variables bajo la categoría "External GameObject Configuration"
    [Header("External GameObject Configuration")]
    //declara una variable pública GameObject que representa un objeto de juego externo
    public GameObject lessonContainer;

    //Coloca un encabezado en el inspector para agrupar variables bajo la categoría "Lesson Data"
    [Header("Lesson Data")]
    //declara una variable pública ScriptableObject que representa datos relacionados con la lección
    public ScriptableObject LessonData;


    //// Start is called before the first frame update
    void Start()
    {
        //Define el método Start(), que se llama antes del primer cuadro de actualización. En este método, se verifica si lessonContainer no es nulo y luego se llama al método 
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
        //Define un método público llamado OnUpdateUI() que actualiza la interfaz de usuario con los valores actuales de StageTitle y LessonStage
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
            // Activa el objeto si está desactivado
            lessonContainer.SetActive(true);
        }
    }

   
}
