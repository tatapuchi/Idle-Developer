using Idle.Core.Models.Fields;
using Idle.Core.Models.Fields.Language;
using Idle.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idle.Core.Models.Player
{
    /// <summary>
    /// Helper for sorting and determining what subtype of field something belongs to, etc
    /// Items as well
    /// </summary>
    public class FieldInfo
    {

        #region Item Methods
        public Item GetItem(string item)
        {
            switch (item)
            {
                case nameof(GithubEnterprise):
                    return new GithubEnterprise();
                default:
                    return null;
            }

        }
        #endregion

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
                case Field.Language.Python:
                    return new Python();
                case Field.Language.JavaScript:
                    return new JavaScript();
                case Field.Language.HTML:
                    return new HTML();
                case Field.Language.CSS:
                    return new CSS();

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
                case nameof(Python):
                    return new Python();
                case nameof(JavaScript):
                    return new JavaScript();
                case nameof(HTML):
                    return new HTML();
                case nameof(CSS):
                    return new CSS();

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
                case nameof(Python):
                    return true;
                case nameof(JavaScript):
                    return true;
                case nameof(HTML):
                    return true;
                case nameof(CSS):
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
