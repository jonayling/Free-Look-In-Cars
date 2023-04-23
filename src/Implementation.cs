using MelonLoader;
using UnityEngine;

namespace FreeLookInCars
{
    internal class Implementation : MelonMod 
    {

        public override void OnInitializeMelon()
        {
            Debug.Log($"[{Info.Name}] version {Info.Version} loaded");
            new MelonLogger.Instance($"{Info.Name}").Msg($"Version {Info.Version} loaded");
        }
    }
}
