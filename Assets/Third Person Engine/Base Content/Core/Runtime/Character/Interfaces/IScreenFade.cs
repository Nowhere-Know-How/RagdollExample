/* ==================================================================
   ---------------------------------------------------
   Project   :    Third Person Engine
   Publisher :    Infinite Dawn
   Author    :    Tamerlan Favilevich
   ---------------------------------------------------
   Copyright © Tamerlan Favilevich 2017 - 2019 All rights reserved.
   ================================================================== */

using UnityEngine;

namespace ThirdPersonEngine.Runtime
{
    public interface IScreenFade
    {
        void InFade();

        void OutFade();
    }
}