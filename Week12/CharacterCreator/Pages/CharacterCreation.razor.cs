using CharacterCreator.Models;
using CharacterCreator.Services;
using Microsoft.AspNetCore.Components;

namespace CharacterCreator.Pages
{
    public partial class CharacterCreation : ComponentBase
    {
        [Inject]
        private CharacterService _characterService { get; set; }

        [Inject]
        private NavigationManager NavigationManager { get; set; }

        private Character Character { get; set; } = new Character();

        private void SubmitForm()
        {
            this._characterService.AddCharacter(this.Character);
            NavigationManager.NavigateTo($"/character-details/{this.Character.Id}?createdCharacter={this.Character.Name}");
            this.Character = new Character();
        }
    }
}
