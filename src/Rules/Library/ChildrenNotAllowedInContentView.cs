// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
using System;
using Axe.Windows.Core.Bases;
using Axe.Windows.Core.Enums;
using Axe.Windows.Rules.Resources;
using static Axe.Windows.Rules.PropertyConditions.BoolProperties;
using static Axe.Windows.Rules.PropertyConditions.ControlType;
using static Axe.Windows.Rules.PropertyConditions.Relationships;

namespace Axe.Windows.Rules.Library
{
    [RuleInfo(ID = RuleId.ChildrenNotAllowedInContentView)]
    class ChildrenNotAllowedInContentView : Rule
    {
        public ChildrenNotAllowedInContentView()
        {
            this.Info.Description = Descriptions.ChildrenNotAllowedInContentView;
            this.Info.HowToFix = HowToFix.ChildrenNotAllowedInContentView;
            this.Info.Standard = A11yCriteriaId.ObjectInformation;
            this.Info.ErrorCode = EvaluationCode.Error;
        }

        public override bool PassesTest(IA11yElement e)
        {
            if (e == null) throw new ArgumentNullException(nameof(e));

            return NoChild(IsContentElement).Matches(e);
        }

        protected override Condition CreateCondition()
        {
            return Separator;
        }
    } // class
} // namespace
