using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHighlighter : MonoBehaviour
{
    private HashSet<PointingTaskTarget> targets = new HashSet<PointingTaskTarget>();
    
    public void Setup(FoeIdentificationRunner runner)
    {
        runner.TargetHit += RunnerOnTargetHit;
        runner.TrialFinalized += RunnerOnTrialFinalized;
    }

    private void RunnerOnTrialFinalized(object sender, FoeIdentificationEventArgs e)
    {
        foreach (var target in targets)
        {
            target.ToggleOutline(false);
        }
        
        targets.Clear();
    }

    private void RunnerOnTargetHit(object sender, FoeIdentificationEventArgs e)
    {
        PointingTaskTarget target = e.PointingTaskTarget;
        target.ToggleOutline(true);
        targets.Add(target);
    }
}
