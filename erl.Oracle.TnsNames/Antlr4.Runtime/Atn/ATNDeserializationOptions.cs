// Copyright (c) Terence Parr, Sam Harwell. All Rights Reserved.
// Licensed under the BSD License. See LICENSE.txt in the project root for license information.

using System;
using erl.Oracle.TnsNames.Antlr4.Runtime.Misc;
using erl.Oracle.TnsNames.Antlr4.Runtime.Sharpen;

namespace erl.Oracle.TnsNames.Antlr4.Runtime.Atn
{
    /// <author>Sam Harwell</author>
    public class ATNDeserializationOptions
    {
        private static readonly erl.Oracle.TnsNames.Antlr4.Runtime.Atn.ATNDeserializationOptions defaultOptions;

        static ATNDeserializationOptions()
        {
            defaultOptions = new erl.Oracle.TnsNames.Antlr4.Runtime.Atn.ATNDeserializationOptions();
            defaultOptions.MakeReadOnly();
        }

        private bool readOnly;

        private bool verifyATN;

        private bool generateRuleBypassTransitions;

        private bool optimize;

        public ATNDeserializationOptions()
        {
            this.verifyATN = true;
            this.generateRuleBypassTransitions = false;
            this.optimize = true;
        }

        public ATNDeserializationOptions(erl.Oracle.TnsNames.Antlr4.Runtime.Atn.ATNDeserializationOptions options)
        {
            this.verifyATN = options.verifyATN;
            this.generateRuleBypassTransitions = options.generateRuleBypassTransitions;
            this.optimize = options.optimize;
        }

        [NotNull]
        public static erl.Oracle.TnsNames.Antlr4.Runtime.Atn.ATNDeserializationOptions Default
        {
            get
            {
                return defaultOptions;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return readOnly;
            }
        }

        public void MakeReadOnly()
        {
            readOnly = true;
        }

        public bool VerifyAtn
        {
            get
            {
                return verifyATN;
            }
            set
            {
                bool verifyATN = value;
                ThrowIfReadOnly();
                this.verifyATN = verifyATN;
            }
        }

        public bool GenerateRuleBypassTransitions
        {
            get
            {
                return generateRuleBypassTransitions;
            }
            set
            {
                bool generateRuleBypassTransitions = value;
                ThrowIfReadOnly();
                this.generateRuleBypassTransitions = generateRuleBypassTransitions;
            }
        }

        public bool Optimize
        {
            get
            {
                return optimize;
            }
            set
            {
                bool optimize = value;
                ThrowIfReadOnly();
                this.optimize = optimize;
            }
        }

        protected internal virtual void ThrowIfReadOnly()
        {
            if (IsReadOnly)
            {
                throw new InvalidOperationException("The object is read only.");
            }
        }
    }
}