using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace Game.Gameplay
{
    public class SkinHandler : MonoBehaviour
    {
        [SerializeField] private Skin skinNow;
        [SerializeField] private Skin[] allSkins;
        [SerializeField] private JellyMesh jellyMesh;

        private Transform _transform;

        public UnityEvent<Skin> OnSkinChanged;

        private void Start()
        {
            _transform = transform;
        }

        public void SetSkin(SkinType skinType)
        {
            Skin skin = allSkins.FirstOrDefault(x => x.SkinType == skinType);
            if (skin == null) return;

            GameObject skinToDestroy = skinNow.SkinObject;
            
            skinNow.SkinObject = Instantiate(skin.SkinObject, Vector3.zero, Quaternion.identity, _transform);
            skinNow.SkinObject.transform.localPosition = Vector3.zero;
            skinNow.SkinType = skinType;
            
            jellyMesh.SetMesh(skinNow.SkinObject);

            Destroy(skinToDestroy);

            OnSkinChanged?.Invoke(skinNow);
        }
    }
}