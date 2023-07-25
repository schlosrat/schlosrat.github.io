// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.IMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
