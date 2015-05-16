// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Placeholder to make parser work.</para>
    /// </summary>
    /// <seealso cref="Metadata" />
    public sealed class FolderMetadata : Metadata, enc.IEncodable<FolderMetadata>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FolderMetadata" /> class.</para>
        /// </summary>
        public FolderMetadata()
        {
        }

        #region IEncodable<FolderMetadata> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<FolderMetadata>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        FolderMetadata enc.IEncodable<FolderMetadata>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {

                return this;
            }
        }

        #endregion
    }
}