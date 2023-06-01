// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtProcedural
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  public abstract class SgtProcedural : MonoBehaviour
  {
    public SgtProcedural.GenerateType Generate;
    public SgtSeed Seed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateWith(int seed) => throw null;

    [ContextMenu("Generate Now")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateNow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void DoGenerate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected SgtProcedural() => throw null;

    public enum GenerateType
    {
      Automatically,
      WithRandomSeed,
      WithFixedSeed,
      Manually,
    }
  }
}
