using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInfo : MonoBehaviour
{
    public static Level level01 = new Level("Level01", 4f, 30f);
    public static Level level02 = new Level("Level02", 1f, 10f);
    public static Level[] levels = {level01, level02};

}
