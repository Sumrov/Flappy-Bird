using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private BirdMover _mover;
    private int _score;

    private void Start()
    {
        _mover = GetComponent<BirdMover>();
    }

    public void IncreaseScore()
    {
        _score++;
    }

    public void ResetPlayer()
    {
        _score = 0;
        _mover.ResetBurd();
    }

    public void Die()
    {
        Debug.Log("i am died");
        Time.timeScale = 0;
    }
}
