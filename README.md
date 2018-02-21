# LocalisationTest

There are some steps required to use the translation utilities from a VS2017 project.

1. Setup a Translator text API service (Cognitive Services) in the Azure portal. The free tier is fine. This will provide you with a couple of API keys that need to be registered with Windows in step #2.

2. Open the Credentials Manager - create a generic Windows Credential:

	Internet or Network address		Multilingual/MicrosoftTranslator
	Username						Multilingual App Toolkit
	Password						One of the API keys
	
3. Install the standalone Multilingual editor which needs to be at least v4.0.1810 to use the credential created in step #2

4. Add the VS2017 Multilingual app toolkit

5. Enable the toolkit in the project containing the translations

6. Add a resource folder in the .NET standard project and add a resources file called AppResources

7. In the project properties --> Package make sure you set the assembly neutral language

8. Right-click on the project and from the Multilingual App Toolkit menu add requuired languages. This should create the resx files for the other languages and a new folder containing the translation files used by the editor

9. Add the translate extension class into a helpers folder which is used to bind the XAML to the resource

10. Set the culture in the app (see app.xaml.cs). This can be hard-coded to a culture or just use the device culture

11. Add resources and translate!
