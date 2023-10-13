// Decompiled with JetBrains decompiler
// Type: KSP.Game.ResourceInfoDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Sim.ResourceSystem;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class ResourceInfoDataContext : DataContext
  {
    private ResourceDefinitionData _definition;
    private IResourceContainer _container;

    public Property<string> ResourceName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Property<string> ResourceAbbreviation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Property<Sprite> ResourceIcon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyExternal<float> CurAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyExternal<float> TotalAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyExternal<string> ResUnits
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyExternal<float> AmountNormalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceInfoDataContext(ResourceDefinitionData definition, IResourceContainer container) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetStoredUnits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetCapacityUnits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetUnits(string resourceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetUnitAmountNormalized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnResourceStatusUpdated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LocalizeResourceText() => throw null;
  }
}
