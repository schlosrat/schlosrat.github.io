// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ScreenBug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
