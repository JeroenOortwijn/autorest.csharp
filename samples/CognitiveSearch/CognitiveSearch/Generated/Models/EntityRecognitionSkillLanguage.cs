// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace CognitiveSearch.Models
{
    /// <summary> The language codes supported for input text by EntityRecognitionSkill. </summary>
    public readonly partial struct EntityRecognitionSkillLanguage : IEquatable<EntityRecognitionSkillLanguage>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="EntityRecognitionSkillLanguage"/> values are the same. </summary>
        public EntityRecognitionSkillLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ArValue = "ar";
        private const string CsValue = "cs";
        private const string ZhHansValue = "zh-Hans";
        private const string ZhHantValue = "zh-Hant";
        private const string DaValue = "da";
        private const string NlValue = "nl";
        private const string EnValue = "en";
        private const string FiValue = "fi";
        private const string FrValue = "fr";
        private const string DeValue = "de";
        private const string ElValue = "el";
        private const string HuValue = "hu";
        private const string ItValue = "it";
        private const string JaValue = "ja";
        private const string KoValue = "ko";
        private const string NoValue = "no";
        private const string PlValue = "pl";
        private const string PtValue = "pt-PT";
        private const string PtBRValue = "pt-BR";
        private const string RuValue = "ru";
        private const string EsValue = "es";
        private const string SvValue = "sv";
        private const string TrValue = "tr";

        /// <summary> Arabic. </summary>
        public static EntityRecognitionSkillLanguage Ar { get; } = new EntityRecognitionSkillLanguage(ArValue);
        /// <summary> Czech. </summary>
        public static EntityRecognitionSkillLanguage Cs { get; } = new EntityRecognitionSkillLanguage(CsValue);
        /// <summary> Chinese-Simplified. </summary>
        public static EntityRecognitionSkillLanguage ZhHans { get; } = new EntityRecognitionSkillLanguage(ZhHansValue);
        /// <summary> Chinese-Traditional. </summary>
        public static EntityRecognitionSkillLanguage ZhHant { get; } = new EntityRecognitionSkillLanguage(ZhHantValue);
        /// <summary> Danish. </summary>
        public static EntityRecognitionSkillLanguage Da { get; } = new EntityRecognitionSkillLanguage(DaValue);
        /// <summary> Dutch. </summary>
        public static EntityRecognitionSkillLanguage Nl { get; } = new EntityRecognitionSkillLanguage(NlValue);
        /// <summary> English. </summary>
        public static EntityRecognitionSkillLanguage En { get; } = new EntityRecognitionSkillLanguage(EnValue);
        /// <summary> Finnish. </summary>
        public static EntityRecognitionSkillLanguage Fi { get; } = new EntityRecognitionSkillLanguage(FiValue);
        /// <summary> French. </summary>
        public static EntityRecognitionSkillLanguage Fr { get; } = new EntityRecognitionSkillLanguage(FrValue);
        /// <summary> German. </summary>
        public static EntityRecognitionSkillLanguage De { get; } = new EntityRecognitionSkillLanguage(DeValue);
        /// <summary> Greek. </summary>
        public static EntityRecognitionSkillLanguage El { get; } = new EntityRecognitionSkillLanguage(ElValue);
        /// <summary> Hungarian. </summary>
        public static EntityRecognitionSkillLanguage Hu { get; } = new EntityRecognitionSkillLanguage(HuValue);
        /// <summary> Italian. </summary>
        public static EntityRecognitionSkillLanguage It { get; } = new EntityRecognitionSkillLanguage(ItValue);
        /// <summary> Japanese. </summary>
        public static EntityRecognitionSkillLanguage Ja { get; } = new EntityRecognitionSkillLanguage(JaValue);
        /// <summary> Korean. </summary>
        public static EntityRecognitionSkillLanguage Ko { get; } = new EntityRecognitionSkillLanguage(KoValue);
        /// <summary> Norwegian (Bokmaal). </summary>
        public static EntityRecognitionSkillLanguage No { get; } = new EntityRecognitionSkillLanguage(NoValue);
        /// <summary> Polish. </summary>
        public static EntityRecognitionSkillLanguage Pl { get; } = new EntityRecognitionSkillLanguage(PlValue);
        /// <summary> Portuguese (Portugal). </summary>
        public static EntityRecognitionSkillLanguage Pt { get; } = new EntityRecognitionSkillLanguage(PtValue);
        /// <summary> Portuguese (Brazil). </summary>
        public static EntityRecognitionSkillLanguage PtBR { get; } = new EntityRecognitionSkillLanguage(PtBRValue);
        /// <summary> Russian. </summary>
        public static EntityRecognitionSkillLanguage Ru { get; } = new EntityRecognitionSkillLanguage(RuValue);
        /// <summary> Spanish. </summary>
        public static EntityRecognitionSkillLanguage Es { get; } = new EntityRecognitionSkillLanguage(EsValue);
        /// <summary> Swedish. </summary>
        public static EntityRecognitionSkillLanguage Sv { get; } = new EntityRecognitionSkillLanguage(SvValue);
        /// <summary> Turkish. </summary>
        public static EntityRecognitionSkillLanguage Tr { get; } = new EntityRecognitionSkillLanguage(TrValue);
        /// <summary> Determines if two <see cref="EntityRecognitionSkillLanguage"/> values are the same. </summary>
        public static bool operator ==(EntityRecognitionSkillLanguage left, EntityRecognitionSkillLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EntityRecognitionSkillLanguage"/> values are not the same. </summary>
        public static bool operator !=(EntityRecognitionSkillLanguage left, EntityRecognitionSkillLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EntityRecognitionSkillLanguage"/>. </summary>
        public static implicit operator EntityRecognitionSkillLanguage(string value) => new EntityRecognitionSkillLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EntityRecognitionSkillLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EntityRecognitionSkillLanguage other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
