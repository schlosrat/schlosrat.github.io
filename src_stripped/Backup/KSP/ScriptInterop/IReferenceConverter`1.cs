// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IReferenceConverter`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.ScriptInterop
{
  public interface IReferenceConverter<T> : IValueConverter<T>, IObjectConverter where T : struct
  {
    T? ToReference(IScriptValue scriptReference);

    IScriptValue FromReference(T? dotNetReference);
  }
}
