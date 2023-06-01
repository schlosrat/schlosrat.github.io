// Decompiled with JetBrains decompiler
// Type: KSP.Input.InputLockDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Input
{
  [Serializable]
  public class InputLockDefinition
  {
    public List<InputLockDefinition.InputLock> InputLocks;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputLockDefinition DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputLockDefinition() => throw null;

    [Serializable]
    public class InputLock
    {
      public string DefinitionID;
      public string InputID;
      public bool DefinitionEnabled;
      public bool InputEnabled;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputLockDefinition.InputLock DeepCopy() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public InputLock() => throw null;
    }
  }
}
