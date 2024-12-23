using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class test : MonoBehaviour
{
    public TextMeshProUGUI oleg;
    void Update()
    {
        oleg.text = GameManager.Instance.MoneySum.ToString();
    }

}
