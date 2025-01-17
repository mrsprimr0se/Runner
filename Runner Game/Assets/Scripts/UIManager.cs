using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public TMP_Text playerPointsText;

    public Image shieldIcon;

    // Start is called before the first frame update
    void Start()
    {
        shieldIcon.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerPointsText.text = playerMovement.points.ToString();
    }
}
