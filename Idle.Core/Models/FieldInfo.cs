using Idle.Core.Models.Fields;
using Idle.Core.Models.Fields.Framework;
using Idle.Core.Models.Fields.Language;
using Idle.Core.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Item;

namespace Idle.Core.Models.Player
{
    /// <summary>
    /// Helper for sorting and determining what subtype of field something belongs to, etc
    /// Items as well
    /// </summary>
    public class FieldInfo
    {

        #region Item Methods

        public Item GetItem(ItemType item)
        {
            switch (item)
            {
                case ItemType.GitHubEnterprise:
                    return new GithubEnterprise();
                case ItemType.GitHubOne:
                    return new GithubOne();
                case ItemType.GitHubPro:
                    return new GithubPro();
                case ItemType.GitHubTeam:
                    return new GithubTeam();
                default:
                    return null;
            }

        }

        public Item GetItem(ItemType item, int amount)
        {
            switch (item)
            {
                case ItemType.GitHubEnterprise:
                    return new GithubEnterprise() { Amount = amount };
                case ItemType.GitHubOne:
                    return new GithubOne() { Amount = amount };
                case ItemType.GitHubPro:
                    return new GithubPro() { Amount = amount };
                case ItemType.GitHubTeam:
                    return new GithubTeam() { Amount = amount };
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

        //IsTool and the other Isfunctions as obsolete
        public bool IsTool(Field.Tool tool)
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

        public bool IsLanguage(Field.Language languauge)
        {
            switch (languauge)
            {
                case Field.Language.Java:
                    return true;
                case Field.Language.CSharp:
                    return true;
                case Field.Language.Kotlin:
                    return true;
                case Field.Language.Python:
                    return true;
                case Field.Language.JavaScript:
                    return true;
                case Field.Language.HTML:
                    return true;
                case Field.Language.CSS:
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
                case Field.Framework.BootStrap:
                    return new BootStrap();
                case Field.Framework.Flutter:
                    return new Flutter();
                case Field.Framework.Xamarin:
                    return new Xamarin();
                case Field.Framework.LibGDX:
                    return new LibGDX();
                default:
                    return null;
            }

        }

        public bool IsFramework(Field.Framework framework)
        {
            switch (framework)
            {
                case Field.Framework.BootStrap:
                    return true;
                case Field.Framework.Flutter:
                    return true;
                case Field.Framework.Xamarin:
                    return true;
                case Field.Framework.LibGDX:
                    return true;
                default:
                    return false;
            }

        }



        #endregion

    }
}
