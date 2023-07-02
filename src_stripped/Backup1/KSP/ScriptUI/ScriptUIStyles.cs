// Decompiled with JetBrains decompiler
// Type: KSP.ScriptUI.ScriptUIStyles
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ScriptUI
{
  public class ScriptUIStyles
  {
    public Rect titleBar;
    public Rect browserGroup;
    public Rect browserGroupTotal;
    public Rect _entry;
    public GUIStyle elementStyle;
    public GUIStyle toggleStyle;
    public GUIStyle listStyle;
    public GUIStyle buttonStyle;
    public GUIStyle checkStyle;
    public GUIStyle closeButtonStyle;
    public Texture2D backGroundTex;
    public Texture2D buttonTex;
    public Texture2D buttonHoverTex;
    public Texture2D buttonDownTex;
    public Rect _windowRect;
    public GUIStyle _windowStyle;
    public const int FontSize = 20;
    private List<Texture2D> _generatedTextures;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnloadResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Texture2D CreateUITexture(int texSize, Color col, bool border) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupWindowStyles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptUIStyles() => throw null;
  }
}
