using Academy.Core.Entities;
using Academy.Service.Dtos.GroupDtos;

namespace Academy.Service.Interfaces
{
    public interface IGroupService
    {
        void CreateGroup(GroupCreateDto groupCreateDto);
        Task CreateGroupAsync(GroupCreateDto groupCreateDto);
        Task DeleteGroupById(int? id);
        Task DeleteGroupByIdAsync(int? id);
        GroupReturnDto GetGroupById(int? id);
        Group GetGroupByIdAdmin(int? id);
        Task<Group> GetGroupByIdAdminAsync(int? id);
        Task<GroupReturnDto> GetGroupByIdAsync(int? id);
        List<Group> GetGroups();
        Task<List<Group>> GetGroupsAsync();
        bool IsExist(string no);
        Task<bool> IsExistAsync(string no);
        void UpdateGroup(int? id, Group group);
        Task UpdateGroupAsync(int? id, Group group);
    }
}