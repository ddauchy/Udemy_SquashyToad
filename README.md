# Udemy_SquashyToad

Built on Ubuntu Gnome 16.10 and Unity Unity 5.5.0xb5Linux 

This is my work going through Section 3 of the Udemy.com couse "Make Mobile VR Games in Unity with C#  for Google Cardboard | Udemy."
Here's a link to the course - https://www.udemy.com/vrcourse/

In linux you get the following error all the time:

####Linux Compatibility Issues
1.) Spatial Audio  
  
  * Error: "Effect GVR Audio Renderer could not be found. Check that the project contains the correct native audio plugin libraries and that the importer settings are set up correctly."
  * You also can not select the GVR Audio Spatializer plugin in the Project settings, Audio, Spatializer Plugin option.  
  * No audio will play when you press the play button
  * ####Workaround: 
    1. As normal, you attach the GVRAudioListener script to your camera
    2. and Use the GvrAudioSource prefab for all of your audio
    3. Build to your android device and when you play through the game you'll hear the spatial audio effects.
