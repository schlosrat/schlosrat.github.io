// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IProxyFactory`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace MoonSharp.Interpreter.Interop
{
  public interface IProxyFactory<TProxy, TTarget> : IProxyFactory
    where TProxy : class
    where TTarget : class
  {
    TProxy CreateProxyObject(TTarget target);
  }
}
