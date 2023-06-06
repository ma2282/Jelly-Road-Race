using System;
using System.Collections.Generic;
using System.Linq;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Gameplay
{
    public class SkinsManager : Singleton<SkinsManager>
    {
        [SerializeField] private Skin skinNow;
        [SerializeField] private List<Skin> allSkins;
        [SerializeField] private Transform skinParentTransform;

        public UnityEvent<ReadonlySkin> OnSkinChanged;

        public void InitializeSkins(List<bool> skinLockedStates, SkinType skinNowType)
        {
            Skin skin = allSkins.FirstOrDefault(x => x.Type == skinNowType) ?? allSkins[0];

            SetSkinObject(skin);
            
            for (int i = 0; i < allSkins.Count; i++)
                allSkins[i].IsLocked = skinLockedStates.Count < allSkins.Count || skinLockedStates[i];
            allSkins[0].IsLocked = false;
        }
        
        private void SetSkinObject(Skin skin)
        {
            if (skin == null) return;

            GameObject skinToDestroy = skinNow.Object;
            
            skinNow.Object = Instantiate(skin.Object, Vector3.zero, Quaternion.identity, skinParentTransform);
            skinNow.Object.transform.localPosition = Vector3.zero;
            skinNow.Type = skin.Type;

            if (skinToDestroy != null)
                Destroy(skinToDestroy);

            OnSkinChanged?.Invoke(new ReadonlySkin(skinNow));
        }

        public ReadonlySkin GetSkin(int index) => new (allSkins[index]);
        
        public void SetSkin(int skinNowIndex)
        {
            SetSkinObject(allSkins[skinNowIndex]);
        }

        public void UnlockSkin(int index) => allSkins[index].IsLocked = false;

        public SaveData Save()
        {
            SaveData data = new (){SkinLockedStates = allSkins.Select(x => x.IsLocked).ToList(), SkinNowType = skinNow.Type};

            return data;
        }
    }
}