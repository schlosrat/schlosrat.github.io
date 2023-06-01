// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartContainersDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class PartContainersDataContext : DataContext
  {
    private PartComponent _associatedPart;

    public Property<string> PartName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Property<string> PartFamily
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyReadonly<IGGuid> Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ContextListProperty<ResourceInfoDataContext> Resources
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartContainersDataContext(PartComponent associatedPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear(bool fireEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnResourceStatusUpdated() => throw null;
  }
}
