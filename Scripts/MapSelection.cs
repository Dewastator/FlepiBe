using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapSelection : MonoBehaviour
{
    public int currentMap;
    [SerializeField]
    private Button previous;
    [SerializeField]
    private Button next;
    [SerializeField]
    private Text mapaNaziv;
   
    public void Awake()
    {
        
        SelectMap(PlayerPrefs.GetInt("mapa"));

    }
    private void SelectMap(int index)
    {
        previous.interactable = (index != 0);
        next.interactable = (index != transform.childCount - 1);
     
        mapaNaziv.text = transform.GetChild(index).name;
        currentMap = index;
        PlayerPrefs.SetInt("mapa", currentMap);
        MapAnimation.firstMap = true;
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
            
        }
    }

    public void ChangeMap(int change)
    {
        currentMap += change;
        SelectMap(currentMap);
    }
}
