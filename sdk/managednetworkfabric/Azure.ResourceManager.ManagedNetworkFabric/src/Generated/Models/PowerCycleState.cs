// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> On or Off power cycle state. </summary>
    public readonly partial struct PowerCycleState : IEquatable<PowerCycleState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PowerCycleState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PowerCycleState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OnValue = "On";
        private const string OffValue = "Off";

        /// <summary> On. </summary>
        public static PowerCycleState On { get; } = new PowerCycleState(OnValue);
        /// <summary> Off. </summary>
        public static PowerCycleState Off { get; } = new PowerCycleState(OffValue);
        /// <summary> Determines if two <see cref="PowerCycleState"/> values are the same. </summary>
        public static bool operator ==(PowerCycleState left, PowerCycleState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PowerCycleState"/> values are not the same. </summary>
        public static bool operator !=(PowerCycleState left, PowerCycleState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PowerCycleState"/>. </summary>
        public static implicit operator PowerCycleState(string value) => new PowerCycleState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PowerCycleState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PowerCycleState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
