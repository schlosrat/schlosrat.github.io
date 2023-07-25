// Decompiled with JetBrains decompiler
// Type: KSP.Assets.impl.CompiledScriptDatabaseContentBuilder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Assets.impl
{
  [CreateAssetMenu(fileName = "scripts.asset", menuName = "KSP/Compiled Script Database")]
  [DisableCustomEditorBase]
  public class CompiledScriptDatabaseContentBuilder : ScriptableObject
  {
    public string scriptNameFilter;
    public List<CompiledScriptRecord> CompiledScripts;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompiledScriptDatabaseContentBuilder() => throw null;

    public class CompiledScript : ICompiledScript
    {
      public string name
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public string sourceFilePath
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public string lastModifiedTimeUtc
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public byte[] byteCode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CompiledScript(CompiledScriptRecord scriptData) => throw null;
    }
  }
}
