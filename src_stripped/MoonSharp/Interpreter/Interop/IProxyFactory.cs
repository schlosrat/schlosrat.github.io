﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IProxyFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
