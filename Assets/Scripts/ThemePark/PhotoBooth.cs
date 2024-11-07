using System;
using TMPro;
using UnityEngine;

public class PhotoBooth : MonoBehaviour
{
    public RenderTexture renderTexture; // Render Texture for capturing the photo
    public Camera photoCamera;          // The specific camera for rendering the photo
    public GameObject displayQuad;      // The Quad to display the photo

    private int photoCount = 0;         // The number of photos taken
    public TextMeshProUGUI photoCountText; // The UI Text to display the photo count

    void Start()
    {
        if (renderTexture == null || photoCamera == null || displayQuad == null)
        {
            Debug.LogError("Render Texture, Camera, or Quad not assigned to PhotoBooth script.");
        }

        MiniCarRideEvent.OnPhotoTaken += IncrementPhotoCounter;

        MiniCarRideEvent.OnPhotoError += PhotoError;
    }

    private void PhotoError()
    {
        Debug.Log("Photo Error");
    }

    public void TakePhoto()
    {
        // The Render Texture in RenderTexture.active is the one
        // that will be read by ReadPixels.
        var currentRT = RenderTexture.active;
        RenderTexture.active = photoCamera.targetTexture;

        // Render the camera's view.
        photoCamera.Render();

        // Make a new texture and read the active Render Texture into it.
        Texture2D image = new Texture2D(photoCamera.targetTexture.width, photoCamera.targetTexture.height);
        image.ReadPixels(new Rect(0, 0, photoCamera.targetTexture.width, photoCamera.targetTexture.height), 0, 0);
        image.Apply();

        // Replace the original active Render Texture.
        RenderTexture.active = currentRT;

        // Apply the image to the displayQuad
        ApplyImageToQuad(image);

    }

    void ApplyImageToQuad(Texture2D image)
    {
        // Create a material with a shader that uses the image as its texture
        Material quadMaterial = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        quadMaterial.mainTexture = image;

        // Apply the material to the Quad
        displayQuad.GetComponent<Renderer>().material = quadMaterial;
    }

    private void IncrementPhotoCounter()
    {
        photoCount++;
        photoCountText.text = photoCount.ToString();
    }

    private void OnDisable()
    {
        MiniCarRideEvent.OnPhotoTaken -= IncrementPhotoCounter;
    }

}
