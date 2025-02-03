using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChange : MonoBehaviour
{
    [Header("Color change variables")]
    public GameObject player;
    private Renderer playerRenderer;
    private Color newPlayerColor;
    private float randomChannnelOne, randomChannnelTwo, randomChannelThree;

    private void Start()
    {
        playerRenderer = player.GetComponent<Renderer>();
    }

    void ChangePlayerColor()
    {
        randomChannnelOne = Random.Range(0f, 1f);
        randomChannnelTwo = Random.Range(0f, 1f);
        randomChannelThree = Random.Range(0f, 1f);

        newPlayerColor = new Color(randomChannnelOne, randomChannnelTwo, randomChannelThree);

        playerRenderer.material.SetColor("_Color", newPlayerColor);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //upon collision
        if (collision.gameObject.CompareTag("Level")) // Check if colliding with a "Level"
        {
            ChangePlayerColor();
        }
    }

}