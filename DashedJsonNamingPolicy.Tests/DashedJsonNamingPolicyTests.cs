// <copyright file="DashedJsonNamingPolicyTests.cs" company="Balazs Keresztury">
// Copyright (c) Balazs Keresztury. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

using NUnit.Framework;

namespace DashedJsonNamingPolicy.Tests
{
    /// <summary>
    /// Tests for the DashedJsonNamingPolicy class.
    /// </summary>
    public class DashedJsonNamingPolicyTests
    {
        private DashedJsonNamingPolicy policy;

        /// <summary>
        /// Setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.policy = new DashedJsonNamingPolicy();
        }

        /// <summary>
        /// Tests a name which contain a single word.
        /// </summary>
        [Test]
        public void SingleWord()
        {
            Assert.That(this.policy.ConvertName("Enabled"), Is.EqualTo("enabled"));
        }

        /// <summary>
        /// Tests a name which contain two words.
        /// </summary>
        [Test]
        public void TwoWords()
        {
            Assert.That(this.policy.ConvertName("IsEnabled"), Is.EqualTo("is-enabled"));
        }

        /// <summary>
        /// Tests a name which contain three words.
        /// </summary>
        [Test]
        public void ThreeWords()
        {
            Assert.That(this.policy.ConvertName("IsAlreadyEnabled"), Is.EqualTo("is-already-enabled"));
        }

        /// <summary>
        /// Tests a name where one or more words contain two uppercase letters.
        /// </summary>
        [Test]
        public void TwoUppercaseLetters()
        {
            Assert.That(this.policy.ConvertName("IOSpeed"), Is.EqualTo("io-speed"));
        }

        /// <summary>
        /// Tests a name where one or more words contain more than two uppercase letters.
        /// </summary>
        [Test]
        public void MultipleUppercaseLetters()
        {
            Assert.That(this.policy.ConvertName("IOPSCount"), Is.EqualTo("iops-count"));
        }
    }
}