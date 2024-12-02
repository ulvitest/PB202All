using Academy.Service.Services;

namespace Academy.App.Controllers
{
    internal class GroupController
    { 

        private readonly GroupService _groupService;
        public GroupController()
        {
            _groupService = new GroupService();
        }
        public async Task CreateGroup()
        {
           await _groupService.CreateGroupAsync(new() { Limit=20,No="PB330",CreatedDate=DateTime.Now});
        }
       
    }
}
