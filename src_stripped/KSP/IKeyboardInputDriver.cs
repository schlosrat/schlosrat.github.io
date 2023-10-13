// Decompiled with JetBrains decompiler
// Type: KSP.IKeyboardInputDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using UnityEngine;

namespace KSP
{
  public interface IKeyboardInputDriver
  {
    bool GetKey(KeyCode key);

    bool GetKeyDown(KeyCode key);

    bool GetKeyUp(KeyCode key);
  }
}
