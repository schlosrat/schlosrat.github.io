// Decompiled with JetBrains decompiler
// Type: TextureTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("KSP/Texture Tools")]
public class TextureTools : MonoBehaviour
{
  public string outputFilename;
  public string inputPath;
  public string fileName;
  public string fileExtension;
  public string suffixDiffuse;
  public string suffixSpecular;
  public string suffixOcclusion;
  public string suffixNormal;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [ContextMenu("Convert!")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Convert() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TextureTools() => throw null;

  public class Vector3Curve
  {
    private AnimationCurve x;
    private AnimationCurve y;
    private AnimationCurve z;

    public float minTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float maxTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3Curve() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(float time, Vector3 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(float time, Color value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 EvaluateVector(float time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color EvaluateColor(float time) => throw null;
  }

  public class Vector4Curve
  {
    private AnimationCurve x;
    private AnimationCurve y;
    private AnimationCurve z;
    private AnimationCurve w;

    public float minTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float maxTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4Curve() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(float time, Vector4 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(float time, Color value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector4 EvaluateVector(float time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color EvaluateColor(float time) => throw null;
  }
}
