using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    private UIController ui;

    private void Awake()
    {
        instance = this;
        ui = GetComponent<UIController>();
    }

    public GameObject gasPrefab;
    private GameObject gas;
    public TMP_Text txtFuel;
    private bool isPlaying;
    private float fuel;
    private int intFuel;

    List<Vector2> gasPos = new List<Vector2>() {new Vector2(-1, 7), new Vector2(0, 7), new Vector2(1, 7)};
    
    public void StartGame()
    {
        isPlaying = true;
        fuel = 100;
        GameObject.Find("Car").transform.position = new Vector2(0, -2.5f);
        StartCoroutine(CreateGas());
        StartCoroutine(FuelCheck());
    }


    IEnumerator CreateGas()
    {
        while (isPlaying)
        {
            gas = Instantiate(gasPrefab, gasPos[Random.Range(0, gasPos.Count)], Quaternion.identity);
            yield return new WaitForSeconds(3f);
        }

        yield return null;
    }

    IEnumerator FuelCheck()
    {
        while (isPlaying)
        {
            fuel -= Time.deltaTime * 10;
            intFuel = (int)fuel;
            txtFuel.text = intFuel.ToString();

            if (fuel <= 0)
            {
                isPlaying = false;
                Destroy(gas);
                ui.GameOver();
            }

            yield return null;
        }
        
        yield return null;
    }
    
    public void GetGas()
    {
        if (fuel > 70)
        {
            fuel = 100;
        }
        else
        {
            fuel += 30;
        }
    }
}
