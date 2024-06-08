using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Racing
{
    public class RacingConstant : MonoBehaviour
    {
        /*********** Barrier ***********/
        public static readonly TimeSpan lifeT = new TimeSpan(0, 0, 2);

        public static readonly Vector3 addSize = new Vector3(0.004f, 0.004f, 0);

        public const float initXSpeed1 = 100f;
        public const float initXSpeed2 = 300f;
        public const float intiYSpeed = -80f;

        public const float addX1 = 5f;
        public const float addX2 = 10f;
        public const float mutiY1 = 1.01f;

        /*********** Contach ***********/
        public static int cPosition = 0;

    }
}