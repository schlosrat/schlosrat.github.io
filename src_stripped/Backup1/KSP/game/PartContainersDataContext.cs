// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartContainersDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
