// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.EventHandlerProxy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
