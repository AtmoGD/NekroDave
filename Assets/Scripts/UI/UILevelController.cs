using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UILevelController : MonoBehaviour
{
    [SerializeField] private LevelManager levelManager = null;

    [SerializeField] private TMP_Text cycleState = null;
    [SerializeField] private Slider cycleSlider = null;

    private CycleState currentCycleState = null;

    private void Awake()
    {
        levelManager.OnCycleChanged += UpdateCycleState;
    }

    private void UpdateCycleState(CycleState _cycleState)
    {
        if (!cycleState) return;

        this.currentCycleState = _cycleState;

        this.cycleState.text = currentCycleState.Cycle.ToString();
    }

    private void Update()
    {
        if (currentCycleState.Cycle == Cycle.Night)
        {
            cycleSlider.value = levelManager.PercentOfActiveEnemies;
        }
        else
        {
            cycleSlider.value = currentCycleState.PercentOfTimeLeft;
        }
    }

    public void SpawnEnemy()
    {

    }
}
