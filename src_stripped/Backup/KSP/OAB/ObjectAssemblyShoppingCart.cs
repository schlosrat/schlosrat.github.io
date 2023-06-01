// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyShoppingCart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyShoppingCart
  {
    protected Dictionary<string, IObjectAssemblyResource> trackedResources;
    protected ObjectAssemblyBuilderEvents events;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyShoppingCart(ObjectAssemblyBuilderEvents eventSystemToUse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Initalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PartCreated(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PartRemoved(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void AddExpense(IObjectAssemblyResource resource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void RemoveExpense(IObjectAssemblyResource resource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreResourceChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostResourceChange() => throw null;
  }
}
