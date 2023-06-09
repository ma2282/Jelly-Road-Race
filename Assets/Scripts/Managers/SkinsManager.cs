using System;
using System.Collections.Generic;
using System.Linq;
using NTC.Global.System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class SkinsManager : Singleton<SkinsManager>
    {
        [SerializeField] private List<Skin> allSkins;
        [SerializeField] private Transform skinParentTransform;

        private SkinObject _skinNow;
        
        public UnityEvent<ReadonlySkin> OnSkinChanged;

        public int SkinsCount => allSkins.Count;
        
        
        public void InitializeSkins(List<bool> skinLockedStates, SkinType skinNowType)
        {
            Skin savedSkin = allSkins.FirstOrDefault(x => x.Type == skinNowType) ?? allSkins[0];

            SetSkinObject(savedSkin);
            
            for (int i = 0; i < allSkins.Count; i++)
                allSkins[i].IsLocked = skinLockedStates.Count < allSkins.Count || skinLockedStates[i];
            allSkins[0].IsLocked = false;
        }
        
        private void SetSkinObject(Skin skin)
        {
            if (skin == null) return;

            if (_skinNow != null)
                Destroy(_skinNow.gameObject);
            
            _skinNow = Instantiate(skin.Prefab, skinParentTransform);

            OnSkinChanged?.Invoke(new ReadonlySkin(skin, _skinNow));
        }

        public ReadonlySkin GetSkin(int index) => new (allSkins[index]);
        
        public void SetSkin(int skinNowIndex)
        {
            SetSkinObject(allSkins[skinNowIndex]);
        }

        public void UnlockSkin(int index) => allSkins[index].IsLocked = false;

        public SaveData Save()
        {
            SaveData data = new (){SkinLockedStates = allSkins.Select(x => x.IsLocked).ToList(), SkinNowType = _skinNow.Type};

            return data;
        }
    }
}