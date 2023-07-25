// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ModuleAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public class ModuleAction : DelegateAction, IModuleAction, IAction, IModuleDataContext
  {
    public string ContextKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool ActionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetContextKey() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleAction(Delegate action) => throw null;
  }
}
