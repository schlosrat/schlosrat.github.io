// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCircularMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoCircularMaterial : Singleton<GizmoCircularMaterial>
  {
    private GizmoCircularMaterial.Type _circularType;
    private Material _circleMaterial;
    private Material _torusMaterial;
    private Material _cylindricalTorusMaterial;

    public Material CircleMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Material TorusMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Material CylindricalTorusMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Material Material
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCircularMaterial.Type CircularType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsLit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float LightIntensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCircularMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetValuesToSensibleDefaults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCullAlphaScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShapeCenter(Vector3 center) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTorusCoreRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTorusTubeRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCylindricalTorusRadii(float hrzRadius, float vertRadius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLit(bool isLit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightDirection(Vector3 lightDir) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightIntensity(float intensity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZWriteEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZTestEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZTestAlways() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetZTestLess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCullModeBack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCullModeFront() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCullModeOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPass(int passIndex) => throw null;

    public enum Type
    {
      Circle,
      Torus,
      CylindricalTorus,
    }
  }
}
