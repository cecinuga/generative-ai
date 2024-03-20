﻿#if NET472_OR_GREATER || NETSTANDARD2_0
using System.Text.Json.Serialization;
#endif

namespace Mscc.GenerativeAI
{
    /// <summary>
    /// The category of a rating.
    /// Ref: https://ai.google.dev/api/rest/v1beta/HarmCategory
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<HarmCategory>))]
    public enum HarmCategory
    {
        /// <summary>
        /// HarmCategoryUnspecified means the harm category is unspecified.
        /// </summary>
        HarmCategoryUnspecified = 0,
        /// <summary>
        /// HarmCategoryHateSpeech means the harm category is hate speech.
        /// </summary>
        HarmCategoryHateSpeech = 1,
        /// <summary>
        /// HarmCategoryDangerousContent means the harm category is dangerous content.
        /// </summary>
        HarmCategoryDangerousContent = 2,
        /// <summary>
        /// HarmCategoryHarassment means the harm category is harassment.
        /// </summary>
        HarmCategoryHarassment = 3,
        /// <summary>
        /// HarmCategorySexuallyExplicit means the harm category is sexually explicit content.
        /// </summary>
        HarmCategorySexuallyExplicit = 4
        
        // // Negative or harmful comments targeting identity and/or protected attribute.
        // HarmCategoryDerogatory = 1
        // // Content that is rude, disrespectful, or profane.
        // HarmCategoryToxicity = 2
        // // Describes scenarios depicting violence against an individual or group, or general descriptions of gore.
        // HarmCategoryViolence = 3
        // // Contains references to sexual acts or other lewd content.
        // HarmCategorySexual = 4
        // // Promotes unchecked medical advice.
        // HarmCategoryMedical = 5
        // // Dangerous content that promotes, facilitates, or encourages harmful acts.
        // HarmCategoryDangerous = 6
    }
}
