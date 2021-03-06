﻿namespace FluentTerminal.Models
{
    public static class MessageTypes
    {
        public static string CreateTerminalRequest => nameof(CreateTerminalRequest);

        public static string CreateTerminalResponse => nameof(CreateTerminalResponse);

        public static string ResizeTerminalRequest => nameof(ResizeTerminalRequest);

        public static string SetToggleWindowKeyBindingsRequest => nameof(SetToggleWindowKeyBindingsRequest);
    }
}
