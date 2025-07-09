using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Alloy.Models.Blocks
{
    [ContentType(DisplayName = "HTML Text Block", GUID = "d1234567-89ab-4cde-8123-456789abcdef", Description = "Block to render custom HTML content")]
    public class HtmlTextBlock : BlockData
    {
        [Display(Name = "HTML Content", Order = 10)]
        public virtual XhtmlString HtmlContent { get; set; }

        [Display(Name = "Team", Order = 20)]
        [SelectOne(SelectionFactoryType = typeof(TeamSelectionFactory))]
        public virtual string Team { get; set; }
    }

    public class TeamSelectionFactory : ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            return new[]
            {
                new SelectItem { Text = "Alpha", Value = "Alpha" },
                new SelectItem { Text = "Bravo", Value = "Bravo" },
                new SelectItem { Text = "Charlie", Value = "Charlie" }
            };
        }
    }
}
