// Decompiled with JetBrains decompiler
// Type: KSP.Messages.IMessageCenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

namespace KSP.Messages
{
  public interface IMessageCenter
  {
    void Publish<T>(T message) where T : MessageCenterMessage;

    void Publish<T>() where T : MessageCenterMessage, new();

    T CreateMessage<T>() where T : MessageCenterMessage, new();
  }
}
