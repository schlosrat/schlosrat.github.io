// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ProceduralShaderData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Animation;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  [DisableCustomEditorBase]
  public class ProceduralShaderData : MonoBehaviour
  {
    public List<ProceduralPartData> proceduralPartDatas;
    public Dictionary<string, Vector3> shaderOffsets;
    private OffsetSliderSystem targetSliderSystem;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateEventLinks(bool turnOnEvents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateShaderProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraPreRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 CalculateTextureOffset(Transform a, bool flipOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateTextureRotation(
      bool enabled,
      ProceduralPartData.TransformDir up,
      ProceduralPartData.TransformDir compare,
      bool flipRot,
      Transform a,
      Transform b)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetAxis(ProceduralPartData.TransformDir transformDir, Transform trans) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProceduralShaderData() => throw null;
  }
}
