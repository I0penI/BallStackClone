using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GateController : MonoBehaviour
{
    [SerializeField]
    private TMP_Text gateNumberText = null;

    [SerializeField]
    private enum GetType
    {
        PositiveGate,
        NegativeGate
    }

    [SerializeField]
    private GetType gateType;

    [SerializeField]
    private int gateNumber;
    void Start()
    {
        RandomGateNumber();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GetGateNumber()
    {
        return gateNumber;
    }

    private void RandomGateNumber()
    {
        switch (gateType)
        {
            case GetType.PositiveGate:
                gateNumber = Random.Range(1, 10);
                gateNumberText.text = gateNumber.ToString();
                break;

            case GetType.NegativeGate:
                gateNumber = Random.Range(-10, -1);
                gateNumberText.text = gateNumber.ToString();
                break;

        }
    }
}
