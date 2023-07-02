// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.RotationInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [RequireComponent(typeof (RotationController))]
  public class RotationInput : MonoBehaviour
  {
    public RotationInput.InputSource source;
    public string horizontalAxis;
    public string verticalAxis;
    public int mouseButtonForDrag;
    public bool mouseButtonExclusive;
    public float horizontalSensitivity;
    public float verticalSensitivity;
    public float horizontalDefault;
    public float verticalDefault;
    private RotationController m_rot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Move(Vector2 delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDefaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDefaultsImmediate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessStandardInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrag(Vector2 delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RotationInput() => throw null;

    public enum InputSource
    {
      StandardInput,
      Messages,
    }
  }
}
