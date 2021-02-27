using Idle.Core.Models.Fields;
using Idle.Core.Models.Fields.Language;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Player
{
    /// <summary>
    /// Helper for sorting and determining what subtype of field something belongs to, etc
    /// </summary>
    public class FieldInfo
    {
        #region Tool Methods
        public Tools GetTool(Field.Tool tool)
        {
            switch (tool)
            {
                default:
                    return null;
            }

        }

        public Tools GetTool(string tool)
        {
            switch (tool)
            {
                default:
                    return null;
            }

        }

        public bool IsTool(string tool)
        {
            switch (tool)
            {
                default:
                    return false;
            }

        }
        #endregion

        #region Language Methods

        public Languages GetLanguage(Field.Language languauge)
        {
            switch (languauge)
            {
                case Field.Language.Java:
                    return new Java();
                case Field.Language.CSharp:
                    return new CSharp();
                case Field.Language.Kotlin:
                    return new Kotlin();

                default:
                    return null;
            }

        }

        public Languages GetLanguage(string language)
        {
            switch (language)
            {
                case nameof(Java):
                    return new Java();
                case nameof(CSharp):
                    return new CSharp();
                case nameof(Kotlin):
                    return new Kotlin();

                default:
                    return null;
            }

        }

        public bool IsLanguage(string name)
        {
            switch (name)
            {
                case nameof(Java):
                    return true;
                case nameof(CSharp):
                    return true;
                case nameof(Kotlin):
                    return true;
                default:
                    return false;
            }
        }

        #endregion

        #region Framework Methods
        public Frameworks GetFramework(Field.Framework framework)
        {
            switch (framework)
            {
                default:
                    return null;
            }

        }

        public Frameworks GetFramework(string framework)
        {
            switch (framework)
            {
                default:
                    return null;
            }

        }

        public bool IsFramework(string framework)
        {
            switch (framework)
            {
                default:
                    return false;
            }

        }

        #endregion

    }
}
