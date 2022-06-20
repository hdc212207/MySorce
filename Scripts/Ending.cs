using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Utage;

public class Ending : MonoBehaviour
{
    public AdvEngine engine;

    public void goEnd()
    {
        engine.JumpScenario("confirmation");
    }
    /*if (engine.IsEndScenario)
    {

    }*/
}
