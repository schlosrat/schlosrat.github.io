// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.EventHandlerProxy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public struct EventHandlerProxy
  {
    private Dictionary<Action, EventHandlerProxy.HandlerProxy> handlerProxies;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Action<object> Add(Action handler) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Action<object> Remove(Action handler) => throw null;

    private struct HandlerProxy
    {
      public Action<object> proxy;
      public int count;
    }
  }
}
