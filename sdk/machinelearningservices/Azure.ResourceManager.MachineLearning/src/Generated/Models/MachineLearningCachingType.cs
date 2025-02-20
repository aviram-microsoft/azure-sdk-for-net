// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Caching type of Data Disk.
    /// Serialized Name: Caching
    /// </summary>
    public readonly partial struct MachineLearningCachingType : IEquatable<MachineLearningCachingType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningCachingType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningCachingType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ReadOnlyValue = "ReadOnly";
        private const string ReadWriteValue = "ReadWrite";

        /// <summary>
        /// None
        /// Serialized Name: Caching.None
        /// </summary>
        public static MachineLearningCachingType None { get; } = new MachineLearningCachingType(NoneValue);
        /// <summary>
        /// ReadOnly
        /// Serialized Name: Caching.ReadOnly
        /// </summary>
        public static MachineLearningCachingType ReadOnly { get; } = new MachineLearningCachingType(ReadOnlyValue);
        /// <summary>
        /// ReadWrite
        /// Serialized Name: Caching.ReadWrite
        /// </summary>
        public static MachineLearningCachingType ReadWrite { get; } = new MachineLearningCachingType(ReadWriteValue);
        /// <summary> Determines if two <see cref="MachineLearningCachingType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningCachingType left, MachineLearningCachingType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningCachingType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningCachingType left, MachineLearningCachingType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningCachingType"/>. </summary>
        public static implicit operator MachineLearningCachingType(string value) => new MachineLearningCachingType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningCachingType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningCachingType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
