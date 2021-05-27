using Idle.Models.Common;

namespace Idle.Models
{
    /// <summary>
    /// Interface that defines descriptive properties.
    /// </summary>
    public interface IDescriptive
    {

        /// <summary>
        /// Name, could be used as the name of a programming language, the name of an in game item, the name of job/buff/project, etc.
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The description of something
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The difficulty of something, could be a language/framework/tool, a job/project, etc
        /// </summary>
        public Difficulty Difficulty { get; }

    }
}
