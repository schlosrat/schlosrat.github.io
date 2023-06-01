// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PartResource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class PartResource
  {
    public PartResourceDefinition info;
    public string resourceName;
    public PartResourceData resourceData;
    public PartResourceUIState uiState;

    public double amount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double maxAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool flowState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartResource.FlowMode flowMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ResourceType type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool maxLocked
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool isTweakable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool isVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool hideFlow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartResource() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Copy(PartResource res) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInfo(PartResourceDefinition info) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanProvide(double demand) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanProvide(bool pulling) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Flowing(bool pulling) => throw null;

    public enum FlowMode
    {
      None,
      Out,
      In,
      Both,
    }
  }
}
