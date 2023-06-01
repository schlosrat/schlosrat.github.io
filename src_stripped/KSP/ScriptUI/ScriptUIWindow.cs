// Decompiled with JetBrains decompiler
// Type: KSP.ScriptUI.ScriptUIWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptUI
{
  public class ScriptUIWindow
  {
    public Rect rc;
    public int windowID;
    public string windowTitle;
    public Vector2 scrollPos;
    public List<ScriptUIControl> controls;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptUIWindow(int x, int y, int width, int height, string title) => throw null;
  }
}
