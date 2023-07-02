// Decompiled with JetBrains decompiler
// Type: KSP.Input.InputLockDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
