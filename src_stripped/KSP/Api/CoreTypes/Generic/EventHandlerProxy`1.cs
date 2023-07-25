// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.Generic.EventHandlerProxy`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes.Generic
{
  public struct EventHandlerProxy<T>
  {
    private Dictionary<object, EventHandlerProxy<T>.HandlerProxy> handlerProxies;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Action<T> Add(object handler) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Action<T> Remove(object handler) => throw null;

    private struct HandlerProxy
    {
      public Action<T> proxy;
      public int count;
    }
  }
}
