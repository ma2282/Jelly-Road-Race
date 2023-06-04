using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScreenshotManager : MonoBehaviour
{
    [SerializeField] private Camera screenshotCamera;
    [SerializeField] private int width;
    [SerializeField] private int height;
    [SerializeField] private Color backgroundColor = Color.green;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 24);
            screenshotCamera.targetTexture = renderTexture;

            Texture2D screenshotTexture = new (width, height, TextureFormat.RGB24, false);
            screenshotCamera.Render();

            RenderTexture.active = renderTexture;
            screenshotTexture.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            screenshotTexture.Apply();
            
            for (int x = 0; x < screenshotTexture.width; x++)
                for (int y = 0; y < screenshotTexture.height; y++)
                    if (screenshotTexture.GetPixel(x, y) == backgroundColor)
                        screenshotTexture.SetPixel(x, y, Color.clear);
            
            screenshotTexture.Apply();

            byte[] bytes = screenshotTexture.EncodeToPNG();
            Destroy(screenshotTexture);

            string filename = "screenshot_" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";
            File.WriteAllBytes(Application.dataPath + "/" + filename, bytes);

            screenshotCamera.targetTexture = null;
            RenderTexture.active = null;
            RenderTexture.ReleaseTemporary(renderTexture);
        }
    }
}
