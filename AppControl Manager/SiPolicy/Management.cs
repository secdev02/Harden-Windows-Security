﻿using System;
using System.Xml;
using System.Xml.Serialization;

namespace AppControlManager.SiPolicy;

internal static class Management
{

	/// <summary>
	/// This class uses the auto-generated code from the XSD schema to initialize the SiPolicy object
	/// By accepting a string path to a valid XML file
	///
	/// Generated by the following command:
	/// . "C:\Program Files (x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools\x64\xsd.exe" "C:\Windows\schemas\CodeIntegrity\cipolicy.xsd" /classes /namespace:AppControlManager.SiPolicy /language:CS
	/// </summary>
	/// <param name="xmlFilePath"></param>
	/// <returns></returns>
	/// <exception cref="InvalidOperationException"></exception>
	internal static SiPolicy Initialize(string xmlFilePath)
	{
		if (!(bool)CiPolicyTest.TestCiPolicy(xmlFilePath, null)!)
		{
			throw new InvalidOperationException($"The XML file '{xmlFilePath}' is not compliant with the CI policy schema");
		}


		XmlSerializer serializer = new(typeof(SiPolicy));

		// Use XmlReader with secure settings
		XmlReaderSettings settings = new()
		{
			DtdProcessing = DtdProcessing.Prohibit, // Disable DTD processing
			XmlResolver = null,                     // Prevent external entity resolution
			Async = true // Async
		};

		using XmlReader reader = XmlReader.Create(xmlFilePath, settings);

		if (serializer.Deserialize(reader) is not SiPolicy policy)
		{
			throw new InvalidOperationException($"Could not instantiate the XML file '{xmlFilePath}'");
		}

		return policy;

	}



	/// <summary>
	/// An overload of the primary method, accepts XmlDocument instead of file path
	/// </summary>
	/// <param name="xmlDocument"></param>
	/// <returns></returns>
	/// <exception cref="InvalidOperationException"></exception>
	internal static SiPolicy Initialize(XmlDocument xmlDocument)
	{

		// Create the XmlSerializer for the SiPolicy type
		XmlSerializer serializer = new(typeof(SiPolicy));

		// Configure XmlReaderSettings for secure processing
		XmlReaderSettings settings = new()
		{
			DtdProcessing = DtdProcessing.Prohibit, // Disable DTD processing to avoid external entity attacks
			XmlResolver = null,                     // Prevent external entity resolution
			Async = true                            // Enable asynchronous reading
		};


		// Create an XmlReader from the XmlDocument to read it securely
		using XmlNodeReader xml = new(xmlDocument);

		using XmlReader reader = XmlReader.Create(xml, settings);

		// Deserialize the XML data into an instance of SiPolicy
		if (serializer.Deserialize(reader) is not SiPolicy policy)
		{
			throw new InvalidOperationException("Could not instantiate the SiPolicy from the provided XML document.");
		}

		// Return the deserialized SiPolicy object
		return policy;
	}




	/// <summary>
	/// Saves the SiPolicy object to a XML file
	/// </summary>
	/// <param name="policy"></param>
	/// <param name="filePath"></param>
	internal static void SavePolicyToFile(SiPolicy policy, string filePath)
	{
		XmlSerializer serializer = new(typeof(SiPolicy));

		// Create XmlSerializerNamespaces to include only the desired namespace
		XmlSerializerNamespaces namespaces = new();
		namespaces.Add(string.Empty, "urn:schemas-microsoft-com:sipolicy"); // Default namespace without prefix

		XmlWriterSettings settings = new()
		{
			Indent = true,                // Format the XML for readability
			NewLineOnAttributes = false,  // Keep attributes on the same line
			Async = true,                 // Async support for better performance with large files
			OmitXmlDeclaration = false,   // Include the XML declaration
			Encoding = System.Text.Encoding.UTF8 // Ensure UTF-8 encoding
		};

		using XmlWriter writer = XmlWriter.Create(filePath, settings);
		serializer.Serialize(writer, policy, namespaces);
	}


}
