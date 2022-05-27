using MelonLoader;
using System.Collections;
using UI2Enabler;
using UnityEngine;

[assembly: MelonInfo(typeof(UI2EnablerMod), "UI2Enabler", "1.0.0", "Sarayalth")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace UI2Enabler
{
    public class UI2EnablerMod : MelonMod
    {
        public override void OnApplicationStart()
        {
            MelonCoroutines.Start(UiThingie());
        }

        private IEnumerator UiThingie()
        {
            while (GameObject.Find("UserInterface/UnscaledUI/HudContent_Old") == null)
                yield return null;

            var OldHUD = GameObject.Find("UserInterface/UnscaledUI/HudContent_Old");
            var NewHUD = GameObject.Find("UserInterface/UnscaledUI/HudContent");

            if (NewHUD != null)
            {
                OldHUD.SetActive(false);
                NewHUD.SetActive(true);
            }
        }
    }
}
