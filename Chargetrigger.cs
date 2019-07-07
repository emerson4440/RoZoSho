using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoreTeamTwan;

public class Chargetrigger : Trigger
{
    public bool m_canTrigger;

    public override void TriggerEnter()
    {
        m_canTrigger = true;
        Debug.Log("boop");
    }

    public override void TriggerLeave()
    {
        m_canTrigger = false;
    }
}
