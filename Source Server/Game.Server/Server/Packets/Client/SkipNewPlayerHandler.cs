﻿// Decompiled with JetBrains decompiler
// Type: Game.Server.Packets.Client.SkipNewPlayerHandler
// Assembly: Game.Server, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7994645F-6854-4AAC-A332-C61842D2DD9F
// Assembly location: C:\Users\Pham Van Hungg\Desktop\Decompiler\Road\Game.Server.dll

using Game.Base.Packets;

namespace Game.Server.Packets.Client
{
  [PacketHandler(257, "Skip new player tutorial")]
  public class SkipNewPlayerHandler : IPacketHandler
  {
    public int HandlePacket(GameClient client, GSPacketIn packet)
    {
      return 1;
    }
  }
}
