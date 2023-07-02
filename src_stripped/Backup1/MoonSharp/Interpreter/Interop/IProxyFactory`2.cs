// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IProxyFactory`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace MoonSharp.Interpreter.Interop
{
  public interface IProxyFactory<TProxy, TTarget> : IProxyFactory
    where TProxy : class
    where TTarget : class
  {
    TProxy CreateProxyObject(TTarget target);
  }
}
