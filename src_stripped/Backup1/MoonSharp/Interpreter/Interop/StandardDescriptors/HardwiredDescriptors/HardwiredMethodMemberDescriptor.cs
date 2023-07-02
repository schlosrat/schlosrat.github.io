// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors.HardwiredMethodMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.StandardDescriptors.HardwiredDescriptors
{
  public abstract class HardwiredMethodMemberDescriptor : FunctionMemberDescriptorBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DynValue Execute(
      Script script,
      object obj,
      ScriptExecutionContext context,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CalcArgsCount(object[] pars) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract object Invoke(Script script, object obj, object[] pars, int argscount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected HardwiredMethodMemberDescriptor() => throw null;
  }
}
