using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MessageController : MonoBehaviour
{
    TMP_Text message;
    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<TMP_Text>();
        message.enabled = false;
    }

    public void SetMessage(GameObject go)
    {
        message.text = "You picked up an item!!";
        message.enabled = true;
        Invoke("TurnOff", 2);
    }

    public void TurnOff()
    {
        message.enabled = false;
    }
}
