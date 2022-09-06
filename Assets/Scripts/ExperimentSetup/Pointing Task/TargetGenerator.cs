using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public List<PointingTaskTarget> Enemies;
    public List<PointingTaskTarget> Friends;
    public void GenerateTargets(int totalEnemies, int totalFriends, ref List<PointingTaskTarget> enemies, ref List<PointingTaskTarget> friends)
    {
        enemies = new List<PointingTaskTarget>(Enemies);
        friends = new List<PointingTaskTarget>(Friends);
    }
}
