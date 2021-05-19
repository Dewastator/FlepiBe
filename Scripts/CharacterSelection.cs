using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public int currentChar;
    [SerializeField]
    private Button previous;
    [SerializeField]
    private Button next;
    

    public void Awake()
    {

        SelectChar(PlayerPrefs.GetInt("char"));

    }
    private void SelectChar(int index)
    {
        previous.interactable = (index != 0);
        next.interactable = (index != transform.childCount - 1);

        
        currentChar = index;
        PlayerPrefs.SetInt("char", currentChar);
        
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);

        }
    }

    public void ChangeChar(int change)
    {
        currentChar += change;
        SelectChar(currentChar);
    }
}
