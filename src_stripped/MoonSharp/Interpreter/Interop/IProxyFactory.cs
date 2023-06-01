// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IProxyFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter.Interop
{
  public interface IProxyFactory
  {
    object CreateProxyObject(object o);

    Type TargetType { get; }

    Type ProxyType { get; }
  }
}
