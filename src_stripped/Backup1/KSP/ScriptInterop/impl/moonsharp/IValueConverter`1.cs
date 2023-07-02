// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.IValueConverter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public interface IValueConverter<T>
  {
    T ToValue(DynValue scriptValue);

    DynValue FromValue(T clrValue, Script script);
  }
}
