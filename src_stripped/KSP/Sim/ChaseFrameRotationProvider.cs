// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ChaseFrameRotationProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class ChaseFrameRotationProvider : IDynamicFrameRotationProvider
  {
    private IUniverseObserver _observer;
    private Rotation _prevObserverRotation;
    private float _rotationLerpSpeed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ChaseFrameRotationProvider(IUniverseObserver observer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation GetRotation(double universeDeltaTime) => throw null;
  }
}
