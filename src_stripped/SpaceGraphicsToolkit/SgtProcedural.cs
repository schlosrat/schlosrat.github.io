// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtProcedural
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
