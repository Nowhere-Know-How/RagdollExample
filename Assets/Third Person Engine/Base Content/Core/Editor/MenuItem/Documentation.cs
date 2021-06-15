/* ==================================================================
   ---------------------------------------------------
   Project   :    Third Person Engine
   Publisher :    Infinite Dawn
   Author    :    Tamerlan Favilevich
   ---------------------------------------------------
   Copyright © Tamerlan Favilevich 2017 - 2019 All rights reserved.
   ================================================================== */

using UnityEditor;

namespace ThirdPersonEngine.Editor
{
    public class Documentation
    {
        [MenuItem(RSEditorPaths.MENUITEM_DEFAULT_PATH + "Documentation", false, 1)]
        public static void Open()
        {
            UserHelper.OpenDocumentation();
        }
    }
}