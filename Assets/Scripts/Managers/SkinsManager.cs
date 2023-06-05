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
            if (skinLockedStates.Count != allSkins.Count) 
                throw new Exception("Skins initializing is wrong");

            for (int i = 0; i < skinLockedStates.Count; i++)
                allSkins[i].IsLocked = skinLockedStates[i];
            
            Skin skin = allSkins.FirstOrDefault(x => x.Type == skinNowType);
            
            SetSkinObject(skin);
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