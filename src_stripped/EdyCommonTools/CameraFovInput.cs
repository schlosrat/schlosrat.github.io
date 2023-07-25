// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.CameraFovInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [RequireComponent(typeof (CameraFovController))]
  public class CameraFovInput : MonoBehaviour
  {
    public CameraFovInput.InputSource source;
    public string axisName;
    public CameraFovInput.MoveParameter parameter;
    public float angleSensitivity;
    public float sizeSensitivity;
    public float angleDefault;
    public float sizeDefault;
    private CameraFovController m_fov;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Move(float delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDefaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessStandardInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnScroll(float delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Scroll(float delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraFovInput() => throw null;

    public enum InputSource
    {
      StandardInput,
      Messages,
    }

    public enum MoveParameter
    {
      Angle,
      Size,
      SizeProportional,
    }
  }
}
