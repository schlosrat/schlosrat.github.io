// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.ScriptPrivateResource_Extension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  internal static class ScriptPrivateResource_Extension
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CheckScriptOwnership(
      this IScriptPrivateResource containingResource,
      DynValue[] values)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CheckScriptOwnership(
      this IScriptPrivateResource containingResource,
      DynValue value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CheckScriptOwnership(this IScriptPrivateResource resource, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CheckScriptOwnership(
      this IScriptPrivateResource containingResource,
      IScriptPrivateResource itemResource)
    {
      throw null;
    }
  }
}
