using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerMovement playerMovement;

    public TMP_Text playerPointsText;
    public TMP_Text backgroundPoints;

    public Image shieldIcon;

    public Image background;

    // Start is called before the first frame update
    void Start()
    {
        shieldIcon.gameObject.SetActive(false);
        background.gameObject.SetActive(false); // wylacza i wlacza caly image z pkt
    }

    // Update is called once per frame
    void Update()
    {
        playerPointsText.text = playerMovement.points.ToString();
        backgroundPoints.text = playerMovement.points.ToString();
    }
}
