using MelonLoader;
using UnityEngine;

namespace FreeLookInCars
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log($"[{InfoAttribute.Name}] Version {InfoAttribute.Version} loaded!");
        }
    }
}
