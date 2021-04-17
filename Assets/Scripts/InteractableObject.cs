using UnityEngine;
using UnityEngine.UI;

public class InteractableObject : MonoBehaviour
{
    public GameObject Object;
    public Text ObjectText;
    public string TextValue;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Object.SetActive(false);
        ObjectText.text = TextValue;
    }

}
