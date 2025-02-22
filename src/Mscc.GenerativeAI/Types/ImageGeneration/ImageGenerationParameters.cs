namespace Mscc.GenerativeAI
{
    /// <summary>
    /// 
    /// </summary>
    public class ImageGenerationParameters
    {
        /// <summary>
        /// The number of generated images.
        /// </summary>
        /// <remarks>Accepted integer values: 1-8 (v.002), 1-4 (v.005, v.006). Default value: 4.</remarks>
        public int? SampleCount { get; set; }

        /// <summary>
        /// Optional. Cloud Storage uri where to store the generated images.
        /// </summary>
        public string? StorageUri { get; set; }

        /// <summary>
        /// Optional. Pseudo random seed for reproducible generated outcome; setting the seed lets you generate deterministic output.
        /// </summary>
        /// <remarks>Version 006 model only: To use the seed field you must also set "addWatermark": false in the list of parameters.</remarks>
        public int? Seed { get; set; }
        
        /// <summary>
        /// Optional. The text prompt for guiding the response.
        /// </summary>
        /// <remarks>en (default), de, fr, it, es</remarks>
        public string? Language { get; set; }

        /// <summary>
        /// Optional. Prompt strings that force something not to be generated.
        /// </summary>
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Optional. For model version 006 and greater use editConfig.guidanceScale.
        /// </summary>
        /// <remarks>
        /// Controls how much the model adheres to the text prompt.
        /// Large values increase output and prompt alignment, but may compromise image quality.
        /// </remarks>
        public int? GuidanceScale { get; set; }

        /// <summary>
        /// Optional. Whether to disable the person/face safety filter (so that person/face can be included in the generated images).
        /// </summary>
        /// <remarks>Deprecated (v.006 only): Use personGeneration instead.</remarks>
        public bool? DisablePersonFace { get; set; }

        /// <summary>
        /// Optional. With input prompt, image, mask - backgroundEditing mode enables background editing.
        /// </summary>
        /// <remarks>Values:
        /// backgroundEditing
        /// upscale
        /// </remarks>
        public string? Mode { get; set; }

        /// <summary>
        /// Optional. Sample image size when mode is set to upscale. This field is no longer required when upscaling. Use upscaleConfig.upscaleFactor to set the upscaled image size.
        /// </summary>
        /// <remarks>2048 or 4096</remarks>
        public string? SampleImageSize { get; set; }

        /// <summary>
        /// Optional. The aspect ratio of the generated image.
        /// </summary>
        /// <remarks>Value: 1:1, 9:16*, 16:9*, 3:4*, or 4:3*</remarks>
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Optional. Whether to enable the Responsible AI filtered reason or error code for blocked output in the response content.
        /// </summary>
        public bool? IncludeRaiReason { get; set; }

        /// <summary>
        /// Optional. Whether to enable rounded Responsible AI scores for a list of safety attributes in responses for unfiltered input and output.
        /// </summary>
        /// <remarks>Safety attribute categories: "Death, Harm and Tragedy", "Firearms and Weapons", "Hate", "Health", "Illicit Drugs", "Politics", "Porn", "Religion and Belief", "Toxic", "Violence", "Vulgarity", "War and Conflict".</remarks>
        public bool? IncludeSafetyAttributes { get; set; }

        /// <summary>
        /// Optional. The safety setting that controls the type of people or face generation allowed.
        /// </summary>
        /// <remarks>"personGeneration": "allow_all" is not available in Imagen 2 Editing and is only available to approved users‡ in Imagen 2 Generation.
        /// Values:
        /// allow_all: Allow generation of people of all ages.
        /// allow_adult (default): Allow generation of adults only.
        /// dont_allow: Disables the inclusion of people or faces in images.
        /// </remarks>
        public string? PersonGeneration { get; set; }

        /// <summary>
        /// Optional. The safety setting that controls safety filter thresholds.
        /// </summary>
        /// <remarks>Values:
        /// block_most: The highest threshold resulting in most requests blocked.
        /// block_some (default): The medium threshold that balances blocks for potentially harmful and benign content.
        /// block_few: Reduces the number of requests blocked due to safety filters. This setting might increase objectionable content generated by Imagen.
        /// </remarks>
        public string? SafetySetting { get; set; }

        /// <summary>
        /// Defines whether the image will include a SynthID. For more information, see Identifying AI-generated content with SynthID.
        /// </summary>
        public bool? AddWatermark { get; set; }

        /// <summary>
        /// edit config object for model versions 006 and greater. All editConfig subfields are optional. If not specified, the default editing mode is inpainting.
        /// </summary>
        public EditConfig? EditConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public UpscaleConfig? UpscaleConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public OutputOptions? OutputOptions { get; set; }
    }
}