using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MLAgents;

public class TennisAcademy : Academy
{
    public override void AcademyReset()
    {
        Physics.gravity = new Vector3(0, -resetParameters["gravity"], 0);
    }

    public override void AcademyStep()
    {
    }
}
