// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartContainersDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
