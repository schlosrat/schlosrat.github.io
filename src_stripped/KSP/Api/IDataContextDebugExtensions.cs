// Decompiled with JetBrains decompiler
// Type: KSP.Api.IDataContextDebugExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Text;

namespace KSP.Api
{
  public static class IDataContextDebugExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string DebugToString(
      this IDataContextReadonly context,
      int indent = 1,
      bool indentFirstLine = true,
      bool printParentHierarchy = false,
      bool printSubContexts = false,
      bool printListContent = false,
      bool printKeysCompact = true,
      bool showExpandedKeyValues = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DebugPrintContext(
      StringBuilder builder,
      IDataContextReadonly context,
      int indent,
      bool indentFirstLine = true,
      bool printParentHierarchy = false,
      bool printSubContexts = false,
      bool printListContent = false,
      bool printKeysCompact = true,
      bool showExpandedKeyValues = true,
      int focusOffset = 0)
    {
      throw null;
    }
  }
}
