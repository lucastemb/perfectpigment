using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInfo : MonoBehaviour
{
    public static Level city = new Level("City", 27f, 90f);
    public static Level desert = new Level("Desert", 20f, 120f);
    public static Level beach = new Level("Tropic Biome", 27f, 105f);

    public static Level[] levels = {city, desert, beach};

}
