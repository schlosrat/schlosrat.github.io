// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.ScreenNotes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [ExecuteInEditMode]
  public class ScreenNotes : MonoBehaviour
  {
    [TextArea(2, 40)]
    public string text;
    [Range(6f, 100f)]
    public int size;
    public Color color;
    public Vector2 screenPosition;
    [Space(5f)]
    public Font font;
    private GUIStyle m_smallStyle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTextProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScreenNotes() => throw null;
  }
}
