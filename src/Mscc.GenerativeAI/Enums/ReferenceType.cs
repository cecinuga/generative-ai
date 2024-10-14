#if NET472_OR_GREATER || NETSTANDARD2_0
using System.Text.Json.Serialization;
#endif

namespace Mscc.GenerativeAI
{
    /// <summary>
    /// Describes what the field reference contains.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter<ReferenceType>))]
    public enum ReferenceType
    {
        /// <summary>
        /// Reference contains a GFS path or a local path.
        /// </summary>
        Path,
        /// <summary>
        /// Reference points to a blobstore object. This could be either a v1 blob_ref or a v2 blobstore2_info. Clients should check blobstore2_info first, since v1 is being deprecated.
        /// </summary>
        BlobRef,
        /// <summary>
        /// Data is included into this proto buffer.
        /// </summary>
        Inline,
        /// <summary>
        /// Data should be accessed from the current service using the operation GetMedia.
        /// </summary>
        GetMedia,
        /// <summary>
        /// The content for this media object is stored across multiple partial media objects under the composite_media field.
        /// </summary>
        CompositeMedia,
        /// <summary>
        /// Reference points to a bigstore object.
        /// </summary>
        BigstoreRef,
        /// <summary>
        /// Indicates the data is stored in diff_version_response.
        /// </summary>
        DiffVersionResponse,
        /// <summary>
        /// Indicates the data is stored in diff_checksums_response.
        /// </summary>
        DiffChecksumResponse,
        /// <summary>
        /// Indicates the data is stored in diff_download_response.
        /// </summary>
        DiffDownloadResponse,
        /// <summary>
        /// Indicates the data is stored in diff_upload_request.
        /// </summary>
        DiffUploadRequest,
        /// <summary>
        /// Indicates the data is stored in diff_upload_response.
        /// </summary>
        DiffUploadResponse,
        /// <summary>
        /// Indicates the data is stored in cosmo_binary_reference.
        /// </summary>
        CosmoBinaryReference,
        /// <summary>
        /// Informs Scotty to generate a response payload with the size specified in the length field.
        /// The contents of the payload are generated by Scotty and are undefined.
        /// This is useful for testing download speeds between the user and Scotty
        /// without involving a real payload source. Note: range is not supported when using arbitrary_bytes.
        /// </summary>
        ArbitraryBytes
    }
}