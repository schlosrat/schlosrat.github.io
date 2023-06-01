// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ScreenBug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace EdyCommonTools
{
  [ExecuteInEditMode]
  public class ScreenBug : MonoBehaviour
  {
    public bool hideAtEditor;
    public bool sideBySide;
    public bool showText;
    public string[] text;
    public GUIStyle style;
    public bool showBug;
    public Texture2D bug;
    public float bugSize;
    [FormerlySerializedAs("borderX")]
    public float marginX;
    [FormerlySerializedAs("borderY")]
    public float marginY;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScreenBug() => throw null;
  }
}
