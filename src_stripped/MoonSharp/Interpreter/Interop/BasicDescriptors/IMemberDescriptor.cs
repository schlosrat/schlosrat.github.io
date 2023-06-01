// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
  public interface IMemberDescriptor
  {
    bool IsStatic { get; }

    string Name { get; }

    MemberDescriptorAccess MemberAccess { get; }

    DynValue GetValue(Script script, object obj);

    void SetValue(Script script, object obj, DynValue value);
  }
}
