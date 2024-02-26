

namespace Sortable_WPF
{
    /// <summary>
    /// User data sort listview table
    /// </summary>
    public class User
    {
        /// <summary>
        /// Name to use for our sorted table
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age to use for our sorted table
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// email to use for our sorted table
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Gender to use for sorted table
        /// </summary>
        public SexType Sex { get; set; }
        /// <summary>
        /// Place of birth 
        /// </summary>
        public string PlaceOfBirth { get; set; }

    }
}
