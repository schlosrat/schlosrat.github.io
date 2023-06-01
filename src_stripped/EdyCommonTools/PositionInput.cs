// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.PositionInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [RequireComponent(typeof (PositionController))]
  public class PositionInput : MonoBehaviour
  {
    public PositionInput.InputSource source;
    public PositionInput.OutputPlane outputPlane;
    public bool swapCoordinates;
    public string inputAxisX;
    public string inputAxisY;
    public int mouseButtonForDrag;
    public bool mouseButtonExclusive;
    public Vector2 inputSensitivity;
    public Vector2 defaultPosition;
    private PositionController m_pos;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 MapToPlane(Vector2 v, Vector3 defaultPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Move(Vector2 delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDefaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessStandardInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMove(Vector2 delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PositionInput() => throw null;

    public enum InputSource
    {
      StandardInput,
      Messages,
    }

    public enum OutputPlane
    {
      XZ,
      XY,
      ZY,
    }
  }
}
