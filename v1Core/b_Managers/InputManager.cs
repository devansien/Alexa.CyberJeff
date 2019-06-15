using Alexa.NET.Request;
using System;

namespace CyberJeff
{
    class InputManager : Core
    {
        public static string GetInputValue(string slotName)
        {
            string value;

            if (Input.GetIntentRequest().Intent.Slots.ContainsKey(slotName))
            {
                Slot slot = Input.GetIntentRequest().Intent.Slots[slotName];

                if (!string.IsNullOrEmpty(slot.Value))
                {
                    Utterance utterance = new Utterance { Input = slot.Value, Time = DateTime.UtcNow };
                    State.Utterances.Add(utterance);
                }

                try
                {
                    ResolutionAuthority[] resolution = slot.Resolution.Authorities;
                    ResolutionValueContainer[] container = resolution[0].Values;
                    value = container[0].Value.Name;
                    Logger.Write($"Processed input value from user: [{value}]");

                    return value;
                }
                catch
                {
                    value = slot.Value;
                    Logger.Write($"Raw input value from user: [{value}]");

                    return value;
                }
            }

            return null;
        }
    }
}
