// Decompiled with JetBrains decompiler
// Type: MaterialPropertyExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public static class MaterialPropertyExtensions
{
  private static MaterialPropertyBlock block;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetupProperties(
    this Renderer renderer,
    params MaterialPropertyExtensions.MaterialProperty[] properties)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void UpdateProperties(
    this Renderer renderer,
    params MaterialPropertyExtensions.MaterialProperty[] properties)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  static MaterialPropertyExtensions() => throw null;

  public abstract class MaterialProperty
  {
    protected string Name;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract void Apply(ref MaterialPropertyBlock block) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected MaterialProperty() => throw null;
  }
}
