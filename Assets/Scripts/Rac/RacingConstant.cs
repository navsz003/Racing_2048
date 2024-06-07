using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{
    public class RacingConstant : MonoBehaviour
    {
        /*********** Barrier ***********/
        public static TimeSpan lifeT = new TimeSpan(0, 0, 2);

        public static Vector3 addSize = new Vector3(0.004f, 0.004f, 0);

        public static float initXSpeed1 = 100f;
        public static float initXSpeed2 = 300f;
        public static float intiYSpeed = -80f;

        public static float addX1 = 5f;
        public static float addX2 = 10f;
        public static float mutiY1 = 1.01f;

        /*********** Contach ***********/
        public static int cPosition = 0;

    }
}